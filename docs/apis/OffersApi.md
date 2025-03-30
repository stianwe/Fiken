# Fiken.Api.OffersApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAttachmentToOfferDraft**](OffersApi.md#addattachmenttoofferdraft) | **POST** /companies/{companySlug}/offers/drafts/{draftId}/attachments |  |
| [**CreateOfferCounter**](OffersApi.md#createoffercounter) | **POST** /companies/{companySlug}/offers/counter |  |
| [**CreateOfferDraft**](OffersApi.md#createofferdraft) | **POST** /companies/{companySlug}/offers/drafts |  |
| [**CreateOfferFromDraft**](OffersApi.md#createofferfromdraft) | **POST** /companies/{companySlug}/offers/drafts/{draftId}/createOffer |  |
| [**DeleteOfferDraft**](OffersApi.md#deleteofferdraft) | **DELETE** /companies/{companySlug}/offers/drafts/{draftId} |  |
| [**GetOffer**](OffersApi.md#getoffer) | **GET** /companies/{companySlug}/offers/{offerId} |  |
| [**GetOfferCounter**](OffersApi.md#getoffercounter) | **GET** /companies/{companySlug}/offers/counter |  |
| [**GetOfferDraft**](OffersApi.md#getofferdraft) | **GET** /companies/{companySlug}/offers/drafts/{draftId} |  |
| [**GetOfferDraftAttachments**](OffersApi.md#getofferdraftattachments) | **GET** /companies/{companySlug}/offers/drafts/{draftId}/attachments |  |
| [**GetOfferDrafts**](OffersApi.md#getofferdrafts) | **GET** /companies/{companySlug}/offers/drafts |  |
| [**GetOffers**](OffersApi.md#getoffers) | **GET** /companies/{companySlug}/offers |  |
| [**UpdateOfferDraft**](OffersApi.md#updateofferdraft) | **PUT** /companies/{companySlug}/offers/drafts/{draftId} |  |

<a id="addattachmenttoofferdraft"></a>
# **AddAttachmentToOfferDraft**
> void AddAttachmentToOfferDraft (string companySlug, long draftId, string filename = null, string comment = null, System.IO.Stream file = null)



Creates and adds a new attachment to an offer draft

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class AddAttachmentToOfferDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 
            var filename = "filename_example";  // string | Required. The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf (optional) 
            var comment = "comment_example";  // string | Not required. (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                apiInstance.AddAttachmentToOfferDraft(companySlug, draftId, filename, comment, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.AddAttachmentToOfferDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAttachmentToOfferDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddAttachmentToOfferDraftWithHttpInfo(companySlug, draftId, filename, comment, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.AddAttachmentToOfferDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **draftId** | **long** | The draftId (primary key of the returned object) is returned in the GET all drafts call.  |  |
| **filename** | **string** | Required. The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf | [optional]  |
| **comment** | **string** | Not required. | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  * Location - Full URL of updated project <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createoffercounter"></a>
# **CreateOfferCounter**
> void CreateOfferCounter (string companySlug, Counter counter = null)



Creates the first offer number which is then increased by one with every new offer. By sending an empty request body the default is base number (the first offer number will thus be 10001), but can be specified to another starting value.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateOfferCounterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var counter = new Counter(); // Counter |  (optional) 

            try
            {
                apiInstance.CreateOfferCounter(companySlug, counter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.CreateOfferCounter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOfferCounterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateOfferCounterWithHttpInfo(companySlug, counter);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.CreateOfferCounterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **counter** | [**Counter**](Counter.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createofferdraft"></a>
# **CreateOfferDraft**
> void CreateOfferDraft (string companySlug, InvoiceishDraftRequest invoiceishDraftRequest)



Creates an offer draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateOfferDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var invoiceishDraftRequest = new InvoiceishDraftRequest(); // InvoiceishDraftRequest | 

            try
            {
                apiInstance.CreateOfferDraft(companySlug, invoiceishDraftRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.CreateOfferDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOfferDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateOfferDraftWithHttpInfo(companySlug, invoiceishDraftRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.CreateOfferDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **invoiceishDraftRequest** | [**InvoiceishDraftRequest**](InvoiceishDraftRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  * Location - Full URL of updated project <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createofferfromdraft"></a>
# **CreateOfferFromDraft**
> void CreateOfferFromDraft (string companySlug, long draftId)



Creates an offer from an already created draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateOfferFromDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                apiInstance.CreateOfferFromDraft(companySlug, draftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.CreateOfferFromDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOfferFromDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateOfferFromDraftWithHttpInfo(companySlug, draftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.CreateOfferFromDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **draftId** | **long** | The draftId (primary key of the returned object) is returned in the GET all drafts call.  |  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  * Location - Full URL of updated project <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteofferdraft"></a>
# **DeleteOfferDraft**
> void DeleteOfferDraft (string companySlug, long draftId)



Delete offer draft with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class DeleteOfferDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                apiInstance.DeleteOfferDraft(companySlug, draftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.DeleteOfferDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOfferDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteOfferDraftWithHttpInfo(companySlug, draftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.DeleteOfferDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **draftId** | **long** | The draftId (primary key of the returned object) is returned in the GET all drafts call.  |  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Deleted |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getoffer"></a>
# **GetOffer**
> Offer GetOffer (string companySlug, string offerId)



Returns offer with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOfferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var offerId = "offerId_example";  // string | The offerId (primary key of the returned object) is returned as the first field in the GET all offers call 

            try
            {
                Offer result = apiInstance.GetOffer(companySlug, offerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.GetOffer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOfferWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Offer> response = apiInstance.GetOfferWithHttpInfo(companySlug, offerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.GetOfferWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **offerId** | **string** | The offerId (primary key of the returned object) is returned as the first field in the GET all offers call  |  |

### Return type

[**Offer**](Offer.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getoffercounter"></a>
# **GetOfferCounter**
> Counter GetOfferCounter (string companySlug)



Retrieves the counter for offers if it has been created 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOfferCounterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve

            try
            {
                Counter result = apiInstance.GetOfferCounter(companySlug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.GetOfferCounter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOfferCounterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Counter> response = apiInstance.GetOfferCounterWithHttpInfo(companySlug);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.GetOfferCounterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |

### Return type

[**Counter**](Counter.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getofferdraft"></a>
# **GetOfferDraft**
> InvoiceishDraftResult GetOfferDraft (string companySlug, long draftId)



Returns offer draft with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOfferDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                InvoiceishDraftResult result = apiInstance.GetOfferDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.GetOfferDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOfferDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InvoiceishDraftResult> response = apiInstance.GetOfferDraftWithHttpInfo(companySlug, draftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.GetOfferDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **draftId** | **long** | The draftId (primary key of the returned object) is returned in the GET all drafts call.  |  |

### Return type

[**InvoiceishDraftResult**](InvoiceishDraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getofferdraftattachments"></a>
# **GetOfferDraftAttachments**
> List&lt;Attachment&gt; GetOfferDraftAttachments (string companySlug, long draftId)



Returns all attachments for specified draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOfferDraftAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                List<Attachment> result = apiInstance.GetOfferDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.GetOfferDraftAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOfferDraftAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Attachment>> response = apiInstance.GetOfferDraftAttachmentsWithHttpInfo(companySlug, draftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.GetOfferDraftAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **draftId** | **long** | The draftId (primary key of the returned object) is returned in the GET all drafts call.  |  |

### Return type

[**List&lt;Attachment&gt;**](Attachment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getofferdrafts"></a>
# **GetOfferDrafts**
> List&lt;InvoiceishDraftResult&gt; GetOfferDrafts (string companySlug, int page = null, int pageSize = null)



Returns all offer drafts for given company.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOfferDraftsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List<InvoiceishDraftResult> result = apiInstance.GetOfferDrafts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.GetOfferDrafts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOfferDraftsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<InvoiceishDraftResult>> response = apiInstance.GetOfferDraftsWithHttpInfo(companySlug, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.GetOfferDraftsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **page** | **int** | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  | [optional] [default to 0] |
| **pageSize** | **int** | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  | [optional] [default to 25] |

### Return type

[**List&lt;InvoiceishDraftResult&gt;**](InvoiceishDraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * Fiken-Api-Page - From the request header <br>  * Fiken-Api-Page-Size - From the request header <br>  * Fiken-Api-Page-Count - The total number of pages in this resource with this page size <br>  * Fiken-Api-Result-Count - The total number of elements in this resource <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getoffers"></a>
# **GetOffers**
> List&lt;Offer&gt; GetOffers (string companySlug, int page = null, int pageSize = null)



Returns all offers for given company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOffersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List<Offer> result = apiInstance.GetOffers(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.GetOffers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOffersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Offer>> response = apiInstance.GetOffersWithHttpInfo(companySlug, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.GetOffersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **page** | **int** | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  | [optional] [default to 0] |
| **pageSize** | **int** | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  | [optional] [default to 25] |

### Return type

[**List&lt;Offer&gt;**](Offer.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * Fiken-Api-Page - From the request header <br>  * Fiken-Api-Page-Size - From the request header <br>  * Fiken-Api-Page-Count - The total number of pages in this resource with this page size <br>  * Fiken-Api-Result-Count - The total number of elements in this resource <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateofferdraft"></a>
# **UpdateOfferDraft**
> void UpdateOfferDraft (string companySlug, long draftId, InvoiceishDraftRequest invoiceishDraftRequest)



Updates offer draft with provided id. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class UpdateOfferDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 
            var invoiceishDraftRequest = new InvoiceishDraftRequest(); // InvoiceishDraftRequest | 

            try
            {
                apiInstance.UpdateOfferDraft(companySlug, draftId, invoiceishDraftRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.UpdateOfferDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOfferDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateOfferDraftWithHttpInfo(companySlug, draftId, invoiceishDraftRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OffersApi.UpdateOfferDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **draftId** | **long** | The draftId (primary key of the returned object) is returned in the GET all drafts call.  |  |
| **invoiceishDraftRequest** | [**InvoiceishDraftRequest**](InvoiceishDraftRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  * Location - Full URL of updated project <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

