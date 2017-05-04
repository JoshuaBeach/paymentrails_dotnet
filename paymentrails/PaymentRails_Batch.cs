﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentrails
{
   public class PaymentRails_Batch
    {
        /// <summary>
        /// Retrieves the batch based on the batch_id
        /// </summary>
        /// <param name="batch_id"></param>
        /// <returns>The response</returns>
        public static String get(String batch_id)
        {
            String endPoint = "/v1/batches/" + batch_id;
            PaymentRails_Client client = PaymentRails_Client.create();
            String response = client.get(endPoint);
            return response;
        }
        /// <summary>
        /// Creates a batch based on the body or
        /// Genereates a quote based on batch_id or
        /// Starts processing the batch based on the batch_id
        /// </summary>
        /// <param name="body"></param>
        /// <param name="batch_id"></param>
        /// <returns>The response</returns>
        public static String post(String body,String batch_id = "")
        {
            String endPoint = "/v1/batches/" + batch_id;
            PaymentRails_Client client = PaymentRails_Client.create();
            String response = client.post(endPoint, body);
            return response;
        }
        /// <summary>
        /// Updates a batch based on batch id and the body
        /// </summary>
        /// <param name="batch_id"></param>
        /// <param name="body"></param>
        /// <returns>The response</returns>
        public static String patch(String batch_id, String body)
        {
            String endPoint = "/v1/batches/" + batch_id;
            PaymentRails_Client client = PaymentRails_Client.create();
            String response = client.patch(endPoint, body);
            return response;
        }
        /// <summary>
        /// Deletes a batch based on the batch id
        /// </summary>
        /// <param name="batch_id"></param>
        /// <returns>The response</returns>
        public static String delete(String batch_id)
        {
            String endPoint = "/v1/batches/" + batch_id;
            PaymentRails_Client client = PaymentRails_Client.create();
            String response = client.delete(endPoint);
            return response;
        }
        /// <summary>
        /// Lists all batches based on queries
        /// </summary>
        /// <param name="term"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static String query(String term = "", int page = 1, int pageSize = 10)
        {
            String endPoint = "/v1/batches/?" + "&search=" + term + "&page=" + page + "&pageSize=" + pageSize;
            PaymentRails_Client client = PaymentRails_Client.create();
            String response = client.get(endPoint);
            return response;
        }
        /// <summary>
        /// Generates quote based on batch id
        /// </summary>
        /// <param name="batch_id"></param>
        /// <returns>The response</returns>
        public static String generateQuote(String batch_id)
        {
            String endPoint = batch_id + "/generate-quote";
            String response = post("", endPoint);
            return response;
        }
        /// <summary>
        /// Starts Processing a batch based on the batch id
        /// </summary>
        /// <param name="batch_id"></param>
        /// <returns>The response</returns>
        public static String processBatch(String batch_id)
        {
            String endPoint = batch_id + "/start-processing";
            String response = post("", endPoint);
            return response;
        }
        /// <summary>
        /// Retrieves a summary based on the batch id
        /// </summary>
        /// <param name="batch_id"></param>
        /// <returns>The response</returns>
        public static String summary(String batch_id)
        {
            String endPoint = batch_id + "/summary";
            String response = get(endPoint);
            return response;
        }

    }
}