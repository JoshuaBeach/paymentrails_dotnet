﻿using System;
using PaymentRails.Types;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRails.JsonHelpers
{
    public class PaymentHelper : JsonHelper
    {
        /// <summary>
        /// Method that converts a JSON string to a List of Payment objects
        /// </summary>
        /// <param name="jsonResponse"></param>
        /// <returns>The List of Payment that the JSON object represented</returns>
        public static List<Payment> JsonToPaymentList(string jsonResponse)
        {
            if (jsonResponse == null || jsonResponse == "")
            {
                throw new ArgumentException("JSON must be provided");
            }
            PaymentListJsonHelper helper = new JavaScriptSerializer().Deserialize<PaymentListJsonHelper>(jsonResponse);
            List<Payment> payments = new List<Payment>();

            if (helper.Ok)
            {
                foreach (PaymentJsonHelper p in helper.Payments)
                {
                    payments.Add(PaymentJsonHelperToPayment(p));
                }
            }
            return payments;
        }
        /// <summary>
        /// Method that converts a JSON string to a Paymentobjects
        /// </summary>
        /// <param name="jsonResponse"></param>
        /// <returns>The Payment that the JSON object represented</returns>
        public static Payment JsonToPayment(string jsonResponse)
        {
            if (jsonResponse == null || jsonResponse == "")
            {
                throw new ArgumentException("JSON must be provided");
            }
            PaymentResponseJsonHelper helper = new JavaScriptSerializer().Deserialize<PaymentResponseJsonHelper>(jsonResponse);
            Payment payment = PaymentJsonHelperToPayment(helper.Payment);
            return payment;
        }
    }
}
