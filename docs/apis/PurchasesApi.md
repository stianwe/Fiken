# Fiken.Api.PurchasesApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAttachmentToPurchase**](PurchasesApi.md#addattachmenttopurchase) | **POST** /companies/{companySlug}/purchases/{purchaseId}/attachments |  |
| [**AddAttachmentToPurchaseDraft**](PurchasesApi.md#addattachmenttopurchasedraft) | **POST** /companies/{companySlug}/purchases/drafts/{draftId}/attachments |  |
| [**CreatePurchase**](PurchasesApi.md#createpurchase) | **POST** /companies/{companySlug}/purchases |  |
| [**CreatePurchaseDraft**](PurchasesApi.md#createpurchasedraft) | **POST** /companies/{companySlug}/purchases/drafts |  |
| [**CreatePurchaseFromDraft**](PurchasesApi.md#createpurchasefromdraft) | **POST** /companies/{companySlug}/purchases/drafts/{draftId}/createPurchase |  |
| [**CreatePurchasePayment**](PurchasesApi.md#createpurchasepayment) | **POST** /companies/{companySlug}/purchases/{purchaseId}/payments |  |
| [**DeletePurchase**](PurchasesApi.md#deletepurchase) | **PATCH** /companies/{companySlug}/purchases/{purchaseId}/delete |  |
| [**DeletePurchaseDraft**](PurchasesApi.md#deletepurchasedraft) | **DELETE** /companies/{companySlug}/purchases/drafts/{draftId} |  |
| [**GetPurchase**](PurchasesApi.md#getpurchase) | **GET** /companies/{companySlug}/purchases/{purchaseId} |  |
| [**GetPurchaseAttachments**](PurchasesApi.md#getpurchaseattachments) | **GET** /companies/{companySlug}/purchases/{purchaseId}/attachments |  |
| [**GetPurchaseDraft**](PurchasesApi.md#getpurchasedraft) | **GET** /companies/{companySlug}/purchases/drafts/{draftId} |  |
| [**GetPurchaseDraftAttachments**](PurchasesApi.md#getpurchasedraftattachments) | **GET** /companies/{companySlug}/purchases/drafts/{draftId}/attachments |  |
| [**GetPurchaseDrafts**](PurchasesApi.md#getpurchasedrafts) | **GET** /companies/{companySlug}/purchases/drafts |  |
| [**GetPurchasePayment**](PurchasesApi.md#getpurchasepayment) | **GET** /companies/{companySlug}/purchases/{purchaseId}/payments/{paymentId} |  |
| [**GetPurchasePayments**](PurchasesApi.md#getpurchasepayments) | **GET** /companies/{companySlug}/purchases/{purchaseId}/payments |  |
| [**GetPurchases**](PurchasesApi.md#getpurchases) | **GET** /companies/{companySlug}/purchases |  |
| [**UpdatePurchaseDraft**](PurchasesApi.md#updatepurchasedraft) | **PUT** /companies/{companySlug}/purchases/drafts/{draftId} |  |

<a id="addattachmenttopurchase"></a>
# **AddAttachmentToPurchase**
> void AddAttachmentToPurchase (string companySlug, long purchaseId, string filename = null, bool attachToPayment = null, bool attachToSale = null, System.IO.Stream file = null)



Creates and adds a new attachment to a Purchase

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class AddAttachmentToPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var purchaseId = 789L;  // long | 
            var filename = "filename_example";  // string | The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf (optional) 
            var attachToPayment = true;  // bool | True if this attachment may document the payment (i.e. transaction receipt from credit card/payment company, export from bank, etc.). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true. (optional) 
            var attachToSale = true;  // bool | True if this attachment may document the sale (i.e. invoice, etc). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true. (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                apiInstance.AddAttachmentToPurchase(companySlug, purchaseId, filename, attachToPayment, attachToSale, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.AddAttachmentToPurchase: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAttachmentToPurchaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddAttachmentToPurchaseWithHttpInfo(companySlug, purchaseId, filename, attachToPayment, attachToSale, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.AddAttachmentToPurchaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **purchaseId** | **long** |  |  |
| **filename** | **string** | The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf | [optional]  |
| **attachToPayment** | **bool** | True if this attachment may document the payment (i.e. transaction receipt from credit card/payment company, export from bank, etc.). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true. | [optional]  |
| **attachToSale** | **bool** | True if this attachment may document the sale (i.e. invoice, etc). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true. | [optional]  |
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

<a id="addattachmenttopurchasedraft"></a>
# **AddAttachmentToPurchaseDraft**
> void AddAttachmentToPurchaseDraft (string companySlug, long draftId, string filename = null, System.IO.Stream file = null)



Creates and adds a new attachment to a draft

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class AddAttachmentToPurchaseDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 
            var filename = "filename_example";  // string | Required. The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                apiInstance.AddAttachmentToPurchaseDraft(companySlug, draftId, filename, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.AddAttachmentToPurchaseDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAttachmentToPurchaseDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddAttachmentToPurchaseDraftWithHttpInfo(companySlug, draftId, filename, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.AddAttachmentToPurchaseDraftWithHttpInfo: " + e.Message);
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

<a id="createpurchase"></a>
# **CreatePurchase**
> void CreatePurchase (string companySlug, PurchaseRequest purchaseRequest)



Creates a new purchase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreatePurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var purchaseRequest = new PurchaseRequest(); // PurchaseRequest | 

            try
            {
                apiInstance.CreatePurchase(companySlug, purchaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.CreatePurchase: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePurchaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreatePurchaseWithHttpInfo(companySlug, purchaseRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.CreatePurchaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **purchaseRequest** | [**PurchaseRequest**](PurchaseRequest.md) |  |  |

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

<a id="createpurchasedraft"></a>
# **CreatePurchaseDraft**
> void CreatePurchaseDraft (string companySlug, DraftRequest draftRequest)



Creates a purchase draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreatePurchaseDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftRequest = new DraftRequest(); // DraftRequest | 

            try
            {
                apiInstance.CreatePurchaseDraft(companySlug, draftRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.CreatePurchaseDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePurchaseDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreatePurchaseDraftWithHttpInfo(companySlug, draftRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.CreatePurchaseDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **draftRequest** | [**DraftRequest**](DraftRequest.md) |  |  |

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

<a id="createpurchasefromdraft"></a>
# **CreatePurchaseFromDraft**
> void CreatePurchaseFromDraft (string companySlug, long draftId)



Creates a purchase from an already created draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreatePurchaseFromDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                apiInstance.CreatePurchaseFromDraft(companySlug, draftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.CreatePurchaseFromDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePurchaseFromDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreatePurchaseFromDraftWithHttpInfo(companySlug, draftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.CreatePurchaseFromDraftWithHttpInfo: " + e.Message);
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

<a id="createpurchasepayment"></a>
# **CreatePurchasePayment**
> void CreatePurchasePayment (string companySlug, long purchaseId, Payment payment)



Creates a new payment for a purchase

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreatePurchasePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var purchaseId = 789L;  // long | 
            var payment = new Payment(); // Payment | 

            try
            {
                apiInstance.CreatePurchasePayment(companySlug, purchaseId, payment);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.CreatePurchasePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePurchasePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreatePurchasePaymentWithHttpInfo(companySlug, purchaseId, payment);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.CreatePurchasePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **purchaseId** | **long** |  |  |
| **payment** | [**Payment**](Payment.md) |  |  |

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

<a id="deletepurchase"></a>
# **DeletePurchase**
> PurchaseResult DeletePurchase (string companySlug, long purchaseId, string description)



Sets the deleted flag for a purchase. The purchase is not deleted, but a reverse transaction is created and the \"deleted\" property is set to true.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class DeletePurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var purchaseId = 789L;  // long | 
            var description = "description_example";  // string | Required description for deleting the purchase

            try
            {
                PurchaseResult result = apiInstance.DeletePurchase(companySlug, purchaseId, description);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.DeletePurchase: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePurchaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PurchaseResult> response = apiInstance.DeletePurchaseWithHttpInfo(companySlug, purchaseId, description);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.DeletePurchaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **purchaseId** | **long** |  |  |
| **description** | **string** | Required description for deleting the purchase |  |

### Return type

[**PurchaseResult**](PurchaseResult.md)

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

<a id="deletepurchasedraft"></a>
# **DeletePurchaseDraft**
> void DeletePurchaseDraft (string companySlug, long draftId)



Delete draft with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class DeletePurchaseDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                apiInstance.DeletePurchaseDraft(companySlug, draftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.DeletePurchaseDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePurchaseDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeletePurchaseDraftWithHttpInfo(companySlug, draftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.DeletePurchaseDraftWithHttpInfo: " + e.Message);
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

<a id="getpurchase"></a>
# **GetPurchase**
> PurchaseResult GetPurchase (string companySlug, long purchaseId)



Returns purchase with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var purchaseId = 789L;  // long | 

            try
            {
                PurchaseResult result = apiInstance.GetPurchase(companySlug, purchaseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchase: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PurchaseResult> response = apiInstance.GetPurchaseWithHttpInfo(companySlug, purchaseId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.GetPurchaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **purchaseId** | **long** |  |  |

### Return type

[**PurchaseResult**](PurchaseResult.md)

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

<a id="getpurchaseattachments"></a>
# **GetPurchaseAttachments**
> List&lt;Attachment&gt; GetPurchaseAttachments (string companySlug, long purchaseId)



Returns all attachments for specified purchase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetPurchaseAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var purchaseId = 789L;  // long | 

            try
            {
                List<Attachment> result = apiInstance.GetPurchaseAttachments(companySlug, purchaseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchaseAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Attachment>> response = apiInstance.GetPurchaseAttachmentsWithHttpInfo(companySlug, purchaseId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.GetPurchaseAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **purchaseId** | **long** |  |  |

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

<a id="getpurchasedraft"></a>
# **GetPurchaseDraft**
> DraftResult GetPurchaseDraft (string companySlug, long draftId)



Returns draft with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetPurchaseDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                DraftResult result = apiInstance.GetPurchaseDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchaseDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DraftResult> response = apiInstance.GetPurchaseDraftWithHttpInfo(companySlug, draftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.GetPurchaseDraftWithHttpInfo: " + e.Message);
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

[**DraftResult**](DraftResult.md)

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

<a id="getpurchasedraftattachments"></a>
# **GetPurchaseDraftAttachments**
> List&lt;Attachment&gt; GetPurchaseDraftAttachments (string companySlug, long draftId)



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
    public class GetPurchaseDraftAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                List<Attachment> result = apiInstance.GetPurchaseDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchaseDraftAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseDraftAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Attachment>> response = apiInstance.GetPurchaseDraftAttachmentsWithHttpInfo(companySlug, draftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.GetPurchaseDraftAttachmentsWithHttpInfo: " + e.Message);
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

<a id="getpurchasedrafts"></a>
# **GetPurchaseDrafts**
> List&lt;DraftResult&gt; GetPurchaseDrafts (string companySlug, int page = null, int pageSize = null)



Returns all purchase drafts for given company.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetPurchaseDraftsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List<DraftResult> result = apiInstance.GetPurchaseDrafts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchaseDrafts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseDraftsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<DraftResult>> response = apiInstance.GetPurchaseDraftsWithHttpInfo(companySlug, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.GetPurchaseDraftsWithHttpInfo: " + e.Message);
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

[**List&lt;DraftResult&gt;**](DraftResult.md)

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

<a id="getpurchasepayment"></a>
# **GetPurchasePayment**
> Payment GetPurchasePayment (string companySlug, long purchaseId, long paymentId)



Returns given payment for specified purchase

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetPurchasePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var purchaseId = 789L;  // long | 
            var paymentId = 789L;  // long | 

            try
            {
                Payment result = apiInstance.GetPurchasePayment(companySlug, purchaseId, paymentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchasePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchasePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Payment> response = apiInstance.GetPurchasePaymentWithHttpInfo(companySlug, purchaseId, paymentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.GetPurchasePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **purchaseId** | **long** |  |  |
| **paymentId** | **long** |  |  |

### Return type

[**Payment**](Payment.md)

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

<a id="getpurchasepayments"></a>
# **GetPurchasePayments**
> List&lt;Payment&gt; GetPurchasePayments (string companySlug, long purchaseId)



Returns all purchases for given company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetPurchasePaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var purchaseId = 789L;  // long | 

            try
            {
                List<Payment> result = apiInstance.GetPurchasePayments(companySlug, purchaseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchasePayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchasePaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Payment>> response = apiInstance.GetPurchasePaymentsWithHttpInfo(companySlug, purchaseId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.GetPurchasePaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **purchaseId** | **long** |  |  |

### Return type

[**List&lt;Payment&gt;**](Payment.md)

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

<a id="getpurchases"></a>
# **GetPurchases**
> List&lt;PurchaseResult&gt; GetPurchases (string companySlug, int page = null, int pageSize = null, DateOnly date = null, DateOnly dateLe = null, DateOnly dateLt = null, DateOnly dateGe = null, DateOnly dateGt = null, string sortBy = null, bool paid = null)



Returns all purchases for given company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetPurchasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var date = DateOnly.Parse("2013-10-20");  // DateOnly | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var dateLe = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var dateLt = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var dateGe = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var dateGt = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var sortBy = "date asc";  // string | Sorts results in either ascending (asc) or descending (desc) order based on the parameter value. (optional)  (default to date asc)
            var paid = true;  // bool | When set to true, returns only purchases that have been paid. Otherwise false returns all purchases that have not been fully settled.  (optional) 

            try
            {
                List<PurchaseResult> result = apiInstance.GetPurchases(companySlug, page, pageSize, date, dateLe, dateLt, dateGe, dateGt, sortBy, paid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchases: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchasesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PurchaseResult>> response = apiInstance.GetPurchasesWithHttpInfo(companySlug, page, pageSize, date, dateLe, dateLt, dateGe, dateGt, sortBy, paid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.GetPurchasesWithHttpInfo: " + e.Message);
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
| **date** | **DateOnly** | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **dateLe** | **DateOnly** | Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **dateLt** | **DateOnly** | Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **dateGe** | **DateOnly** | Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **dateGt** | **DateOnly** | Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **sortBy** | **string** | Sorts results in either ascending (asc) or descending (desc) order based on the parameter value. | [optional] [default to date asc] |
| **paid** | **bool** | When set to true, returns only purchases that have been paid. Otherwise false returns all purchases that have not been fully settled.  | [optional]  |

### Return type

[**List&lt;PurchaseResult&gt;**](PurchaseResult.md)

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

<a id="updatepurchasedraft"></a>
# **UpdatePurchaseDraft**
> void UpdatePurchaseDraft (string companySlug, long draftId, DraftRequest draftRequest)



Updates draft with provided id. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class UpdatePurchaseDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 
            var draftRequest = new DraftRequest(); // DraftRequest | 

            try
            {
                apiInstance.UpdatePurchaseDraft(companySlug, draftId, draftRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PurchasesApi.UpdatePurchaseDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePurchaseDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdatePurchaseDraftWithHttpInfo(companySlug, draftId, draftRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PurchasesApi.UpdatePurchaseDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **draftId** | **long** | The draftId (primary key of the returned object) is returned in the GET all drafts call.  |  |
| **draftRequest** | [**DraftRequest**](DraftRequest.md) |  |  |

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

