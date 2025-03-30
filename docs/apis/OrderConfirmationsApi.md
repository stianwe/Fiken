# Fiken.Api.OrderConfirmationsApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAttachmentToOrderConfirmationDraft**](OrderConfirmationsApi.md#addattachmenttoorderconfirmationdraft) | **POST** /companies/{companySlug}/orderConfirmations/drafts/{draftId}/attachments |  |
| [**CreateInvoiceDraftFromOrderConfirmation**](OrderConfirmationsApi.md#createinvoicedraftfromorderconfirmation) | **POST** /companies/{companySlug}/orderConfirmations/{confirmationId}/createInvoiceDraft |  |
| [**CreateOrderConfirmationCounter**](OrderConfirmationsApi.md#createorderconfirmationcounter) | **POST** /companies/{companySlug}/orderConfirmations/counter |  |
| [**CreateOrderConfirmationDraft**](OrderConfirmationsApi.md#createorderconfirmationdraft) | **POST** /companies/{companySlug}/orderConfirmations/drafts |  |
| [**CreateOrderConfirmationFromDraft**](OrderConfirmationsApi.md#createorderconfirmationfromdraft) | **POST** /companies/{companySlug}/orderConfirmations/drafts/{draftId}/createOrderConfirmation |  |
| [**DeleteOrderConfirmationDraft**](OrderConfirmationsApi.md#deleteorderconfirmationdraft) | **DELETE** /companies/{companySlug}/orderConfirmations/drafts/{draftId} |  |
| [**GetOrderConfirmation**](OrderConfirmationsApi.md#getorderconfirmation) | **GET** /companies/{companySlug}/orderConfirmations/{confirmationId} |  |
| [**GetOrderConfirmationCounter**](OrderConfirmationsApi.md#getorderconfirmationcounter) | **GET** /companies/{companySlug}/orderConfirmations/counter |  |
| [**GetOrderConfirmationDraft**](OrderConfirmationsApi.md#getorderconfirmationdraft) | **GET** /companies/{companySlug}/orderConfirmations/drafts/{draftId} |  |
| [**GetOrderConfirmationDraftAttachments**](OrderConfirmationsApi.md#getorderconfirmationdraftattachments) | **GET** /companies/{companySlug}/orderConfirmations/drafts/{draftId}/attachments |  |
| [**GetOrderConfirmationDrafts**](OrderConfirmationsApi.md#getorderconfirmationdrafts) | **GET** /companies/{companySlug}/orderConfirmations/drafts |  |
| [**GetOrderConfirmations**](OrderConfirmationsApi.md#getorderconfirmations) | **GET** /companies/{companySlug}/orderConfirmations |  |
| [**UpdateOrderConfirmationDraft**](OrderConfirmationsApi.md#updateorderconfirmationdraft) | **PUT** /companies/{companySlug}/orderConfirmations/drafts/{draftId} |  |

<a id="addattachmenttoorderconfirmationdraft"></a>
# **AddAttachmentToOrderConfirmationDraft**
> void AddAttachmentToOrderConfirmationDraft (string companySlug, long draftId, string filename = null, string comment = null, System.IO.Stream file = null)



Creates and adds a new attachment to an order confirmation draft

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class AddAttachmentToOrderConfirmationDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 
            var filename = "filename_example";  // string | Required. The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf (optional) 
            var comment = "comment_example";  // string | Not required. (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                apiInstance.AddAttachmentToOrderConfirmationDraft(companySlug, draftId, filename, comment, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.AddAttachmentToOrderConfirmationDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAttachmentToOrderConfirmationDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddAttachmentToOrderConfirmationDraftWithHttpInfo(companySlug, draftId, filename, comment, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.AddAttachmentToOrderConfirmationDraftWithHttpInfo: " + e.Message);
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

<a id="createinvoicedraftfromorderconfirmation"></a>
# **CreateInvoiceDraftFromOrderConfirmation**
> void CreateInvoiceDraftFromOrderConfirmation (string companySlug, string confirmationId)



Creates an invoice draft from an order confirmation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateInvoiceDraftFromOrderConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var confirmationId = "confirmationId_example";  // string | The confirmationId (primary key of the returned object) is returned as the first field in the GET all order confirmations call 

            try
            {
                apiInstance.CreateInvoiceDraftFromOrderConfirmation(companySlug, confirmationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.CreateInvoiceDraftFromOrderConfirmation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInvoiceDraftFromOrderConfirmationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateInvoiceDraftFromOrderConfirmationWithHttpInfo(companySlug, confirmationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.CreateInvoiceDraftFromOrderConfirmationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **confirmationId** | **string** | The confirmationId (primary key of the returned object) is returned as the first field in the GET all order confirmations call  |  |

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

<a id="createorderconfirmationcounter"></a>
# **CreateOrderConfirmationCounter**
> void CreateOrderConfirmationCounter (string companySlug, Counter counter = null)



Creates the first order confirmation number which is then increased by one with every new order confirmation. By sending an empty request body the default is base number (the first order confirmation number will thus be 10001), but can be specified to another starting value.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateOrderConfirmationCounterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var counter = new Counter(); // Counter |  (optional) 

            try
            {
                apiInstance.CreateOrderConfirmationCounter(companySlug, counter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.CreateOrderConfirmationCounter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderConfirmationCounterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateOrderConfirmationCounterWithHttpInfo(companySlug, counter);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.CreateOrderConfirmationCounterWithHttpInfo: " + e.Message);
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

<a id="createorderconfirmationdraft"></a>
# **CreateOrderConfirmationDraft**
> void CreateOrderConfirmationDraft (string companySlug, InvoiceishDraftRequest invoiceishDraftRequest)



Creates an order confirmation draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateOrderConfirmationDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var invoiceishDraftRequest = new InvoiceishDraftRequest(); // InvoiceishDraftRequest | 

            try
            {
                apiInstance.CreateOrderConfirmationDraft(companySlug, invoiceishDraftRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.CreateOrderConfirmationDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderConfirmationDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateOrderConfirmationDraftWithHttpInfo(companySlug, invoiceishDraftRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.CreateOrderConfirmationDraftWithHttpInfo: " + e.Message);
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

<a id="createorderconfirmationfromdraft"></a>
# **CreateOrderConfirmationFromDraft**
> void CreateOrderConfirmationFromDraft (string companySlug, long draftId)



Creates an order confirmation from an already created draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateOrderConfirmationFromDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                apiInstance.CreateOrderConfirmationFromDraft(companySlug, draftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.CreateOrderConfirmationFromDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrderConfirmationFromDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateOrderConfirmationFromDraftWithHttpInfo(companySlug, draftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.CreateOrderConfirmationFromDraftWithHttpInfo: " + e.Message);
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

<a id="deleteorderconfirmationdraft"></a>
# **DeleteOrderConfirmationDraft**
> void DeleteOrderConfirmationDraft (string companySlug, long draftId)



Delete order confirmation draft with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class DeleteOrderConfirmationDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                apiInstance.DeleteOrderConfirmationDraft(companySlug, draftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.DeleteOrderConfirmationDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOrderConfirmationDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteOrderConfirmationDraftWithHttpInfo(companySlug, draftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.DeleteOrderConfirmationDraftWithHttpInfo: " + e.Message);
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

<a id="getorderconfirmation"></a>
# **GetOrderConfirmation**
> OrderConfirmation GetOrderConfirmation (string companySlug, string confirmationId)



Returns order confirmation with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOrderConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var confirmationId = "confirmationId_example";  // string | The confirmationId (primary key of the returned object) is returned as the first field in the GET all order confirmations call 

            try
            {
                OrderConfirmation result = apiInstance.GetOrderConfirmation(companySlug, confirmationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderConfirmationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OrderConfirmation> response = apiInstance.GetOrderConfirmationWithHttpInfo(companySlug, confirmationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **confirmationId** | **string** | The confirmationId (primary key of the returned object) is returned as the first field in the GET all order confirmations call  |  |

### Return type

[**OrderConfirmation**](OrderConfirmation.md)

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

<a id="getorderconfirmationcounter"></a>
# **GetOrderConfirmationCounter**
> Counter GetOrderConfirmationCounter (string companySlug)



Retrieves the counter for order confirmations if it has been created 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOrderConfirmationCounterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve

            try
            {
                Counter result = apiInstance.GetOrderConfirmationCounter(companySlug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationCounter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderConfirmationCounterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Counter> response = apiInstance.GetOrderConfirmationCounterWithHttpInfo(companySlug);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationCounterWithHttpInfo: " + e.Message);
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

<a id="getorderconfirmationdraft"></a>
# **GetOrderConfirmationDraft**
> InvoiceishDraftResult GetOrderConfirmationDraft (string companySlug, long draftId)



Returns order confirmation draft with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOrderConfirmationDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                InvoiceishDraftResult result = apiInstance.GetOrderConfirmationDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderConfirmationDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InvoiceishDraftResult> response = apiInstance.GetOrderConfirmationDraftWithHttpInfo(companySlug, draftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationDraftWithHttpInfo: " + e.Message);
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

<a id="getorderconfirmationdraftattachments"></a>
# **GetOrderConfirmationDraftAttachments**
> List&lt;Attachment&gt; GetOrderConfirmationDraftAttachments (string companySlug, long draftId)



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
    public class GetOrderConfirmationDraftAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                List<Attachment> result = apiInstance.GetOrderConfirmationDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationDraftAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderConfirmationDraftAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Attachment>> response = apiInstance.GetOrderConfirmationDraftAttachmentsWithHttpInfo(companySlug, draftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationDraftAttachmentsWithHttpInfo: " + e.Message);
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

<a id="getorderconfirmationdrafts"></a>
# **GetOrderConfirmationDrafts**
> List&lt;InvoiceishDraftResult&gt; GetOrderConfirmationDrafts (string companySlug, int page = null, int pageSize = null)



Returns all order confirmation drafts for given company.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOrderConfirmationDraftsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List<InvoiceishDraftResult> result = apiInstance.GetOrderConfirmationDrafts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationDrafts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderConfirmationDraftsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<InvoiceishDraftResult>> response = apiInstance.GetOrderConfirmationDraftsWithHttpInfo(companySlug, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationDraftsWithHttpInfo: " + e.Message);
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

<a id="getorderconfirmations"></a>
# **GetOrderConfirmations**
> List&lt;OrderConfirmation&gt; GetOrderConfirmations (string companySlug, int page = null, int pageSize = null)



Returns all order confirmations for given company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetOrderConfirmationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List<OrderConfirmation> result = apiInstance.GetOrderConfirmations(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderConfirmationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<OrderConfirmation>> response = apiInstance.GetOrderConfirmationsWithHttpInfo(companySlug, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationsWithHttpInfo: " + e.Message);
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

[**List&lt;OrderConfirmation&gt;**](OrderConfirmation.md)

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

<a id="updateorderconfirmationdraft"></a>
# **UpdateOrderConfirmationDraft**
> void UpdateOrderConfirmationDraft (string companySlug, long draftId, InvoiceishDraftRequest invoiceishDraftRequest)



Updates order confirmation draft with provided id. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class UpdateOrderConfirmationDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 
            var invoiceishDraftRequest = new InvoiceishDraftRequest(); // InvoiceishDraftRequest | 

            try
            {
                apiInstance.UpdateOrderConfirmationDraft(companySlug, draftId, invoiceishDraftRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.UpdateOrderConfirmationDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrderConfirmationDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateOrderConfirmationDraftWithHttpInfo(companySlug, draftId, invoiceishDraftRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderConfirmationsApi.UpdateOrderConfirmationDraftWithHttpInfo: " + e.Message);
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

