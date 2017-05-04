﻿using System;
using System.Text;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Web;
namespace paymentrails
{
    class Program
    {

        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            PaymentRails_Configuration.setApiBase("http://api.local.dev:3000");
            PaymentRails_Configuration.apiKey = "pk_test_91XPUY8D8GAGA";

            var val = PaymentRails_PayoutMethods.get("R-91XQ00KM0CPMR");
            
            //val.Bank = new Types.BankAccount("CAD", "abc bank", "123412", "1231", "CAD", "CA", "abc bank");
            val.Paypal = null;
            val.AutoswitchActive = true;
            val.AutoswitchLimit = 30000;
            val.HoldupActive = false;
            Console.WriteLine(val.ToJson());
            string resp = PaymentRails_PayoutMethods.patch("R-91XQ00KM0CPMR", val);
            Console.WriteLine(resp);
            var updatedVal = PaymentRails_PayoutMethods.get("R-91XQ00KM0CPMR");
            Console.WriteLine(updatedVal);
            Console.Read();

        }       
    }
}