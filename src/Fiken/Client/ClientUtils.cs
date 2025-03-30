/*
 * Fiken API
 *
 *  ## Introduction [Fiken.no](https://fiken.no) is an online accounting system aimed at making accounting easy for small businesses. The API Module allows other systems to integrate with Fiken. This document describes Fiken's API.  ## Using the API Use of this API in production environments on live data is normally associated with a fee for the end user (company). API access costs 99kr per month and can be ordered through the Module access page under Settings in your Fiken account. If you have any questions regarding the API pricing, contact us at <api@fiken.no>.  The API provides two different ways of authorizing requests.    1. OAuth2   2. Personal API tokens  Third parties that wish to integrate with Fiken on behalf of their customers should use the OAuth2 authorization method. In order to develop OAuth2 applications that integrate with this API you must log into your Fiken account and check the box saying that you are a developer (**Rediger konto -> Profil -> Andre innstillinger**). This will allow you to create an App by clicking on the \"API\" tab under Brukerinnstillinger. If you don't have an existing Fiken account you can create a new user and demo company (demoforetak) at no charge. Send an email to <api@fiken.no> to get free access to Fiken for longer than the included 30 day free trial period.   Upon creation of the new App you will be provided a Client ID and Client Secret that are needed for the OAuth2 authorization flow.  This will allow you to use the API during development with up to 5 users. If you would like to use the API with more than 5 users and gain production status, you will need to send an email to <api@fiken.no> to gain full access to the API module.  Fiken customers that wish to integrate their own solutions with this API can use personal API tokens. Personal API tokens can be created in **Rediger konto -> API -> Personlige API-nøkler**. Note that personal API tokens do not expire.  ## Base URL All URLs start with https://api.fiken.no/api/v2. Note that TLS is required, unencrypted HTTP is not supported. Although we currently redirect HTTP requests to HTTPS, you are not allowed to this with your application as using HTTP is a security risk. In the future we might respond with 403 Forbidden instead.  ## Concurrent requests / rate limiting You are only allowed to make a single concurrent API-request. Sending multiple requests concurrently may result in a 429 error response. If you break this rule you might be banned. In case of a ban please contact us to be unbanned.  API calls may be slowed if you execute more than 4 requests per second.  ## Personal API tokens  Personal API tokens can be created in **Rediger konto -> API**. Personal API tokens never expire and can be revoked from the same place.  To use a personal API token simply send it as a bearer token in the `Authorization` header:      GET https://api.fiken.no/api/v2/companies     Authorization: Bearer <api token>  ## Authorization with OAuth2 Fiken API V2 uses OAuth 2.0 for authorizing API requests. Authorized requests to the API should use an `Authorization` header with the value `Bearer <TOKEN>` where `<TOKEN>` is an access token obtained through the OAuth flow.  ### Authorize Endpoint  To start the OAuth flow in order to obtain an access token for a user, you will first have to get consent from the user. To do this, direct your user to the authorization endpoint:      GET https://fiken.no/oauth/authorize?response_type=code&client_id=CLIENT_ID&redirect_uri=REDIRECT_URI&state=STATE  If the user is logged in and accepts your request, the user is redirected back to your redirect url. If the user is not logged in, the regular Fiken.no login form is presented first, requiring the user to authenticate before accepting or rejecting your request.  If the user rejects the request or if there is an error in your request, the user is redirected back to your redirect url with the parameters `error` and `error_description`. If the user rejected the request the error code will be `access_denied`.  #### Parameters  | Name          | Description                                                                                                      | | :- -- -- -- -- -- - | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | response_type | **Required** Should always be the value `code`                                                     | | client_id     | **Required** The client id you received from Fiken when you registered your application                          | | redirect_uri  | **Required** The URL in your application where users will be sent with an authorization code after authorization | | state         | **Required** An unguessable random string, used to protect against CSRF attacks                                  |   ### Token Endpoint  If the user accepts your request, Fiken redirects the user back to your `redirect_uri` with a parameter named `code` as well as the state you provided in the previous step in the `state` parameter. This temporary code will expire after a short while.  The temporary authorization code can be exchanged for an access token at the token endpoint.  The token endpoint is protected with Http Basic Authentication and you should use your application client id and client secret as credentials to authenticate.      POST https://fiken.no/oauth/token     Content-Type: application/x-www-form-urlencoded     Authorization: Basic dXNlIHlvdXIgY2xpZW50IGlkOmFuZCBjbGllbnQgc2VjcmV0      grant_type=authorization_code&code=AUTHCODE&redirect_uri=REDIRECT_URI&state=STATE  The response will contain the access token, a refresh token (see below) as well as information about the expiry time for the token.      {       \"access_token\": \"K2QwoFp4ZfugWLWk7Ipu9kni5cyv3luXKQ-GDShvV2g=\",       \"refresh_token\": \"naFOD_j8m6PFGcP0pfImVZlSxKklHLbgj9Hzao4rhg8=\",       \"token_type\": \"bearer\",       \"expires_in\": 86157     }  If an error occurs during the token exchange request, an error object is returned with an error and an error description.      {         \"error\": \"invalid_grant\",         \"error_description\": \"The authorization code is invalid or expired.\"     }  #### Parameters  | Name         | Description                                                                                                      | | :- -- -- -- -- -- | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | grant_type   | **Required** Should be the value `authorization_code`                                                            | | code         | **Required** The authorization code that was received in the redirect from the authorize endpoint                | | redirect_uri | **Required** The URL in your application where users will be sent with an authorization code after authorization | | state        | **Required** An unguessable random string, used to protect against CSRF attacks                                  |  ### Refresh Tokens  If an access token has expired you can use the refresh token that was sent in the response from the token endpoint to get a new access token.  Note that if the user has revoked the consent to your app, the refresh token will no longer be valid.  To get a new access token from the refresh token, use the token endpoint with the grant type `refresh_token`:      POST https://fiken.no/oauth/token     Content-Type: application/x-www-form-urlencoded     Authorization: Basic dXNlIHlvdXIgY2xpZW50IGlkOmFuZCBjbGllbnQgc2VjcmV0      grant_type=refresh_token&refresh_token=REFRESH_TOKEN  The response contains a fresh access token along with a possibly updated refresh token:      {       \"access_token\": \"K2QwoFp4ZfugWLWk7Ipu9kni5cyv3luXKQ-GDShvV2g=\",       \"refresh_token\": \"naFOD_j8m6PFGcP0pfImVZlSxKklHLbgj9Hzao4rhg8=\",       \"token_type\": \"bearer\",       \"expires_in\": 86157     }  #### Parameters  | Name         | Description                                                                                                      | | :- -- -- -- -- -- | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | grant_type   | **Required** Should be the value `refresh_token`                                                                 | | refresh_token| **Required** The refresh token last returned for this user from the token endpoint                               |  ### Using Access Tokens in API Requests  To execute API requests on behalf of the end user, send the access token obtained at the token endpoint as a bearer token, as in this example:      GET https://api.fiken.no/api/v2/companies     Authorization: Bearer <access_token_value>  ### Revoking tokens  To revoke an access token and refresh token use the Revoke Token endpoint.  The Revoke Token endpoint disables the application grant, the access token and the corresponding refresh token used to authenticate the call. Other access tokens obtained from the same refresh token are also revoked.      POST https://fiken.no/oauth/revoke     Authorization: Bearer <access_token_value>  The response for a successful revocation is 200/OK.  ### Managing access  The end user can manage which companies a given app has access to under **Rediger konto -> Sikkerhet -> Apper du har gitt tilgang til**.  All companies created after the initial consent has been given need to be actively added so that the app will have access to their information.  Additionally the end user can revoke access to any of their companies' data as well.   ## Try It Out  For each endpoint in the documentation below there is a button *Try It Out*. To invoke the API from this documentation you need an app and you need to authorize usage for you Fiken.no user.  Your app needs to be configured with a redirect URL for this documentation, add `https://api.fiken.no/api/v2/docs/oauth2-redirect.html` to the list of redirect URLs for your app.  Click the padlock symbol on any of the endpoints and enter your `client_id` and `client_secret` and then press *Authorize* to start the OAuth2 authorization flow, then click *Close*.  Enter the required parameters for the endpoint, such as `company_slug`, and then press *Execute* to test.  ## Request  We recommend sending the `X-Request-ID` header with all requests.  ### Request Headers | Request  Header           | Format   | Description                                                       | | - -- -- -- -- -- -- -- -          | - -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- --                                     | | `X-Request-ID`            | UUID     | UUID used to identify the request                                 |    ## Response ### Response code All HTTP codes should be expected with their normal semantics. These are some of the common ones:  * **200** for successful GET * **201** for successful POST where you get a Location-header for the created content * **400** when invalid content has be sent (for instance a required field is missing, unexpected fields, wrong format, etc) * **401** when the user is not authenticated * **403** when the user does not have the proper authorization * **404** when the requested content is not found * **405** When you are trying a method to a resource which doesn't support it (i.e. DELETE on an account). * **415** Wrong media type. we accept application/json only.  ### Response Content The default content type on the result of GET requests is application/json. On successful POSTs/PUTs/PATCHs and DELETEs an empty body is returned.  For successful POSTs/PUTs/PATCHs a Location header is given in all cases.  ## Pagination, Sorting & Filtering Pagination, sorting and filtering query parameters are all optional.   | URI                                                                     | Pagination? | Sortable? | Sortable Fields                       | Filterable? | Filtered Fields                                                                                                                         | | :- -- -- -- --                                                              |:- -- -- -- -- -- | :- -- -- -- - | :- -- -- -- -- -- --                        | :- --        | :- --                                                                                                                                    | | https://api.fiken.no/api/v2/companies                                  | Yes         | Yes       | createdDate, name, organizationNumber | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/accounts           | No          | No        |                                       | Yes         | fromAccount, toAccount                                                                                                                  | | https://api.fiken.no/api/v2/companies/{companySlug}/accountBalances    | Yes         | No        |                                       | Yes         | fromAccount, toAccount                                                                                                                  | | https://api.fiken.no/api/v2/companies/{companySlug}/bankAccounts       | Yes         | No        |                                       | Yes         | inactive                                                                                                                                | | https://api.fiken.no/api/v2/companies/{companySlug}/contacts           | Yes         | Yes       | createdDate, lastModified             | Yes         | supplierNumber, customerNumber, memberNumber, memberNumberString, name, organizationNumber, email, group, lastModified, createdDate, inactive, phoneNumber  | | https://api.fiken.no/api/v2/companies/{companySlug}/creditNotes        | Yes         | No        |                                       | Yes         | issueDate, lastModified, settled, customerId                                                                                            | | https://api.fiken.no/api/v2/companies/{companySlug}/inbox              | Yes         | Yes       | createdDate, name                     | Yes         | status, name                                                                                                                            | | https://api.fiken.no/api/v2/companies/{companySlug}/invoices           | Yes         | No        |                                       | Yes         | issueDate, lastModified, dueDate, settled, customerId, orderReference, invoiceDraftUuid                                                 | | https://api.fiken.no/api/v2/companies/{companySlug}/invoices/drafts    | Yes         | No        |                                       | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/journalEntries     | Yes         | No        |                                       | Yes         | date                                                                                                                                    | | https://api.fiken.no/api/v2/companies/{companySlug}/offers             | Yes         | No        |                                       | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/orderConfirmations | Yes         | No        |                                       | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/products           | Yes         | No        |                                       | Yes         | name, productNumber, active, createdDate, lastModified                                                                                  | | https://api.fiken.no/api/v2/companies/{companySlug}/projects           | Yes         | No        |                                       | Yes         | completed                                                                                                                               | | https://api.fiken.no/api/v2/companies/{companySlug}/purchases          | Yes         | Yes       | createdDate                           | No          | date                                                                                                                                    | | https://api.fiken.no/api/v2/companies/{companySlug}/purchases/drafts   | Yes         | No        |                                       | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/sales              | Yes         | No        |                                       | Yes         | saleNumber, lastModified, date, contactId                                                                                               | | https://api.fiken.no/api/v2/companies/{companySlug}/sales/drafts       | Yes         | No        |                                       | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/transactions       | Yes         | No        |                                       | Yes         | createdDate, lastModified                                                                                                               |  ### Pagination By default the API sets `page=0` and `pageSize=25` and returns the first 25 elements in a collection resource, if nothing else is specified. PageSize has a maximum value of 100 meaning that you can only access at most 100 elements at once.  To request a collection resource with pagination, query the resource with the query filters page and pageSize, note that both query parameters need to be set to enable pagination. The page counter starts at 0. The response will contain up to Fiken-Api-Page-Size elements and the response headers below, detailing how many elements the resource has in total and the total number of pages as well.  By default the API returns the resources in the order they were created, if nothing else is specified in the documentation.  #### Pagination Response Headers | Response Header           | Format   | Description                                                       | | - -- -- -- -- -- -- -- -          | - -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- --                                     | | `Fiken-Api-Page`          | integer  | From the request header                                           | | `Fiken-Api-Page-Size`     | integer  | From the request header                                           | | `Fiken-Api-Page-Count`    | integer  | The total number of pages in this resource with this page size    | | `Fiken-Api-Result-Count`  | integer  | The total number of elements in this resource                     |  ### Sorting To change the sort order for a resource, set the sortBy query parameter to a sort field in either ascending or descending order. Ex: `https://api.fiken.no/api/v2/companies?sortBy=name%20asc`  ### Filtering Some collections support filtering, and depending on the type of field, different filters can be used. Dates are the most complex, and allow you do apply different filters with different parameter names. For instance, for a field called date, the following mutations are available:  | Parameter | Field | Format    | Description                                   | | - --       |- --    | - --       |- --                                            | |  `date`   |date |yyyy-MM-dd |date equal to parameter value                  | |  `dateLe` |date |yyyy-MM-dd |date less than or equal to parameter value     | |  `dateLt` |date |yyyy-MM-dd |date less than parameter value                 | |  `dateGe` |date |yyyy-MM-dd |date greater than or equal to parameter value  | |  `dateGt` |date |yyyy-MM-dd |date greater than parameter value              |  All date-fields will have these mutations of parameter name that applies  ## Data Types These are simple data-types that are used in several of our objects.  ### Date Dates are represented as strings formatted as yyyy-MM-dd. \"Last modified\" returns the date of last modification of the object.  If the object was never modified after creation, last modified date is equal to created date.   ##### Examples: January 2nd, 1970: \"1970-01-02\"  ### Amount Amounts are always represented as a number, and specifies the number of cents in the amount. Fractions will be ignored.  ##### Examples: One thousand: 100000  One hundred and twelve cents: 10012  ### Account An account is a string with either four digits, or four digits, a colon and five digits (\"reskontro\").  ##### Examples: 3020  1500:10001  ### VAT Code Fiken's VAT codes are based upon Sticos mvakoder. To see all VAT codes go to Fiken support, check the \"Mva kode\"-selector in the Fiken web interface while creating a genereal ledger item (\"Fri postering\").  See below the mapping between VAT codes and types (codes are used at the transaction level while types are used for sales and purchases).  | Vat Code | Vat Type                                                                                                                                 | Valid for Purchases/Sales    |  | - --      |- --                                                                                                                                       | - --                          |                                          |  0/7     |NONE (Ingen - KJØP_INGEN_MVABEHANDLING/SALG_INNTEKTER_UTEN_MVABEHANDLING)                                                               |Both                          | |  1/3    |HIGH (Høy - KJØP/SALG_MED_HØY_SATS)                                                                                                       |Both                          | |  11/31   |MEDIUM (Middels - KJØP/SALG_MED_MIDDELS_SATS)                                                                                           |Both                       | |  12/32   |RAW_FISH (Råfisk - KJØP/SALG_MED_RÅFISK_SATS)                                                                                           |Both                         | |  13/33   |LOW (Lav - KJØP/SALG_MED_LAV_SATS)                                                                                                       |Both                          | |  52    |EXEMPT_IMPORT_EXPORT (Fritatt import/export - SALG_UTFØRSEL_AV_VARER_OG_TJENESTER)                                                        |Sales                      | |  5    |EXEMPT (Fritatt - SALG_FRITATT_FOR_MVA_AVGIFTSFRITT)                                                                                   |Sales                        | |  6    |OUTSIDE (Utenfor - SALG_FRITATT_FOR_MVA_UTENFOR_AVGIFTSOMRÅDET)                                                                           |Sales                      | |  51    |EXEMPT_REVERSE (Fritatt omvendt - SALG_INNENLANDSK_OMSETNING_MED_OMVENDT_AVGIFTPLIKT)                                                   |Sales                      | |  14    |HIGH_DIRECT (Høy direkt - KUN_KJØPSMVA_HØY_SATS)                                                                                       |Purchases                  | |  21    |HIGH_BASIS (Høy grunnlag - KUN_GRUNNLAG_KJØPSMVA_HØY_SATS)                                                                               |Purchases                  | |  15    |MEDIUM_DIRECT (Middels direkte - KUN_KJØPSMVA_MIDDELS_SATS)                                                                               |Purchases                  | |  22    |MEDIUM_BASIS (Middels grunnlag - KUN_GRUNNLAG_KJØPSMVA_MIDDELS_SATS)                                                                   |Purchases                  | |  23    |NONE_IMPORT_BASIS (Ingen import grunnlag - KUN_GRUNNLAG_KJØPSMVA_INGEN_SATS)                                                           |Purchases                  | |  86    |HIGH_FOREIGN_SERVICE_DEDUCTIBLE (Tjeneste utlandet - TJENESTER_KJØPT_FRA_UTLANDET_MED_FRADRAG_FOR_HØY_MVA)                               |Purchases                  | |  87    |HIGH_FOREIGN_SERVICE_NONDEDUCTIBLE (Tjeneste utlandet uten fradrag - TJENESTER_KJØPT_FRA_UTLANDET_UTEN_FRADRAG_FOR_HØY_MVA)               |Purchases                  | |  88    |LOW_FOREIGN_SERVICE_DEDUCTIBLE (Lav tjeneste utlandet - TJENESTER_KJØPT_FRA_UTLANDET_MED_FRADRAG_FOR_LAV_MVA)                           |Purchases                  | |  89    |LOW_FOREIGN_SERVICE_NONDEDUCTIBLE (Lav tjeneste utlandet uten fradrag - TJENESTER_KJØPT_FRA_UTLANDET_UTEN_FRADRAG_FOR_LAV_MVA)           |Purchases                  | |  91    |HIGH_PURCHASE_OF_EMISSIONSTRADING_OR_GOLD_DEDUCTIBLE (Gull - KJØP_AV_KLIMAKVOTER_ELLER_GULL_MED_FRADRAG_FOR_MVA)                       |Purchases                  | |  92    |HIGH_PURCHASE_OF_EMISSIONSTRADING_OR_GOLD_NONDEDUCTIBLE (Gull uten fradrag - KJØP_AV_KLIMAKVOTER_ELLER_GULL_UTEN_FRADRAG_FOR_MVA)       |Purchases                  | 
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Fiken.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Fiken.Test")]

namespace Fiken.Client
{
    /// <summary>
    /// Utility functions providing some benefit to API client consumers.
    /// </summary>
    public static partial class ClientUtils
    {

        /// <summary>
        /// A delegate for events.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public delegate void EventHandler<T>(object sender, T e) where T : EventArgs;

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(string json, JsonSerializerOptions options, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T? result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(json, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(ref Utf8JsonReader reader, JsonSerializerOptions options, [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T? result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(ref reader, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <param name="format">The DateTime serialization format.</param>
        /// <returns>Formatted string.</returns>
        public static string? ParameterToString(object? obj, string? format = ISO8601_DATETIME_FORMAT)
        {
            if (obj is DateTime dateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTime.ToString(format);
            if (obj is DateTimeOffset dateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTimeOffset.ToString(format);
            if (obj is DateOnly dateOnly)
                return dateOnly.ToString(format);
            if (obj is bool boolean)
                return boolean
                    ? "true"
                    : "false";
            if (obj is Attachment.TypeEnum attachmentTypeEnum)
                return Attachment.TypeEnumToJsonValue(attachmentTypeEnum);
            if (obj is BankAccountRequest.TypeEnum bankAccountRequestTypeEnum)
                return BankAccountRequest.TypeEnumToJsonValue(bankAccountRequestTypeEnum);
            if (obj is BankAccountResult.TypeEnum bankAccountResultTypeEnum)
                return BankAccountResult.TypeEnumToJsonValue(bankAccountResultTypeEnum);
            if (obj is Company.VatTypeEnum companyVatTypeEnum)
                return Company.VatTypeEnumToJsonValue(companyVatTypeEnum);
            if (obj is DispatchResult.DispatchTypeEnum dispatchResultDispatchTypeEnum)
                return DispatchResult.DispatchTypeEnumToJsonValue(dispatchResultDispatchTypeEnum);
            if (obj is InvoiceishDraftRequest.TypeEnum invoiceishDraftRequestTypeEnum)
                return InvoiceishDraftRequest.TypeEnumToJsonValue(invoiceishDraftRequestTypeEnum);
            if (obj is InvoiceishDraftResult.TypeEnum invoiceishDraftResultTypeEnum)
                return InvoiceishDraftResult.TypeEnumToJsonValue(invoiceishDraftResultTypeEnum);
            if (obj is PurchaseRequest.KindEnum purchaseRequestKindEnum)
                return PurchaseRequest.KindEnumToJsonValue(purchaseRequestKindEnum);
            if (obj is PurchaseResult.KindEnum purchaseResultKindEnum)
                return PurchaseResult.KindEnumToJsonValue(purchaseResultKindEnum);
            if (obj is SaleRequest.KindEnum saleRequestKindEnum)
                return SaleRequest.KindEnumToJsonValue(saleRequestKindEnum);
            if (obj is SaleResult.KindEnum saleResultKindEnum)
                return SaleResult.KindEnumToJsonValue(saleResultKindEnum);
            if (obj is SendCreditNoteRequest.MethodEnum sendCreditNoteRequestMethodEnum)
                return SendCreditNoteRequest.MethodEnumToJsonValue(sendCreditNoteRequestMethodEnum);
            if (obj is SendCreditNoteRequest.EmailSendOptionEnum sendCreditNoteRequestEmailSendOptionEnum)
                return SendCreditNoteRequest.EmailSendOptionEnumToJsonValue(sendCreditNoteRequestEmailSendOptionEnum);
            if (obj is SendInvoiceRequest.MethodEnum sendInvoiceRequestMethodEnum)
                return SendInvoiceRequest.MethodEnumToJsonValue(sendInvoiceRequestMethodEnum);
            if (obj is SendInvoiceRequest.EmailSendOptionEnum sendInvoiceRequestEmailSendOptionEnum)
                return SendInvoiceRequest.EmailSendOptionEnumToJsonValue(sendInvoiceRequestEmailSendOptionEnum);
            if (obj is SendInvoiceishRequest.MethodEnum sendInvoiceishRequestMethodEnum)
                return SendInvoiceishRequest.MethodEnumToJsonValue(sendInvoiceishRequestMethodEnum);
            if (obj is SendInvoiceishRequest.EmailSendOptionEnum sendInvoiceishRequestEmailSendOptionEnum)
                return SendInvoiceishRequest.EmailSendOptionEnumToJsonValue(sendInvoiceishRequestEmailSendOptionEnum);
            if (obj is ICollection collection)
            {
                List<string?> entries = new();
                foreach (var entry in collection)
                    entries.Add(ParameterToString(entry));
                return string.Join(",", entries);
            }

            return Convert.ToString(obj, System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">string to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            StringBuilder sb = new StringBuilder(input.Length * 2);
            int index = 0;

            while (index < input.Length)
            {
                int length = Math.Min(input.Length - index, maxLength);
                string subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(global::System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Convert stream to byte array
        /// </summary>
        /// <param name="inputStream">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream inputStream)
        {
            using (var ms = new MemoryStream())
            {
                inputStream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public static string? SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType))
                    return contentType;
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public static string? SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Provides a case-insensitive check that a provided content type is a known JSON-like content type.
        /// </summary>
        [GeneratedRegex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$")]
        private static partial Regex JsonRegex();

        /// <summary>
        /// Check if the given MIME is a JSON MIME.
        /// JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public static bool IsJsonMime(string mime)
        {
            if (string.IsNullOrWhiteSpace(mime)) return false;

            return JsonRegex().IsMatch(mime) || mime.Equals("application/json-patch+json");
        }

        /// <summary>
        /// Get the discriminator
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="discriminator"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public static string? GetDiscriminator(Utf8JsonReader utf8JsonReader, string discriminator)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    if (localVarJsonPropertyName != null && localVarJsonPropertyName.Equals(discriminator))
                        return utf8JsonReader.GetString();
                }
            }

            throw new JsonException("The specified discriminator was not found.");
        }

        /// <summary>
        /// The base path of the API
        /// </summary>
        public const string BASE_ADDRESS = "https://api.fiken.no/api/v2";

        /// <summary>
        /// The scheme of the API
        /// </summary>
        public const string SCHEME = "https";

        /// <summary>
        /// The context path of the API
        /// </summary>
        public const string CONTEXT_PATH = "/api/v2";

        /// <summary>
        /// The host of the API
        /// </summary>
        public const string HOST = "api.fiken.no";

        /// <summary>
        /// The format to use for DateTime serialization
        /// </summary>
        public const string ISO8601_DATETIME_FORMAT = "o";
    }
}
