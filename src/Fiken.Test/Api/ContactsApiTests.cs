/*
 * Fiken API
 *
 *  ## Introduction [Fiken.no](https://fiken.no) is an online accounting system aimed at making accounting easy for small businesses. The API Module allows other systems to integrate with Fiken. This document describes Fiken's API.  ## Using the API Use of this API in production environments on live data is normally associated with a fee for the end user (company). API access costs 99kr per month and can be ordered through the Module access page under Settings in your Fiken account. If you have any questions regarding the API pricing, contact us at <api@fiken.no>.  The API provides two different ways of authorizing requests.    1. OAuth2   2. Personal API tokens  Third parties that wish to integrate with Fiken on behalf of their customers should use the OAuth2 authorization method. In order to develop OAuth2 applications that integrate with this API you must log into your Fiken account and check the box saying that you are a developer (**Rediger konto -> Profil -> Andre innstillinger**). This will allow you to create an App by clicking on the \"API\" tab under Brukerinnstillinger. If you don't have an existing Fiken account you can create a new user and demo company (demoforetak) at no charge. Send an email to <api@fiken.no> to get free access to Fiken for longer than the included 30 day free trial period.   Upon creation of the new App you will be provided a Client ID and Client Secret that are needed for the OAuth2 authorization flow.  This will allow you to use the API during development with up to 5 users. If you would like to use the API with more than 5 users and gain production status, you will need to send an email to <api@fiken.no> to gain full access to the API module.  Fiken customers that wish to integrate their own solutions with this API can use personal API tokens. Personal API tokens can be created in **Rediger konto -> API -> Personlige API-nøkler**. Note that personal API tokens do not expire.  ## Base URL All URLs start with https://api.fiken.no/api/v2. Note that TLS is required, unencrypted HTTP is not supported. Although we currently redirect HTTP requests to HTTPS, you are not allowed to this with your application as using HTTP is a security risk. In the future we might respond with 403 Forbidden instead.  ## Concurrent requests / rate limiting You are only allowed to make a single concurrent API-request. Sending multiple requests concurrently may result in a 429 error response. If you break this rule you might be banned. In case of a ban please contact us to be unbanned.  API calls may be slowed if you execute more than 4 requests per second.  ## Personal API tokens  Personal API tokens can be created in **Rediger konto -> API**. Personal API tokens never expire and can be revoked from the same place.  To use a personal API token simply send it as a bearer token in the `Authorization` header:      GET https://api.fiken.no/api/v2/companies     Authorization: Bearer <api token>  ## Authorization with OAuth2 Fiken API V2 uses OAuth 2.0 for authorizing API requests. Authorized requests to the API should use an `Authorization` header with the value `Bearer <TOKEN>` where `<TOKEN>` is an access token obtained through the OAuth flow.  ### Authorize Endpoint  To start the OAuth flow in order to obtain an access token for a user, you will first have to get consent from the user. To do this, direct your user to the authorization endpoint:      GET https://fiken.no/oauth/authorize?response_type=code&client_id=CLIENT_ID&redirect_uri=REDIRECT_URI&state=STATE  If the user is logged in and accepts your request, the user is redirected back to your redirect url. If the user is not logged in, the regular Fiken.no login form is presented first, requiring the user to authenticate before accepting or rejecting your request.  If the user rejects the request or if there is an error in your request, the user is redirected back to your redirect url with the parameters `error` and `error_description`. If the user rejected the request the error code will be `access_denied`.  #### Parameters  | Name          | Description                                                                                                      | | :- -- -- -- -- -- - | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | response_type | **Required** Should always be the value `code`                                                     | | client_id     | **Required** The client id you received from Fiken when you registered your application                          | | redirect_uri  | **Required** The URL in your application where users will be sent with an authorization code after authorization | | state         | **Required** An unguessable random string, used to protect against CSRF attacks                                  |   ### Token Endpoint  If the user accepts your request, Fiken redirects the user back to your `redirect_uri` with a parameter named `code` as well as the state you provided in the previous step in the `state` parameter. This temporary code will expire after a short while.  The temporary authorization code can be exchanged for an access token at the token endpoint.  The token endpoint is protected with Http Basic Authentication and you should use your application client id and client secret as credentials to authenticate.      POST https://fiken.no/oauth/token     Content-Type: application/x-www-form-urlencoded     Authorization: Basic dXNlIHlvdXIgY2xpZW50IGlkOmFuZCBjbGllbnQgc2VjcmV0      grant_type=authorization_code&code=AUTHCODE&redirect_uri=REDIRECT_URI&state=STATE  The response will contain the access token, a refresh token (see below) as well as information about the expiry time for the token.      {       \"access_token\": \"K2QwoFp4ZfugWLWk7Ipu9kni5cyv3luXKQ-GDShvV2g=\",       \"refresh_token\": \"naFOD_j8m6PFGcP0pfImVZlSxKklHLbgj9Hzao4rhg8=\",       \"token_type\": \"bearer\",       \"expires_in\": 86157     }  If an error occurs during the token exchange request, an error object is returned with an error and an error description.      {         \"error\": \"invalid_grant\",         \"error_description\": \"The authorization code is invalid or expired.\"     }  #### Parameters  | Name         | Description                                                                                                      | | :- -- -- -- -- -- | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | grant_type   | **Required** Should be the value `authorization_code`                                                            | | code         | **Required** The authorization code that was received in the redirect from the authorize endpoint                | | redirect_uri | **Required** The URL in your application where users will be sent with an authorization code after authorization | | state        | **Required** An unguessable random string, used to protect against CSRF attacks                                  |  ### Refresh Tokens  If an access token has expired you can use the refresh token that was sent in the response from the token endpoint to get a new access token.  Note that if the user has revoked the consent to your app, the refresh token will no longer be valid.  To get a new access token from the refresh token, use the token endpoint with the grant type `refresh_token`:      POST https://fiken.no/oauth/token     Content-Type: application/x-www-form-urlencoded     Authorization: Basic dXNlIHlvdXIgY2xpZW50IGlkOmFuZCBjbGllbnQgc2VjcmV0      grant_type=refresh_token&refresh_token=REFRESH_TOKEN  The response contains a fresh access token along with a possibly updated refresh token:      {       \"access_token\": \"K2QwoFp4ZfugWLWk7Ipu9kni5cyv3luXKQ-GDShvV2g=\",       \"refresh_token\": \"naFOD_j8m6PFGcP0pfImVZlSxKklHLbgj9Hzao4rhg8=\",       \"token_type\": \"bearer\",       \"expires_in\": 86157     }  #### Parameters  | Name         | Description                                                                                                      | | :- -- -- -- -- -- | :- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | grant_type   | **Required** Should be the value `refresh_token`                                                                 | | refresh_token| **Required** The refresh token last returned for this user from the token endpoint                               |  ### Using Access Tokens in API Requests  To execute API requests on behalf of the end user, send the access token obtained at the token endpoint as a bearer token, as in this example:      GET https://api.fiken.no/api/v2/companies     Authorization: Bearer <access_token_value>  ### Revoking tokens  To revoke an access token and refresh token use the Revoke Token endpoint.  The Revoke Token endpoint disables the application grant, the access token and the corresponding refresh token used to authenticate the call. Other access tokens obtained from the same refresh token are also revoked.      POST https://fiken.no/oauth/revoke     Authorization: Bearer <access_token_value>  The response for a successful revocation is 200/OK.  ### Managing access  The end user can manage which companies a given app has access to under **Rediger konto -> Sikkerhet -> Apper du har gitt tilgang til**.  All companies created after the initial consent has been given need to be actively added so that the app will have access to their information.  Additionally the end user can revoke access to any of their companies' data as well.   ## Try It Out  For each endpoint in the documentation below there is a button *Try It Out*. To invoke the API from this documentation you need an app and you need to authorize usage for you Fiken.no user.  Your app needs to be configured with a redirect URL for this documentation, add `https://api.fiken.no/api/v2/docs/oauth2-redirect.html` to the list of redirect URLs for your app.  Click the padlock symbol on any of the endpoints and enter your `client_id` and `client_secret` and then press *Authorize* to start the OAuth2 authorization flow, then click *Close*.  Enter the required parameters for the endpoint, such as `company_slug`, and then press *Execute* to test.  ## Request  We recommend sending the `X-Request-ID` header with all requests.  ### Request Headers | Request  Header           | Format   | Description                                                       | | - -- -- -- -- -- -- -- -          | - -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- --                                     | | `X-Request-ID`            | UUID     | UUID used to identify the request                                 |    ## Response ### Response code All HTTP codes should be expected with their normal semantics. These are some of the common ones:  * **200** for successful GET * **201** for successful POST where you get a Location-header for the created content * **400** when invalid content has be sent (for instance a required field is missing, unexpected fields, wrong format, etc) * **401** when the user is not authenticated * **403** when the user does not have the proper authorization * **404** when the requested content is not found * **405** When you are trying a method to a resource which doesn't support it (i.e. DELETE on an account). * **415** Wrong media type. we accept application/json only.  ### Response Content The default content type on the result of GET requests is application/json. On successful POSTs/PUTs/PATCHs and DELETEs an empty body is returned.  For successful POSTs/PUTs/PATCHs a Location header is given in all cases.  ## Pagination, Sorting & Filtering Pagination, sorting and filtering query parameters are all optional.   | URI                                                                     | Pagination? | Sortable? | Sortable Fields                       | Filterable? | Filtered Fields                                                                                                                         | | :- -- -- -- --                                                              |:- -- -- -- -- -- | :- -- -- -- - | :- -- -- -- -- -- --                        | :- --        | :- --                                                                                                                                    | | https://api.fiken.no/api/v2/companies                                  | Yes         | Yes       | createdDate, name, organizationNumber | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/accounts           | No          | No        |                                       | Yes         | fromAccount, toAccount                                                                                                                  | | https://api.fiken.no/api/v2/companies/{companySlug}/accountBalances    | Yes         | No        |                                       | Yes         | fromAccount, toAccount                                                                                                                  | | https://api.fiken.no/api/v2/companies/{companySlug}/bankAccounts       | Yes         | No        |                                       | Yes         | inactive                                                                                                                                | | https://api.fiken.no/api/v2/companies/{companySlug}/contacts           | Yes         | Yes       | createdDate, lastModified             | Yes         | supplierNumber, customerNumber, memberNumber, memberNumberString, name, organizationNumber, email, group, lastModified, createdDate, inactive, phoneNumber  | | https://api.fiken.no/api/v2/companies/{companySlug}/creditNotes        | Yes         | No        |                                       | Yes         | issueDate, lastModified, settled, customerId                                                                                            | | https://api.fiken.no/api/v2/companies/{companySlug}/inbox              | Yes         | Yes       | createdDate, name                     | Yes         | status, name                                                                                                                            | | https://api.fiken.no/api/v2/companies/{companySlug}/invoices           | Yes         | No        |                                       | Yes         | issueDate, lastModified, dueDate, settled, customerId, orderReference, invoiceDraftUuid                                                 | | https://api.fiken.no/api/v2/companies/{companySlug}/invoices/drafts    | Yes         | No        |                                       | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/journalEntries     | Yes         | No        |                                       | Yes         | date                                                                                                                                    | | https://api.fiken.no/api/v2/companies/{companySlug}/offers             | Yes         | No        |                                       | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/orderConfirmations | Yes         | No        |                                       | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/products           | Yes         | No        |                                       | Yes         | name, productNumber, active, createdDate, lastModified                                                                                  | | https://api.fiken.no/api/v2/companies/{companySlug}/projects           | Yes         | No        |                                       | Yes         | completed                                                                                                                               | | https://api.fiken.no/api/v2/companies/{companySlug}/purchases          | Yes         | Yes       | createdDate                           | No          | date                                                                                                                                    | | https://api.fiken.no/api/v2/companies/{companySlug}/purchases/drafts   | Yes         | No        |                                       | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/sales              | Yes         | No        |                                       | Yes         | saleNumber, lastModified, date, contactId                                                                                               | | https://api.fiken.no/api/v2/companies/{companySlug}/sales/drafts       | Yes         | No        |                                       | No          |                                                                                                                                         | | https://api.fiken.no/api/v2/companies/{companySlug}/transactions       | Yes         | No        |                                       | Yes         | createdDate, lastModified                                                                                                               |  ### Pagination By default the API sets `page=0` and `pageSize=25` and returns the first 25 elements in a collection resource, if nothing else is specified. PageSize has a maximum value of 100 meaning that you can only access at most 100 elements at once.  To request a collection resource with pagination, query the resource with the query filters page and pageSize, note that both query parameters need to be set to enable pagination. The page counter starts at 0. The response will contain up to Fiken-Api-Page-Size elements and the response headers below, detailing how many elements the resource has in total and the total number of pages as well.  By default the API returns the resources in the order they were created, if nothing else is specified in the documentation.  #### Pagination Response Headers | Response Header           | Format   | Description                                                       | | - -- -- -- -- -- -- -- -          | - -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- --                                     | | `Fiken-Api-Page`          | integer  | From the request header                                           | | `Fiken-Api-Page-Size`     | integer  | From the request header                                           | | `Fiken-Api-Page-Count`    | integer  | The total number of pages in this resource with this page size    | | `Fiken-Api-Result-Count`  | integer  | The total number of elements in this resource                     |  ### Sorting To change the sort order for a resource, set the sortBy query parameter to a sort field in either ascending or descending order. Ex: `https://api.fiken.no/api/v2/companies?sortBy=name%20asc`  ### Filtering Some collections support filtering, and depending on the type of field, different filters can be used. Dates are the most complex, and allow you do apply different filters with different parameter names. For instance, for a field called date, the following mutations are available:  | Parameter | Field | Format    | Description                                   | | - --       |- --    | - --       |- --                                            | |  `date`   |date |yyyy-MM-dd |date equal to parameter value                  | |  `dateLe` |date |yyyy-MM-dd |date less than or equal to parameter value     | |  `dateLt` |date |yyyy-MM-dd |date less than parameter value                 | |  `dateGe` |date |yyyy-MM-dd |date greater than or equal to parameter value  | |  `dateGt` |date |yyyy-MM-dd |date greater than parameter value              |  All date-fields will have these mutations of parameter name that applies  ## Data Types These are simple data-types that are used in several of our objects.  ### Date Dates are represented as strings formatted as yyyy-MM-dd. \"Last modified\" returns the date of last modification of the object.  If the object was never modified after creation, last modified date is equal to created date.   ##### Examples: January 2nd, 1970: \"1970-01-02\"  ### Amount Amounts are always represented as a number, and specifies the number of cents in the amount. Fractions will be ignored.  ##### Examples: One thousand: 100000  One hundred and twelve cents: 10012  ### Account An account is a string with either four digits, or four digits, a colon and five digits (\"reskontro\").  ##### Examples: 3020  1500:10001  ### VAT Code Fiken's VAT codes are based upon Sticos mvakoder. To see all VAT codes go to Fiken support, check the \"Mva kode\"-selector in the Fiken web interface while creating a genereal ledger item (\"Fri postering\").  See below the mapping between VAT codes and types (codes are used at the transaction level while types are used for sales and purchases).  | Vat Code | Vat Type                                                                                                                                 | Valid for Purchases/Sales    |  | - --      |- --                                                                                                                                       | - --                          |                                          |  0/7     |NONE (Ingen - KJØP_INGEN_MVABEHANDLING/SALG_INNTEKTER_UTEN_MVABEHANDLING)                                                               |Both                          | |  1/3    |HIGH (Høy - KJØP/SALG_MED_HØY_SATS)                                                                                                       |Both                          | |  11/31   |MEDIUM (Middels - KJØP/SALG_MED_MIDDELS_SATS)                                                                                           |Both                       | |  12/32   |RAW_FISH (Råfisk - KJØP/SALG_MED_RÅFISK_SATS)                                                                                           |Both                         | |  13/33   |LOW (Lav - KJØP/SALG_MED_LAV_SATS)                                                                                                       |Both                          | |  52    |EXEMPT_IMPORT_EXPORT (Fritatt import/export - SALG_UTFØRSEL_AV_VARER_OG_TJENESTER)                                                        |Sales                      | |  5    |EXEMPT (Fritatt - SALG_FRITATT_FOR_MVA_AVGIFTSFRITT)                                                                                   |Sales                        | |  6    |OUTSIDE (Utenfor - SALG_FRITATT_FOR_MVA_UTENFOR_AVGIFTSOMRÅDET)                                                                           |Sales                      | |  51    |EXEMPT_REVERSE (Fritatt omvendt - SALG_INNENLANDSK_OMSETNING_MED_OMVENDT_AVGIFTPLIKT)                                                   |Sales                      | |  14    |HIGH_DIRECT (Høy direkt - KUN_KJØPSMVA_HØY_SATS)                                                                                       |Purchases                  | |  21    |HIGH_BASIS (Høy grunnlag - KUN_GRUNNLAG_KJØPSMVA_HØY_SATS)                                                                               |Purchases                  | |  15    |MEDIUM_DIRECT (Middels direkte - KUN_KJØPSMVA_MIDDELS_SATS)                                                                               |Purchases                  | |  22    |MEDIUM_BASIS (Middels grunnlag - KUN_GRUNNLAG_KJØPSMVA_MIDDELS_SATS)                                                                   |Purchases                  | |  23    |NONE_IMPORT_BASIS (Ingen import grunnlag - KUN_GRUNNLAG_KJØPSMVA_INGEN_SATS)                                                           |Purchases                  | |  86    |HIGH_FOREIGN_SERVICE_DEDUCTIBLE (Tjeneste utlandet - TJENESTER_KJØPT_FRA_UTLANDET_MED_FRADRAG_FOR_HØY_MVA)                               |Purchases                  | |  87    |HIGH_FOREIGN_SERVICE_NONDEDUCTIBLE (Tjeneste utlandet uten fradrag - TJENESTER_KJØPT_FRA_UTLANDET_UTEN_FRADRAG_FOR_HØY_MVA)               |Purchases                  | |  88    |LOW_FOREIGN_SERVICE_DEDUCTIBLE (Lav tjeneste utlandet - TJENESTER_KJØPT_FRA_UTLANDET_MED_FRADRAG_FOR_LAV_MVA)                           |Purchases                  | |  89    |LOW_FOREIGN_SERVICE_NONDEDUCTIBLE (Lav tjeneste utlandet uten fradrag - TJENESTER_KJØPT_FRA_UTLANDET_UTEN_FRADRAG_FOR_LAV_MVA)           |Purchases                  | |  91    |HIGH_PURCHASE_OF_EMISSIONSTRADING_OR_GOLD_DEDUCTIBLE (Gull - KJØP_AV_KLIMAKVOTER_ELLER_GULL_MED_FRADRAG_FOR_MVA)                       |Purchases                  | |  92    |HIGH_PURCHASE_OF_EMISSIONSTRADING_OR_GOLD_NONDEDUCTIBLE (Gull uten fradrag - KJØP_AV_KLIMAKVOTER_ELLER_GULL_UTEN_FRADRAG_FOR_MVA)       |Purchases                  | 
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Fiken.Api;
using Fiken.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace Fiken.Test.Api
{
    /// <summary>
    ///  Class for testing ContactsApi
    /// </summary>
    public sealed class ContactsApiTests : ApiTestsBase
    {
        private readonly IContactsApi _instance;

        public ContactsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IContactsApi>();
        }

        /// <summary>
        /// Test AddAttachmentToContact
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddAttachmentToContactAsyncTest()
        {
            string companySlug = default!;
            long contactId = default!;
            Client.Option<string> filename = default!;
            Client.Option<string> comment = default!;
            Client.Option<System.IO.Stream> file = default!;
            await _instance.AddAttachmentToContactAsync(companySlug, contactId, filename, comment, file);
        }

        /// <summary>
        /// Test AddContactPersonToContact
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddContactPersonToContactAsyncTest()
        {
            string companySlug = default!;
            long contactId = default!;
            ContactPerson contactPerson = default!;
            await _instance.AddContactPersonToContactAsync(companySlug, contactId, contactPerson);
        }

        /// <summary>
        /// Test CreateContact
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CreateContactAsyncTest()
        {
            string companySlug = default!;
            Contact contact = default!;
            await _instance.CreateContactAsync(companySlug, contact);
        }

        // /// <summary>
        // /// Test DeleteContact
        // /// </summary>
        // [Fact (Skip = "not implemented")]
        // public async Task DeleteContactAsyncTest()
        // {
        //     string companySlug = default!;
        //     long contactId = default!;
        //     var response = await _instance.DeleteContactAsync(companySlug, contactId);
        //     var model = response.NoContent();
        //     Assert.IsType<Contact>(model);
        // }

        /// <summary>
        /// Test DeleteContactContactPerson
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task DeleteContactContactPersonAsyncTest()
        {
            string companySlug = default!;
            long contactId = default!;
            long contactPersonId = default!;
            await _instance.DeleteContactContactPersonAsync(companySlug, contactId, contactPersonId);
        }

        /// <summary>
        /// Test GetContact
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetContactAsyncTest()
        {
            string companySlug = default!;
            long contactId = default!;
            var response = await _instance.GetContactAsync(companySlug, contactId);
            var model = response.Ok();
            Assert.IsType<Contact>(model);
        }

        /// <summary>
        /// Test GetContactContactPerson
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetContactContactPersonAsyncTest()
        {
            string companySlug = default!;
            long contactId = default!;
            var response = await _instance.GetContactContactPersonAsync(companySlug, contactId);
            var model = response.Ok();
            Assert.IsType<List<ContactPerson>>(model);
        }

        /// <summary>
        /// Test GetContactPerson
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetContactPersonAsyncTest()
        {
            string companySlug = default!;
            long contactId = default!;
            long contactPersonId = default!;
            var response = await _instance.GetContactPersonAsync(companySlug, contactId, contactPersonId);
            var model = response.Ok();
            Assert.IsType<ContactPerson>(model);
        }

        /// <summary>
        /// Test GetContacts
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetContactsAsyncTest()
        {
            string companySlug = default!;
            Client.Option<int> page = default!;
            Client.Option<int> pageSize = default!;
            Client.Option<DateOnly> lastModified = default!;
            Client.Option<DateOnly> lastModifiedLe = default!;
            Client.Option<DateOnly> lastModifiedLt = default!;
            Client.Option<DateOnly> lastModifiedGe = default!;
            Client.Option<DateOnly> lastModifiedGt = default!;
            Client.Option<DateOnly> createdDate = default!;
            Client.Option<DateOnly> createdDateLe = default!;
            Client.Option<DateOnly> createdDateLt = default!;
            Client.Option<DateOnly> createdDateGe = default!;
            Client.Option<DateOnly> createdDateGt = default!;
            Client.Option<int> supplierNumber = default!;
            Client.Option<int> customerNumber = default!;
            Client.Option<int> memberNumber = default!;
            Client.Option<string> memberNumberString = default!;
            Client.Option<string> name = default!;
            Client.Option<string> organizationNumber = default!;
            Client.Option<string> email = default!;
            Client.Option<bool> customer = default!;
            Client.Option<bool> supplier = default!;
            Client.Option<bool> inactive = default!;
            Client.Option<string> group = default!;
            Client.Option<string> sortBy = default!;
            Client.Option<string> phoneNumber = default!;
            var response = await _instance.GetContactsAsync(companySlug, page, pageSize, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, createdDate, createdDateLe, createdDateLt, createdDateGe, createdDateGt, supplierNumber, customerNumber, memberNumber, memberNumberString, name, organizationNumber, email, customer, supplier, inactive, group, sortBy, phoneNumber);
            var model = response.Ok();
            Assert.IsType<List<Contact>>(model);
        }

        /// <summary>
        /// Test UpdateContact
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateContactAsyncTest()
        {
            string companySlug = default!;
            long contactId = default!;
            Contact contact = default!;
            await _instance.UpdateContactAsync(companySlug, contactId, contact);
        }

        /// <summary>
        /// Test UpdateContactContactPerson
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateContactContactPersonAsyncTest()
        {
            string companySlug = default!;
            long contactId = default!;
            long contactPersonId = default!;
            ContactPerson contactPerson = default!;
            await _instance.UpdateContactContactPersonAsync(companySlug, contactId, contactPersonId, contactPerson);
        }
    }
}
