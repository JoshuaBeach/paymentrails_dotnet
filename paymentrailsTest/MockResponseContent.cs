﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentrailsTest
{
    class MockResponseContent
    {
        public const string VALID_PAYMENT = @"{""ok"":true,""payment"":{""id"":""P-91XPY3G2FNPHJ"",""recipient"":{""id"":""R-DE0366D6494349B7"",""referenceId"":""Ruby_Hickle7379@yahoo.ca"",""email"":""Ruby_Hickle7379@yahoo.ca"",""name"":""Ruby Hickle7379"",""lastName"":""Hickle7379"",""firstName"":""Ruby"",""type"":""business"",""status"":""active"",""language"":""en"",""complianceStatus"":""pending"",""dob"":null,""payoutMethod"":""paypal"",""updatedAt"":""2016-11-10T09:47:22.857Z"",""createdAt"":""2016-11-10T09:47:22.437Z"",""gravatarUrl"":""https://s3.amazonaws.com/static.api.paymentrails.com/icon_business.svg"",""compliance"":{""status"":""pending"",""checkedAt"":""2016-11-10T09:47:22.839Z""},""payout"":{""autoswitch"":{""limit"":1000,""active"":false},""holdup"":{""limit"":1000,""active"":false},""primary"":{""method"":""paypal"",""currency"":{""currency"":{}}},""method"":""paypal"",""accounts"":{""paypal"":{""address"":""Ruby_Hickle7379@yahoo.ca""}},""methodDisplay"":""PayPal""},""address"":{""street1"":null,""street2"":null,""city"":null,""postalCode"":null,""country"":null,""region"":null,""phone"":null}},""status"":""pending"",""sourceAmount"":""0.00"",""exchangeRate"":""1.000000"",""fees"":""0.00"",""recipientFees"":""0.00"",""targetAmount"":""0.00"",""fxRate"":""2.000000"",""memo"":"""",""processedAt"":null,""createdAt"":""2017-05-02T17:08:11.362Z"",""updatedAt"":""2017-05-02T17:08:11.362Z"",""merchantFees"":""0.00"",""compliance"":{""status"":""pending"",""checkedAt"":null},""sourceCurrency"":""USD"",""sourceCurrencyName"":""US Dollar"",""targetCurrency"":""USD"",""targetCurrencyName"":""US Dollar"",""batch"":{""id"":""B-91XPY3G229AQ8"",""createdAt"":""2017-05-02T17:08:11.316Z"",""updatedAt"":""2017-05-02T17:08:11.394Z"",""sentAt"":null,""completedAt"":null}}}";
    }
}
