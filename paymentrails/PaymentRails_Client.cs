using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Linq;
using PaymentRails.Exceptions;
using PaymentRails.Types;
using PaymentRails.Extensions;
using System.Security.Cryptography;
using System.Reflection;

namespace PaymentRails
{
    /// <summary>
    /// A Class that makes HTTP Requests to the API.
    /// </summary>
    public class PaymentRails_Client
    {
        //For some reason .NET does not list PATCH, so we create one here.
        private static readonly HttpMethod PATCH_METHOD = new HttpMethod("PATCH");

        //Moved to a Lazy wrapper to avoid thread-safety issues around parallel construction
        private static Lazy<PaymentRails_Client> _clientInstance = new Lazy<PaymentRails_Client>(() => new PaymentRails_Client());

        //Created a private property to hide the .Value property of the Lazy to play nice with existing code
        private static PaymentRails_Client clientInstance
        {
            get { return _clientInstance.Value; }
        }

        private HttpClient httpClient;

        /// <summary>
        /// The client instance
        /// </summary>
        public static PaymentRails_Client ClientInstance
        {
            get
            {
                return clientInstance;
            }
        }

        /// <summary>
        /// The HttpMessageHandler
        /// </summary>
        public static HttpMessageHandler HttpMessageHandler
        {
            set
            {
                //Consider thread-safety issues on static.
                //Recommend either to remove the option to change the Handler, or reconstuct the whole clientInstance vs the internal httpClient

                clientInstance.httpClient.Dispose();
                clientInstance.httpClient = new HttpClient(value);
                clientInstance.httpClient.BaseAddress = new Uri(PaymentRails_Configuration.ApiBase);
            }
        }

        /// <summary>
        /// Default constructor that inits the HttpClient with AutomaticDecompression
        /// </summary>
        private PaymentRails_Client()
            : this(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate })
        {
        }

        /// <summary>
        /// One parameter constructor
        /// </summary>
        /// <param name="handler"></param>
        private PaymentRails_Client(HttpMessageHandler handler)
        {
            this.httpClient = new HttpClient(handler);
            this.httpClient.BaseAddress = new Uri(PaymentRails_Configuration.ApiBase);
            this.httpClient.DefaultRequestHeaders.Clear();
            this.httpClient.DefaultRequestHeaders.Add("UserAgent", "PaymentRails C# Library version=" + PaymentRails_Configuration.AssemblyVersion);
        }

        /// <summary>
        /// Factory method to create an instance
        ///
        /// Kept for the sake of not breaking everything while transitioning to singleton
        /// </summary>
        /// <returns>The instance of PaymentRails_Client</returns>
        public static PaymentRails_Client CreateClient()
        {
            return ClientInstance;
        }

        /// <summary>
        /// Makes a GET request to API
        /// </summary>
        /// <param name="endPoint">The api endPoint</param>
        /// <returns>The response</returns>
        public String get(String endPoint)
        {
            return SendMessage(endPoint, HttpMethod.Get, "");
        }

        /// <summary>
        /// Makes a POST request to API
        /// </summary>
        /// <param name="endPoint">The api endPoint</param>
        /// <param name="stringBody">The request payload</param>
        /// <returns>The Response</returns>
        public String post(String endPoint, IPaymentRailsMappable body) // change body to accept IJsonMappable objects
        {
            body.IsMappable();
            return SendMessage(endPoint, HttpMethod.Post, body.ToJson());
        }

        /// <summary>
        /// Method used to post to endpoints with no data, this is used for endpoints such as
        /// batch/:batch_id/generate_quote
        /// </summary>
        /// <param name="endpoint">The api endPoint</param>
        /// <returns></returns>
        public string PostEmpty(String endPoint)
        {
            return SendMessage(endPoint, HttpMethod.Post, "");
        }

        /// <summary>
        /// Makes a POST request to API
        /// </summary>
        /// <param name="endPoint">The api endPoint</param>
        /// <param name="stringBody">The request payload</param>
        /// <returns>The response</returns>
        public String patch(String endPoint, IPaymentRailsMappable body) // change body to accept IJsonMappable objects
        {
            body.IsMappable();
            return SendMessage(endPoint, PATCH_METHOD, body.ToJson());
        }

        /// <summary>
        /// Makes A DELETE request to API
        /// </summary>
        /// <param name="endPoint">The api endPoint</param>
        /// <returns>The response</returns>
        public String delete(String endPoint)
        {
            return SendMessage(endPoint, HttpMethod.Delete, "");
        }

        private string SendMessage(string endPoint, HttpMethod method, string body)
        {
            string result = "";
            try
            {
                HttpRequestMessage request = CreateHttpRequest(endPoint, method, body);
                HttpResponseMessage response = httpClient.SendAsync(request).Result;
                result = response.Content.ReadAsStringAsync().Result;
                response.EnsureSuccessStatusCode();
            }
            catch (System.Net.Http.HttpRequestException e)
            {
                throw new InvalidStatusCodeException(result, e);
            }
            catch (System.AggregateException e)
            {
                throw new InvalidServerRequest("An error occurred while sending the request.", e);
            }
            return result;
        }

        /// <summary>
        /// Converts String into HTTPContent
        /// </summary>
        /// <param name="body">The request payload</param>
        /// <returns>The HTTPContent</returns>
        private HttpRequestMessage CreateHttpRequest(string endPoint, HttpMethod method, string body)
        {
            HttpRequestMessage message = new HttpRequestMessage(method, endPoint);

            //No Content on a Get
            if (method != HttpMethod.Get)
                message.Content = new StringContent(body, UTF8Encoding.UTF8, "application/json");

            var headers = GetAuthorizationHeaders(endPoint, method, body);
            foreach (Tuple<string, string> header in headers)
                message.Headers.Add(header.Item1, header.Item2);

            return message;
        }

        private Tuple<string, string>[] GetAuthorizationHeaders(string endPoint, HttpMethod method, string body)
        {
            string timestamp = DateTime.UtcNow.ToUnixTimeStamp().ToString();

            string message = $"{timestamp}\n{method}\n{endPoint}\n{body}\n";
            string signature = GenerateSignature(message);

            List<Tuple<string, string>> headers = new List<Tuple<string, string>>();

            headers.Add(new Tuple<string, string>("X-PR-Timestamp", timestamp));
            headers.Add(new Tuple<string, string>("Authorization", signature));

            return headers.ToArray();
        }

        private string GenerateSignature(string message)
        {
            Encoding encoding = Encoding.UTF8;

            try
            {
                byte[] privateKey = encoding.GetBytes(PaymentRails_Configuration.PrivateKey);
                byte[] data = encoding.GetBytes(message);

                HMACSHA256 hmac = new HMACSHA256(privateKey);
                byte[] hash = hmac.ComputeHash(data);
                string hashStr = BitConverter.ToString(hash).Replace("-", "").ToLower();

                return $"prsign {PaymentRails_Configuration.PublicKey}:{hashStr}";
            }
            catch
            {
                return "prsign 1:1";
            }
        }
    }
}