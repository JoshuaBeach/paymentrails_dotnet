using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRails
{
    public class PaymentRails_Configuration
    {
        private static string apiKey;
        private static string apiBase = "https://api.paymentrails.com";

        public static string ApiKey
        {
            get
            {
                return apiKey;
            }
            set
            {
                apiKey = value;
            }
        }

        public static string PublicKey { get; set; }
        public static string PrivateKey { get; set; }

        public static string ApiBase
        {
            get
            {
                return apiBase;
            }
        }

        public static string AssemblyVersion { get; } = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        /// <summary>
        /// Gets the API Base --> change everywhere that this is used to use properties
        /// </summary>
        /// <returns>The APiBase</returns>
        public static String getApiBase()
        {
            return PaymentRails_Configuration.apiBase;
        }

        /// <summary>
        /// Sets the API Base --> change everywhere that this is used to use properties
        /// </summary>
        /// <param name="apiBase"></param>
        public static void setApiBase(String apiBase)
        {
            PaymentRails_Configuration.apiBase = apiBase;
        }
    }
}