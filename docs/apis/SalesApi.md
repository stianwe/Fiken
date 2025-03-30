# Fiken.Api.SalesApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAttachmentToSale**](SalesApi.md#addattachmenttosale) | **POST** /companies/{companySlug}/sales/{saleId}/attachments |  |
| [**AddAttachmentToSaleDraft**](SalesApi.md#addattachmenttosaledraft) | **POST** /companies/{companySlug}/sales/drafts/{draftId}/attachments |  |
| [**CreateSale**](SalesApi.md#createsale) | **POST** /companies/{companySlug}/sales |  |
| [**CreateSaleDraft**](SalesApi.md#createsaledraft) | **POST** /companies/{companySlug}/sales/drafts |  |
| [**CreateSaleFromDraft**](SalesApi.md#createsalefromdraft) | **POST** /companies/{companySlug}/sales/drafts/{draftId}/createSale |  |
| [**CreateSalePayment**](SalesApi.md#createsalepayment) | **POST** /companies/{companySlug}/sales/{saleId}/payments |  |
| [**DeleteSale**](SalesApi.md#deletesale) | **PATCH** /companies/{companySlug}/sales/{saleId}/delete |  |
| [**DeleteSaleDraft**](SalesApi.md#deletesaledraft) | **DELETE** /companies/{companySlug}/sales/drafts/{draftId} |  |
| [**GetSale**](SalesApi.md#getsale) | **GET** /companies/{companySlug}/sales/{saleId} |  |
| [**GetSaleAttachments**](SalesApi.md#getsaleattachments) | **GET** /companies/{companySlug}/sales/{saleId}/attachments |  |
| [**GetSaleDraft**](SalesApi.md#getsaledraft) | **GET** /companies/{companySlug}/sales/drafts/{draftId} |  |
| [**GetSaleDraftAttachments**](SalesApi.md#getsaledraftattachments) | **GET** /companies/{companySlug}/sales/drafts/{draftId}/attachments |  |
| [**GetSaleDrafts**](SalesApi.md#getsaledrafts) | **GET** /companies/{companySlug}/sales/drafts |  |
| [**GetSalePayment**](SalesApi.md#getsalepayment) | **GET** /companies/{companySlug}/sales/{saleId}/payments/{paymentId} |  |
| [**GetSalePayments**](SalesApi.md#getsalepayments) | **GET** /companies/{companySlug}/sales/{saleId}/payments |  |
| [**GetSales**](SalesApi.md#getsales) | **GET** /companies/{companySlug}/sales |  |
| [**SettledSale**](SalesApi.md#settledsale) | **PATCH** /companies/{companySlug}/sales/{saleId}/settled |  |
| [**UpdateSaleDraft**](SalesApi.md#updatesaledraft) | **PUT** /companies/{companySlug}/sales/drafts/{draftId} |  |

<a id="addattachmenttosale"></a>
# **AddAttachmentToSale**
> void AddAttachmentToSale (string companySlug, long saleId, string filename = null, bool attachToPayment = null, bool attachToSale = null, System.IO.Stream file = null)



Creates and adds a new attachment to a Sale

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class AddAttachmentToSaleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var saleId = 789L;  // long | 
            var filename = "filename_example";  // string | The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf (optional) 
            var attachToPayment = true;  // bool | True if this attachment may document the payment (i.e. transaction receipt from credit card/payment company, export from bank, etc.). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true. (optional)  (default to true)
            var attachToSale = true;  // bool | True if this attachment may document the sale (i.e. invoice, etc). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true. (optional)  (default to true)
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                apiInstance.AddAttachmentToSale(companySlug, saleId, filename, attachToPayment, attachToSale, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.AddAttachmentToSale: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAttachmentToSaleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddAttachmentToSaleWithHttpInfo(companySlug, saleId, filename, attachToPayment, attachToSale, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.AddAttachmentToSaleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **saleId** | **long** |  |  |
| **filename** | **string** | The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf | [optional]  |
| **attachToPayment** | **bool** | True if this attachment may document the payment (i.e. transaction receipt from credit card/payment company, export from bank, etc.). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true. | [optional] [default to true] |
| **attachToSale** | **bool** | True if this attachment may document the sale (i.e. invoice, etc). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true. | [optional] [default to true] |
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

<a id="addattachmenttosaledraft"></a>
# **AddAttachmentToSaleDraft**
> void AddAttachmentToSaleDraft (string companySlug, long draftId, string filename = null, System.IO.Stream file = null)



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
    public class AddAttachmentToSaleDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 
            var filename = "filename_example";  // string | Required. The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                apiInstance.AddAttachmentToSaleDraft(companySlug, draftId, filename, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.AddAttachmentToSaleDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAttachmentToSaleDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddAttachmentToSaleDraftWithHttpInfo(companySlug, draftId, filename, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.AddAttachmentToSaleDraftWithHttpInfo: " + e.Message);
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

<a id="createsale"></a>
# **CreateSale**
> void CreateSale (string companySlug, SaleRequest saleRequest)



Creates a new sale. This corresponds to \"Annet salg\" in Fiken and should be used when the invoice document and invoice number have been created outside Fiken. Otherwise the invoices-endpoints should be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateSaleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var saleRequest = new SaleRequest(); // SaleRequest | 

            try
            {
                apiInstance.CreateSale(companySlug, saleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.CreateSale: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSaleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateSaleWithHttpInfo(companySlug, saleRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.CreateSaleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **saleRequest** | [**SaleRequest**](SaleRequest.md) |  |  |

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

<a id="createsaledraft"></a>
# **CreateSaleDraft**
> void CreateSaleDraft (string companySlug, DraftRequest draftRequest)



Creates a sale draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateSaleDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftRequest = new DraftRequest(); // DraftRequest | 

            try
            {
                apiInstance.CreateSaleDraft(companySlug, draftRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.CreateSaleDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSaleDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateSaleDraftWithHttpInfo(companySlug, draftRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.CreateSaleDraftWithHttpInfo: " + e.Message);
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

<a id="createsalefromdraft"></a>
# **CreateSaleFromDraft**
> void CreateSaleFromDraft (string companySlug, long draftId)



Creates a sale from an already created draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateSaleFromDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                apiInstance.CreateSaleFromDraft(companySlug, draftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.CreateSaleFromDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSaleFromDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateSaleFromDraftWithHttpInfo(companySlug, draftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.CreateSaleFromDraftWithHttpInfo: " + e.Message);
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

<a id="createsalepayment"></a>
# **CreateSalePayment**
> void CreateSalePayment (string companySlug, long saleId, Payment payment)



Creates a new payment for a given sale.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateSalePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var saleId = 789L;  // long | 
            var payment = new Payment(); // Payment | 

            try
            {
                apiInstance.CreateSalePayment(companySlug, saleId, payment);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.CreateSalePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSalePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateSalePaymentWithHttpInfo(companySlug, saleId, payment);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.CreateSalePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **saleId** | **long** |  |  |
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

<a id="deletesale"></a>
# **DeleteSale**
> SaleResult DeleteSale (string companySlug, long saleId, string description)



Sets the deleted flag for a sale. The sale is not deleted, but a reverse transaction is created and the \"deleted\" property is set to true.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class DeleteSaleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var saleId = 789L;  // long | 
            var description = "description_example";  // string | Required description for deleting the sale

            try
            {
                SaleResult result = apiInstance.DeleteSale(companySlug, saleId, description);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.DeleteSale: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSaleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SaleResult> response = apiInstance.DeleteSaleWithHttpInfo(companySlug, saleId, description);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.DeleteSaleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **saleId** | **long** |  |  |
| **description** | **string** | Required description for deleting the sale |  |

### Return type

[**SaleResult**](SaleResult.md)

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

<a id="deletesaledraft"></a>
# **DeleteSaleDraft**
> void DeleteSaleDraft (string companySlug, long draftId)



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
    public class DeleteSaleDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                apiInstance.DeleteSaleDraft(companySlug, draftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.DeleteSaleDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSaleDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteSaleDraftWithHttpInfo(companySlug, draftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.DeleteSaleDraftWithHttpInfo: " + e.Message);
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

<a id="getsale"></a>
# **GetSale**
> SaleResult GetSale (string companySlug, long saleId)



Returns sale with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetSaleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var saleId = 789L;  // long | 

            try
            {
                SaleResult result = apiInstance.GetSale(companySlug, saleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.GetSale: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSaleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SaleResult> response = apiInstance.GetSaleWithHttpInfo(companySlug, saleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.GetSaleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **saleId** | **long** |  |  |

### Return type

[**SaleResult**](SaleResult.md)

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

<a id="getsaleattachments"></a>
# **GetSaleAttachments**
> List&lt;Attachment&gt; GetSaleAttachments (string companySlug, long saleId)



Returns all attachments for specified sale.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetSaleAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var saleId = 789L;  // long | 

            try
            {
                List<Attachment> result = apiInstance.GetSaleAttachments(companySlug, saleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.GetSaleAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSaleAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Attachment>> response = apiInstance.GetSaleAttachmentsWithHttpInfo(companySlug, saleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.GetSaleAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **saleId** | **long** |  |  |

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

<a id="getsaledraft"></a>
# **GetSaleDraft**
> DraftResult GetSaleDraft (string companySlug, long draftId)



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
    public class GetSaleDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                DraftResult result = apiInstance.GetSaleDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.GetSaleDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSaleDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DraftResult> response = apiInstance.GetSaleDraftWithHttpInfo(companySlug, draftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.GetSaleDraftWithHttpInfo: " + e.Message);
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

<a id="getsaledraftattachments"></a>
# **GetSaleDraftAttachments**
> List&lt;Attachment&gt; GetSaleDraftAttachments (string companySlug, long draftId)



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
    public class GetSaleDraftAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                List<Attachment> result = apiInstance.GetSaleDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.GetSaleDraftAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSaleDraftAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Attachment>> response = apiInstance.GetSaleDraftAttachmentsWithHttpInfo(companySlug, draftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.GetSaleDraftAttachmentsWithHttpInfo: " + e.Message);
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

<a id="getsaledrafts"></a>
# **GetSaleDrafts**
> List&lt;DraftResult&gt; GetSaleDrafts (string companySlug, int page = null, int pageSize = null)



Returns all sale drafts for given company.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetSaleDraftsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List<DraftResult> result = apiInstance.GetSaleDrafts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.GetSaleDrafts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSaleDraftsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<DraftResult>> response = apiInstance.GetSaleDraftsWithHttpInfo(companySlug, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.GetSaleDraftsWithHttpInfo: " + e.Message);
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

<a id="getsalepayment"></a>
# **GetSalePayment**
> Payment GetSalePayment (string companySlug, long saleId, long paymentId)



Returns payment with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetSalePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var saleId = 789L;  // long | 
            var paymentId = 789L;  // long | 

            try
            {
                Payment result = apiInstance.GetSalePayment(companySlug, saleId, paymentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.GetSalePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSalePaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Payment> response = apiInstance.GetSalePaymentWithHttpInfo(companySlug, saleId, paymentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.GetSalePaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **saleId** | **long** |  |  |
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

<a id="getsalepayments"></a>
# **GetSalePayments**
> List&lt;Payment&gt; GetSalePayments (string companySlug, long saleId)



Returns all payments for given sale

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetSalePaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var saleId = 789L;  // long | 

            try
            {
                List<Payment> result = apiInstance.GetSalePayments(companySlug, saleId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.GetSalePayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSalePaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Payment>> response = apiInstance.GetSalePaymentsWithHttpInfo(companySlug, saleId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.GetSalePaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **saleId** | **long** |  |  |

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

<a id="getsales"></a>
# **GetSales**
> List&lt;SaleResult&gt; GetSales (string companySlug, int page = null, int pageSize = null, DateOnly date = null, DateOnly dateLe = null, DateOnly dateLt = null, DateOnly dateGe = null, DateOnly dateGt = null, DateOnly lastModified = null, DateOnly lastModifiedLe = null, DateOnly lastModifiedLt = null, DateOnly lastModifiedGe = null, DateOnly lastModifiedGt = null, string saleNumber = null, bool settled = null, long contactId = null)



Returns all sales for given company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetSalesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var date = DateOnly.Parse("2013-10-20");  // DateOnly | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var dateLe = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var dateLt = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var dateGe = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var dateGt = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModified = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedLe = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedLt = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedGe = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedGt = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var saleNumber = "saleNumber_example";  // string | Find all results with the sale number equal to the specified parameter. (optional) 
            var settled = true;  // bool | When set to true, returns only sales that have been settled. Otherwise false returns all sales that have not been fully settled.  (optional) 
            var contactId = 789L;  // long | Find all sale results for a given customer (optional) 

            try
            {
                List<SaleResult> result = apiInstance.GetSales(companySlug, page, pageSize, date, dateLe, dateLt, dateGe, dateGt, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, saleNumber, settled, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.GetSales: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSalesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SaleResult>> response = apiInstance.GetSalesWithHttpInfo(companySlug, page, pageSize, date, dateLe, dateLt, dateGe, dateGt, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, saleNumber, settled, contactId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.GetSalesWithHttpInfo: " + e.Message);
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
| **lastModified** | **DateOnly** | Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedLe** | **DateOnly** | Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedLt** | **DateOnly** | Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedGe** | **DateOnly** | Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedGt** | **DateOnly** | Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **saleNumber** | **string** | Find all results with the sale number equal to the specified parameter. | [optional]  |
| **settled** | **bool** | When set to true, returns only sales that have been settled. Otherwise false returns all sales that have not been fully settled.  | [optional]  |
| **contactId** | **long** | Find all sale results for a given customer | [optional]  |

### Return type

[**List&lt;SaleResult&gt;**](SaleResult.md)

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

<a id="settledsale"></a>
# **SettledSale**
> SaleResult SettledSale (string companySlug, long saleId, DateOnly settledDate)



Marks the sale as settled without payment. This is synonymous with \"sett til oppgjort uten betaling\" in the GUI. It is possible to change the date of settlement by sending a new settledDate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class SettledSaleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var saleId = 789L;  // long | 
            var settledDate = DateOnly.Parse("2013-10-20");  // DateOnly | Date that the sale is settled

            try
            {
                SaleResult result = apiInstance.SettledSale(companySlug, saleId, settledDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.SettledSale: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SettledSaleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SaleResult> response = apiInstance.SettledSaleWithHttpInfo(companySlug, saleId, settledDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.SettledSaleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **saleId** | **long** |  |  |
| **settledDate** | **DateOnly** | Date that the sale is settled |  |

### Return type

[**SaleResult**](SaleResult.md)

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

<a id="updatesaledraft"></a>
# **UpdateSaleDraft**
> void UpdateSaleDraft (string companySlug, long draftId, DraftRequest draftRequest)



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
    public class UpdateSaleDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 
            var draftRequest = new DraftRequest(); // DraftRequest | 

            try
            {
                apiInstance.UpdateSaleDraft(companySlug, draftId, draftRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesApi.UpdateSaleDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSaleDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateSaleDraftWithHttpInfo(companySlug, draftId, draftRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesApi.UpdateSaleDraftWithHttpInfo: " + e.Message);
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

