# Payment Rails C# SDK

A native C# SDK for the Payment Rails API

For more information about the API as well as C# code samples check out the [full API documentation](http://docs.paymentrails.com)


## Installation

#

#### For [C#](https://docs.microsoft.com/en-us/dotnet/articles/csharp/index)

#
### To install the reference: 
#### with dll  
In Solution Explorer, right-click the project node and click Add Reference. Selec the dll in the file explorer and confirm your selection.

#### With NuGet
Open your package manager console and enter:  
`PM> Install-Package PaymentRails.SDK`


The library is hosted on github [here](https://github.com/PaymentRails/paymentrails_dotnet)

## Getting Started
### Namespaces
+ PaymentRails
+ PaymentRails.Types
+ PaymentRails.Exceptions
### Simple example

```csharp
// A simple c# application using the Payment Rails SDK
using paymentrails.Types;
using paymentrails;

class Program
{
    static void Main(string[] args)
    {
        // set your API key
        PaymentRails_Configuration.ApiKey = "<YOUR-API-KEY>";
        // request away
        Dictionary<String, Balance> balances = PaymentRails_Balances.get();
        foreach(KeyValuePair<String, Balance> balance in balances)
        {
            Console.WriteLine(String.Format("My {0} balance is {1}", balance.Key, balance.Value.Amount));
        }
        Console.Read();
    }
}

```
Output
>My USD balance is 1463430.27  
>My paypal balance is 5000.00  

## Documentation for API Endpoint Methods

All URIs are relative to *https://api.paymentrails.com/v1*

Class | Method | HTTP request
------------ | ------------- | ------------- 
*PaymentRails_Recipient | [**get**](docs/PaymentRails_Recipient.md#get) | **GET** /recipient/ 
*PaymentRails_Recipient | [**post**](docs/PaymentRails_Recipient.md#post) | **POST** /recipient/ 
*PaymentRails_Recipient | [**patch**](docs/PaymentRails_Recipient.md#patch) | **PATCH** /recipient/ 
*PaymentRails_Recipient | [**delete**](docs/PaymentRails_Recipient.md#delete) | **DELETE** /recipient/ 
*PaymentRails_Recipient | [**query**](docs/PaymentRails_Recipient.md#query) | **GET** /recipient/ 
*PaymentRails_PayoutMethods | [**get**](docs/PaymentRails_PayoutMethods.md#get) | **GET** /recipient/<recipient_id>/payout-methods 
*PaymentRails_PayoutMethods | [**post**](docs/PaymentRails_PayoutMethods.md#post) | **POST** /recipient/<recipient_id>/payout-methods 
*PaymentRails_PayoutMethods | [**patch**](docs/PaymentRails_PayoutMethods.md#patch) | **PATCH** /recipient/<recipient_id>/payout-methods 
*PaymentRails_Batch | [**get**](docs/PaymentRails_Batch.md#get) | **GET** /batch/ 
*PaymentRails_Batch | [**post**](docs/PaymentRails_Batch.md#post) | **POST** /batch/ 
*PaymentRails_Batch | [**patch**](docs/PaymentRails_Batch.md#patch) | **PATCH** /batch/ 
*PaymentRails_Batch | [**delete**](docs/PaymentRails_Batch.md#delete) | **DELETE** /batch/ 
*PaymentRails_Batch | [**query**](docs/PaymentRails_Batch.md#query) | **GET** /batch/ 
*PaymentRails_Batch | [**generateQuote**](docs/PaymentRails_Batch.md#generateQuote) | **POST** /batch/ 
*PaymentRails_Batch | [**processBatch**](docs/PaymentRails_Batch.md#processBatch) | **POST** /batch/ 
*PaymentRails_Batch | [**summary**](docs/PaymentRails_Batch.md#summary) | **GET** /batch/ 
*PaymentRails_Payment | [**get**](docs/PaymentRails_Payment.md#get) | **GET** /payments/ 
*PaymentRails_Payment | [**post**](docs/PaymentRails_Payment.md#post) | **POST** /batch/<batch_id>/payments 
*PaymentRails_Payment | [**patch**](docs/PaymentRails_Payment.md#patch) | **PATCH** /batch/<batch_id>/payments 
*PaymentRails_Payment | [**delete**](docs/PaymentRails_Payment.md#delete) | **DELETE** /batch/<batch_id>/payments 
*PaymentRails_Payment | [**query**](docs/PaymentRails_Payment.md#query) | **GET** /payments/ 
*PaymentRails_Balances | [**get**](docs/PaymentRails_Balances.md#get) | **GET** /balances/ 

## Documentation for Types

 - [Address](docs/types/Address.md)
 - [PaypalAccount](docs/types/PaypalAccount.md)
 - [BankAccount](docs/types/BankAccount.md)
 - [Payout](docs/types/Payout.md)
 - [Recipient](docs/types/Recipient.md)
 - [Payment](docs/types/Payment.md)
 - [Batch](docs/types/Batch.md)
 - [Compliance](docs/types/Compliance.md)
 - [Balance](docs/types/Balance.md)
 
 ## Documentation for Authorization


### merchantKey

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header