﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRails
{
    /// <summary>
    /// A Class that facilitates HTTP Requests to the API in regards to Balances.
    /// </summary>
    
    public class PaymentRails_Balances
    {
        /// <summary>
        /// Retrieves all balances from the Payment Rails API for the specified type,
        /// if no type is selected it will return the paymentrails type balances
        /// </summary>
        /// <param name="type">The type of account to fetch the balance from. Can be "paymentrails", "paypal"</param>
        /// <returns>A balance dictionary containing a balance for each of your currencies (USD, CAD, ...)</returns>
        public static Dictionary<String, Types.Balance> get(String type = "")
        {
            String endPoint = "/v1/profile/balances/" + type;
            PaymentRails_Client client = PaymentRails_Client.CreateClient();
            String response = client.get(endPoint);
            Dictionary<String, Types.Balance> balanceDictionary = JsonHelpers.BalanceHelper.JsonToBalanceDictionary(response);
            return balanceDictionary;
        }

    }
}
