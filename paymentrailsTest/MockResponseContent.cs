﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentrailsTest
{
    class MockResponseContent
    {
        public const string VALID_PAYMENT = @"{""ok"":true,""payment"":{""id"":""P-91XPY3G2FNPHJ"",""recipient"":{""id"":""R-DE0366D6494349B7"",""referenceId"":""Ruby_Hickle7379@yahoo.ca"",""email"":""Ruby_Hickle7379@yahoo.ca"",""name"":""Ruby Hickle7379"",""lastName"":""Hickle7379"",""firstName"":""Ruby"",""type"":""business"",""status"":""active"",""language"":""en"",""complianceStatus"":""pending"",""dob"":null,""payoutMethod"":""paypal"",""updatedAt"":""2016-11-10T09:47:22.857Z"",""createdAt"":""2016-11-10T09:47:22.437Z"",""gravatarUrl"":""https://s3.amazonaws.com/static.api.paymentrails.com/icon_business.svg"",""compliance"":{""status"":""pending"",""checkedAt"":""2016-11-10T09:47:22.839Z""},""payout"":{""autoswitch"":{""limit"":1000,""active"":false},""holdup"":{""limit"":1000,""active"":false},""primary"":{""method"":""paypal"",""currency"":{""currency"":{}}},""method"":""paypal"",""accounts"":{""paypal"":{""address"":""Ruby_Hickle7379@yahoo.ca""}},""methodDisplay"":""PayPal""},""address"":{""street1"":null,""street2"":null,""city"":null,""postalCode"":null,""country"":null,""region"":null,""phone"":null}},""status"":""pending"",""sourceAmount"":""1.00"",""exchangeRate"":""1.000000"",""fees"":""0.00"",""recipientFees"":""0.00"",""targetAmount"":""0.00"",""fxRate"":""2.000000"",""memo"":"""",""processedAt"":null,""createdAt"":""2017-05-02T17:08:11.362Z"",""updatedAt"":""2017-05-02T17:08:11.362Z"",""merchantFees"":""0.00"",""compliance"":{""status"":""pending"",""checkedAt"":null},""sourceCurrency"":""USD"",""sourceCurrencyName"":""US Dollar"",""targetCurrency"":""USD"",""targetCurrencyName"":""US Dollar"",""batch"":{""id"":""B-91XPY3G229AQ8"",""createdAt"":""2017-05-02T17:08:11.316Z"",""updatedAt"":""2017-05-02T17:08:11.394Z"",""sentAt"":null,""completedAt"":null}}}";
        public const string VALID_PAYMENT_LIST = @"{""ok"":true,""payments"":[{""id"":""P-91YPY3G2FNPHJ"",""recipient"":{""id"":""R-DE0366D6494349B7"",""referenceId"":""Ruby_Hickle7379@yahoo.ca"",""email"":""Ruby_Hickle7379@yahoo.ca"",""name"":""Ruby Hickle7379"",""lastName"":""Hickle7379"",""firstName"":""Ruby"",""type"":""business"",""status"":""active"",""language"":""en"",""complianceStatus"":""pending"",""dob"":null,""payoutMethod"":""paypal"",""updatedAt"":""2016-11-10T09:47:22.857Z"",""createdAt"":""2016-11-10T09:47:22.437Z"",""gravatarUrl"":""https://s3.amazonaws.com/static.api.paymentrails.com/icon_business.svg"",""compliance"":{""status"":""pending"",""checkedAt"":""2016-11-10T09:47:22.839Z""},""payout"":{""autoswitch"":{""limit"":1000,""active"":false},""holdup"":{""limit"":1000,""active"":false},""primary"":{""method"":""paypal"",""currency"":{""currency"":{}}},""method"":""paypal"",""accounts"":{""paypal"":{""address"":""Ruby_Hickle7379@yahoo.ca""}},""methodDisplay"":""PayPal""},""address"":{""street1"":null,""street2"":null,""city"":null,""postalCode"":null,""country"":null,""region"":null,""phone"":null}},""status"":""pending"",""sourceAmount"":""1.00"",""exchangeRate"":""1.000000"",""fees"":""0.00"",""recipientFees"":""0.00"",""targetAmount"":""0.00"",""fxRate"":""2.000000"",""memo"":"""",""processedAt"":null,""createdAt"":""2017-05-02T17:08:11.362Z"",""updatedAt"":""2017-05-02T17:08:11.362Z"",""merchantFees"":""0.00"",""compliance"":{""status"":""pending"",""checkedAt"":null},""sourceCurrency"":""USD"",""sourceCurrencyName"":""US Dollar"",""targetCurrency"":""USD"",""targetCurrencyName"":""US Dollar"",""batch"":{""id"":""B-91XPY3G229AQ8"",""createdAt"":""2017-05-02T17:08:11.316Z"",""updatedAt"":""2017-05-02T17:08:11.394Z"",""sentAt"":null,""completedAt"":null}}, {""id"":""P-91XPY3G2FNPHJ"",""recipient"":{""id"":""R-DE0366D6494349B7"",""referenceId"":""Ruby_Hickle7379@yahoo.ca"",""email"":""Ruby_Hickle7379@yahoo.ca"",""name"":""Ruby Hickle7379"",""lastName"":""Hickle7379"",""firstName"":""Ruby"",""type"":""business"",""status"":""active"",""language"":""en"",""complianceStatus"":""pending"",""dob"":null,""payoutMethod"":""paypal"",""updatedAt"":""2016-11-10T09:47:22.857Z"",""createdAt"":""2016-11-10T09:47:22.437Z"",""gravatarUrl"":""https://s3.amazonaws.com/static.api.paymentrails.com/icon_business.svg"",""compliance"":{""status"":""pending"",""checkedAt"":""2016-11-10T09:47:22.839Z""},""payout"":{""autoswitch"":{""limit"":1000,""active"":false},""holdup"":{""limit"":1000,""active"":false},""primary"":{""method"":""paypal"",""currency"":{""currency"":{}}},""method"":""paypal"",""accounts"":{""paypal"":{""address"":""Ruby_Hickle7379@yahoo.ca""}},""methodDisplay"":""PayPal""},""address"":{""street1"":null,""street2"":null,""city"":null,""postalCode"":null,""country"":null,""region"":null,""phone"":null}},""status"":""pending"",""sourceAmount"":""1.00"",""exchangeRate"":""1.000000"",""fees"":""0.00"",""recipientFees"":""0.00"",""targetAmount"":""0.00"",""fxRate"":""2.000000"",""memo"":"""",""processedAt"":null,""createdAt"":""2017-05-02T17:08:11.362Z"",""updatedAt"":""2017-05-02T17:08:11.362Z"",""merchantFees"":""0.00"",""compliance"":{""status"":""pending"",""checkedAt"":null},""sourceCurrency"":""USD"",""sourceCurrencyName"":""US Dollar"",""targetCurrency"":""CAD"",""targetCurrencyName"":""US Dollar"",""batch"":{""id"":""B-91XPY3G229AQ8"",""createdAt"":""2017-05-02T17:08:11.316Z"",""updatedAt"":""2017-05-02T17:08:11.394Z"",""sentAt"":null,""completedAt"":null}}]}";
        public const string VALID_POST = @"{""ok"":true}";
        public const string VALID_BALANCE = @"{""ok"":true,""balances"":{""USD"":{""primary"":true,""amount"":""1463430.27"",""currency"":""USD"",""type"":""paymentrails"",""accountNumber"":""0000848""},""CAD"":{""primary"":false,""amount"":""20000.89"",""currency"":""CAD"",""type"":""paymentrails"",""accountNumber"":""0000867""},""EUR"":{""primary"":false,""amount"":""790473.12"",""currency"":""EUR"",""type"":""paymentrails"",""accountNumber"":""0000847""},""GBP"":{""primary"":false,""amount"":""761316.01"",""currency"":""GBP"",""type"":""paymentrails"",""accountNumber"":""0000846""},""paypal"":{""primary"":false,""amount"":""0.00"",""currency"":""CAD"",""type"":""paypal"",""accountNumber"":null}}}";
        public const string VALID_BALANCE_PAYPAL = @"{""ok"":true,""balances"":{""paypal"":{""primary"":false,""amount"":""0.00"",""currency"":""CAD"",""type"":""paypal"",""accountNumber"":null}}}";
        public const string VALID_BALANCE_PAYMENTRAILS = @"{""ok"":true,""balances"":{""USD"":{""primary"":true,""amount"":""1463430.27"",""currency"":""USD"",""type"":""paymentrails"",""accountNumber"":""0000848""},""CAD"":{""primary"":false,""amount"":""20000.89"",""currency"":""CAD"",""type"":""paymentrails"",""accountNumber"":""0000867""},""EUR"":{""primary"":false,""amount"":""790473.12"",""currency"":""EUR"",""type"":""paymentrails"",""accountNumber"":""0000847""},""GBP"":{""primary"":false,""amount"":""761316.01"",""currency"":""GBP"",""type"":""paymentrails"",""accountNumber"":""0000846""}}}";
        public const string VALID_BATCH = @"{""ok"":true,""batch"":{""id"":""B-91XPY33G30FN0"",""status"":""open"",""amount"":""0.00"",""totalPayments"":1,""currency"":""USD"",""description"":""Weekly Payouts on 2017-4-2"",""sentAt"":null,""completedAt"":null,""createdAt"":""2017-05-02T16:53:22.852Z"",""updatedAt"":""2017-05-02T16:53:22.920Z"",""payments"":{""payments"":[{""id"":""P-91XPY33GF805R"",""recipient"":{""id"":""R-918F1CE0D21BCF34"",""referenceId"":""Wendy_OHara1985154@gmail.com"",""email"":""Wendy_OHara1985154@gmail.com"",""name"":""Wendy O'Hara19851"",""status"":""active"",""countryCode"":null},""method"":""paypal"",""methodDisplay"":""PayPal"",""status"":""pending"",""sourceAmount"":""1.00"",""targetAmount"":""0.00"",""isSupplyPayment"":false,""memo"":"""",""fees"":""0.00"",""recipientFees"":""0.00"",""exchangeRate"":""1.000000"",""processedAt"":null,""merchantFees"":""0.00"",""sourceCurrency"":""USD"",""sourceCurrencyName"":""US Dollar"",""targetCurrency"":""USD"",""targetCurrencyName"":""US Dollar"",""compliance"":{""status"":""pending"",""checkedAt"":null}}],""meta"":{""page"":1,""pages"":1,""records"":1}}}}";
        public const string VALID_BATCH_LIST = @"{""ok"":""true"",""batches"":[{""id"":""B-91XPY33G30FN0"",""status"":""open"",""amount"":""0.00"",""totalPayments"":1,""currency"":""USD"",""description"":""Weekly Payouts on 2017-4-2"",""sentAt"":null,""completedAt"":null,""createdAt"":""2017-05-02T16:53:22.852Z"",""updatedAt"":""2017-05-02T16:53:22.920Z""}]}";

        public const string VALID_RECIPIENT = @"{""ok"":true,""recipient"":{""id"":""R-91XQ4VKD39C3P"",""referenceId"":""tess@example.com"",""email"":""tess@example.com"",""name"":""John Smith"",""lastName"":""Smith"",""firstName"":""John"",""type"":""individual"",""status"":""incomplete"",""language"":""en"",""complianceStatus"":""pending"",""dob"":null,""payoutMethod"":null,""updatedAt"":""2017-05-09T19:11:37.647Z"",""createdAt"":""2017-05-09T19:11:37.647Z"",""gravatarUrl"":""https://s3.amazonaws.com/static.api.paymentrails.com/icon_user.svg"",""compliance"":{""status"":""pending"",""checkedAt"":null},""payout"":{""method"":null},""address"":{""street1"":null,""street2"":null,""city"":null,""postalCode"":null,""country"":null,""region"":null,""phone"":null}}}";
        public const string VALID_RECIPIENT_LIST = @"{""ok"":true,""recipients"":[{""id"":""R-91XQ4VKD39C3P"",""referenceId"":""tess@example.com"",""email"":""tess@example.com"",""name"":""John Smith"",""lastName"":""Smith"",""firstName"":""John"",""type"":""individual"",""status"":""incomplete"",""language"":""en"",""complianceStatus"":""pending"",""dob"":null,""payoutMethod"":null,""updatedAt"":""2017-05-09T19:11:37.647Z"",""createdAt"":""2017-05-09T19:11:37.647Z"",""gravatarUrl"":""https://s3.amazonaws.com/static.api.paymentrails.com/icon_user.svg"",""compliance"":{""status"":""pending"",""checkedAt"":null},""payout"":{""method"":null},""address"":{""street1"":null,""street2"":null,""city"":null,""postalCode"":null,""country"":null,""region"":null,""phone"":null}}]}";
        public const string VALID_PAYOUT = @"{""ok"":true,""autoswitch"":{""limit"":1000,""active"":false},""holdup"":{""limit"":1000,""active"":false},""primary"":{""method"":""bank"",""currency"":{""currency"":{""code"":""USD"",""name"":""US Dollar""}}},""method"":""bank"",""accounts"":{}}";
        public const string INVALID_NOT_FOUND = @"{""ok"":false, ""message"":""not found""}";
        public const string INVALID_BAD_DATA = @"{""ok"":false, ""message"":""bad data""}";
        public const string INVALID_UNAUTHORISED = @"{""ok"":false, ""message"":""bad api key""}";
        // P-91YPY3G2FNPHJ


    }
}

