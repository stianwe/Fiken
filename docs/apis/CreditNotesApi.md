# Fiken.Api.CreditNotesApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAttachmentToCreditNoteDraft**](CreditNotesApi.md#addattachmenttocreditnotedraft) | **POST** /companies/{companySlug}/creditNotes/drafts/{draftId}/attachments |  |
| [**CreateCreditNoteCounter**](CreditNotesApi.md#createcreditnotecounter) | **POST** /companies/{companySlug}/creditNotes/counter |  |
| [**CreateCreditNoteDraft**](CreditNotesApi.md#createcreditnotedraft) | **POST** /companies/{companySlug}/creditNotes/drafts |  |
| [**CreateCreditNoteFromDraft**](CreditNotesApi.md#createcreditnotefromdraft) | **POST** /companies/{companySlug}/creditNotes/drafts/{draftId}/createCreditNote |  |
| [**CreateFullCreditNote**](CreditNotesApi.md#createfullcreditnote) | **POST** /companies/{companySlug}/creditNotes/full |  |
| [**CreatePartialCreditNote**](CreditNotesApi.md#createpartialcreditnote) | **POST** /companies/{companySlug}/creditNotes/partial |  |
| [**DeleteCreditNoteDraft**](CreditNotesApi.md#deletecreditnotedraft) | **DELETE** /companies/{companySlug}/creditNotes/drafts/{draftId} |  |
| [**GetCreditNote**](CreditNotesApi.md#getcreditnote) | **GET** /companies/{companySlug}/creditNotes/{creditNoteId} |  |
| [**GetCreditNoteCounter**](CreditNotesApi.md#getcreditnotecounter) | **GET** /companies/{companySlug}/creditNotes/counter |  |
| [**GetCreditNoteDraft**](CreditNotesApi.md#getcreditnotedraft) | **GET** /companies/{companySlug}/creditNotes/drafts/{draftId} |  |
| [**GetCreditNoteDraftAttachments**](CreditNotesApi.md#getcreditnotedraftattachments) | **GET** /companies/{companySlug}/creditNotes/drafts/{draftId}/attachments |  |
| [**GetCreditNoteDrafts**](CreditNotesApi.md#getcreditnotedrafts) | **GET** /companies/{companySlug}/creditNotes/drafts |  |
| [**GetCreditNotes**](CreditNotesApi.md#getcreditnotes) | **GET** /companies/{companySlug}/creditNotes |  |
| [**SendCreditNote**](CreditNotesApi.md#sendcreditnote) | **POST** /companies/{companySlug}/creditNotes/send |  |
| [**UpdateCreditNoteDraft**](CreditNotesApi.md#updatecreditnotedraft) | **PUT** /companies/{companySlug}/creditNotes/drafts/{draftId} |  |

<a id="addattachmenttocreditnotedraft"></a>
# **AddAttachmentToCreditNoteDraft**
> void AddAttachmentToCreditNoteDraft (string companySlug, long draftId, string filename = null, string comment = null, System.IO.Stream file = null)



Creates and adds a new attachment to a credit note draft

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class AddAttachmentToCreditNoteDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 
            var filename = "filename_example";  // string | Required. The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf (optional) 
            var comment = "comment_example";  // string | Not required. (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                apiInstance.AddAttachmentToCreditNoteDraft(companySlug, draftId, filename, comment, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.AddAttachmentToCreditNoteDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAttachmentToCreditNoteDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddAttachmentToCreditNoteDraftWithHttpInfo(companySlug, draftId, filename, comment, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.AddAttachmentToCreditNoteDraftWithHttpInfo: " + e.Message);
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

<a id="createcreditnotecounter"></a>
# **CreateCreditNoteCounter**
> void CreateCreditNoteCounter (string companySlug, Counter counter = null)



Creates the first credit note number which is then increased by one with every new credit note. By sending an empty request body the default is base number 10000 (the first credit note number will thus be 10001), but can be specified to another starting value.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateCreditNoteCounterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var counter = new Counter(); // Counter |  (optional) 

            try
            {
                apiInstance.CreateCreditNoteCounter(companySlug, counter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreateCreditNoteCounter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCreditNoteCounterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateCreditNoteCounterWithHttpInfo(companySlug, counter);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.CreateCreditNoteCounterWithHttpInfo: " + e.Message);
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

<a id="createcreditnotedraft"></a>
# **CreateCreditNoteDraft**
> void CreateCreditNoteDraft (string companySlug, InvoiceishDraftRequest invoiceishDraftRequest)



Creates a credit note draft. This draft corresponds to a draft for an \"uavhengig kreditnota\" in Fiken.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateCreditNoteDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var invoiceishDraftRequest = new InvoiceishDraftRequest(); // InvoiceishDraftRequest | 

            try
            {
                apiInstance.CreateCreditNoteDraft(companySlug, invoiceishDraftRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreateCreditNoteDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCreditNoteDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateCreditNoteDraftWithHttpInfo(companySlug, invoiceishDraftRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.CreateCreditNoteDraftWithHttpInfo: " + e.Message);
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

<a id="createcreditnotefromdraft"></a>
# **CreateCreditNoteFromDraft**
> void CreateCreditNoteFromDraft (string companySlug, long draftId)



Creates a credit note from an already created draft.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateCreditNoteFromDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                apiInstance.CreateCreditNoteFromDraft(companySlug, draftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreateCreditNoteFromDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCreditNoteFromDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateCreditNoteFromDraftWithHttpInfo(companySlug, draftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.CreateCreditNoteFromDraftWithHttpInfo: " + e.Message);
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

<a id="createfullcreditnote"></a>
# **CreateFullCreditNote**
> void CreateFullCreditNote (string companySlug, FullCreditNoteRequest fullCreditNoteRequest)



Creates a new credit note that covers the full amount of the associated invoice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateFullCreditNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var fullCreditNoteRequest = new FullCreditNoteRequest(); // FullCreditNoteRequest | 

            try
            {
                apiInstance.CreateFullCreditNote(companySlug, fullCreditNoteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreateFullCreditNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFullCreditNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateFullCreditNoteWithHttpInfo(companySlug, fullCreditNoteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.CreateFullCreditNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **fullCreditNoteRequest** | [**FullCreditNoteRequest**](FullCreditNoteRequest.md) |  |  |

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

<a id="createpartialcreditnote"></a>
# **CreatePartialCreditNote**
> void CreatePartialCreditNote (string companySlug, PartialCreditNoteRequest partialCreditNoteRequest)



Creates a new credit note that doesn't fully cover the total amount of the associated invoice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreatePartialCreditNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var partialCreditNoteRequest = new PartialCreditNoteRequest(); // PartialCreditNoteRequest | 

            try
            {
                apiInstance.CreatePartialCreditNote(companySlug, partialCreditNoteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreatePartialCreditNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePartialCreditNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreatePartialCreditNoteWithHttpInfo(companySlug, partialCreditNoteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.CreatePartialCreditNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **partialCreditNoteRequest** | [**PartialCreditNoteRequest**](PartialCreditNoteRequest.md) |  |  |

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

<a id="deletecreditnotedraft"></a>
# **DeleteCreditNoteDraft**
> void DeleteCreditNoteDraft (string companySlug, long draftId)



Delete credit note draft with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class DeleteCreditNoteDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                apiInstance.DeleteCreditNoteDraft(companySlug, draftId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.DeleteCreditNoteDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCreditNoteDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteCreditNoteDraftWithHttpInfo(companySlug, draftId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.DeleteCreditNoteDraftWithHttpInfo: " + e.Message);
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

<a id="getcreditnote"></a>
# **GetCreditNote**
> CreditNoteResult GetCreditNote (string companySlug, string creditNoteId)



Returns credit note with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetCreditNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var creditNoteId = "creditNoteId_example";  // string | The creditNoteId (primary key of the returned object) is returned as the first field in the GET all credit notes call; not to be confused with creditNoteNumber 

            try
            {
                CreditNoteResult result = apiInstance.GetCreditNote(companySlug, creditNoteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CreditNoteResult> response = apiInstance.GetCreditNoteWithHttpInfo(companySlug, creditNoteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **creditNoteId** | **string** | The creditNoteId (primary key of the returned object) is returned as the first field in the GET all credit notes call; not to be confused with creditNoteNumber  |  |

### Return type

[**CreditNoteResult**](CreditNoteResult.md)

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

<a id="getcreditnotecounter"></a>
# **GetCreditNoteCounter**
> Counter GetCreditNoteCounter (string companySlug)



Retrieves the counter for credit notes if it has been created 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetCreditNoteCounterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve

            try
            {
                Counter result = apiInstance.GetCreditNoteCounter(companySlug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteCounter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteCounterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Counter> response = apiInstance.GetCreditNoteCounterWithHttpInfo(companySlug);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteCounterWithHttpInfo: " + e.Message);
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

<a id="getcreditnotedraft"></a>
# **GetCreditNoteDraft**
> InvoiceishDraftResult GetCreditNoteDraft (string companySlug, long draftId)



Returns credit note draft with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetCreditNoteDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                InvoiceishDraftResult result = apiInstance.GetCreditNoteDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InvoiceishDraftResult> response = apiInstance.GetCreditNoteDraftWithHttpInfo(companySlug, draftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteDraftWithHttpInfo: " + e.Message);
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

<a id="getcreditnotedraftattachments"></a>
# **GetCreditNoteDraftAttachments**
> List&lt;Attachment&gt; GetCreditNoteDraftAttachments (string companySlug, long draftId)



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
    public class GetCreditNoteDraftAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 

            try
            {
                List<Attachment> result = apiInstance.GetCreditNoteDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteDraftAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteDraftAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Attachment>> response = apiInstance.GetCreditNoteDraftAttachmentsWithHttpInfo(companySlug, draftId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteDraftAttachmentsWithHttpInfo: " + e.Message);
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

<a id="getcreditnotedrafts"></a>
# **GetCreditNoteDrafts**
> List&lt;InvoiceishDraftResult&gt; GetCreditNoteDrafts (string companySlug, int page = null, int pageSize = null)



Returns all credit note drafts for given company.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetCreditNoteDraftsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List<InvoiceishDraftResult> result = apiInstance.GetCreditNoteDrafts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteDrafts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNoteDraftsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<InvoiceishDraftResult>> response = apiInstance.GetCreditNoteDraftsWithHttpInfo(companySlug, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteDraftsWithHttpInfo: " + e.Message);
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

<a id="getcreditnotes"></a>
# **GetCreditNotes**
> List&lt;CreditNoteResult&gt; GetCreditNotes (string companySlug, int page = null, int pageSize = null, DateOnly issueDate = null, DateOnly issueDateLe = null, DateOnly issueDateLt = null, DateOnly issueDateGe = null, DateOnly issueDateGt = null, DateOnly lastModified = null, DateOnly lastModifiedLe = null, DateOnly lastModifiedLt = null, DateOnly lastModifiedGe = null, DateOnly lastModifiedGt = null, long customerId = null, bool settled = null, Guid creditNoteDraftUuid = null)



Returns all credit notes for given company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetCreditNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var issueDate = DateOnly.Parse("2013-10-20");  // DateOnly | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var issueDateLe = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var issueDateLt = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var issueDateGe = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var issueDateGt = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModified = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedLe = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedLt = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedGe = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedGt = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var customerId = 789L;  // long | Returns only credit notes sent to specified customer. Must be the contactId provided by a GET contacts call.  (optional) 
            var settled = true;  // bool | When set to true, returns only credit notes that have been settled. Otherwise false returns all credit notes that have not been fully settled.  (optional) 
            var creditNoteDraftUuid = "creditNoteDraftUuid_example";  // Guid | Filter based on the UUID of the credit note draft that was used to create a given invoice. Applies only to \"uavhengig kreditnotaer\". (optional) 

            try
            {
                List<CreditNoteResult> result = apiInstance.GetCreditNotes(companySlug, page, pageSize, issueDate, issueDateLe, issueDateLt, issueDateGe, issueDateGt, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, customerId, settled, creditNoteDraftUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCreditNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CreditNoteResult>> response = apiInstance.GetCreditNotesWithHttpInfo(companySlug, page, pageSize, issueDate, issueDateLe, issueDateLt, issueDateGe, issueDateGt, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, customerId, settled, creditNoteDraftUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.GetCreditNotesWithHttpInfo: " + e.Message);
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
| **issueDate** | **DateOnly** | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **issueDateLe** | **DateOnly** | Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **issueDateLt** | **DateOnly** | Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **issueDateGe** | **DateOnly** | Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **issueDateGt** | **DateOnly** | Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModified** | **DateOnly** | Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedLe** | **DateOnly** | Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedLt** | **DateOnly** | Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedGe** | **DateOnly** | Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedGt** | **DateOnly** | Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **customerId** | **long** | Returns only credit notes sent to specified customer. Must be the contactId provided by a GET contacts call.  | [optional]  |
| **settled** | **bool** | When set to true, returns only credit notes that have been settled. Otherwise false returns all credit notes that have not been fully settled.  | [optional]  |
| **creditNoteDraftUuid** | **Guid** | Filter based on the UUID of the credit note draft that was used to create a given invoice. Applies only to \&quot;uavhengig kreditnotaer\&quot;. | [optional]  |

### Return type

[**List&lt;CreditNoteResult&gt;**](CreditNoteResult.md)

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

<a id="sendcreditnote"></a>
# **SendCreditNote**
> void SendCreditNote (string companySlug, SendCreditNoteRequest sendCreditNoteRequest)



Sends the specified document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class SendCreditNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var sendCreditNoteRequest = new SendCreditNoteRequest(); // SendCreditNoteRequest | 

            try
            {
                apiInstance.SendCreditNote(companySlug, sendCreditNoteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.SendCreditNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendCreditNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SendCreditNoteWithHttpInfo(companySlug, sendCreditNoteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.SendCreditNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **sendCreditNoteRequest** | [**SendCreditNoteRequest**](SendCreditNoteRequest.md) |  |  |

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
| **200** | Sent |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatecreditnotedraft"></a>
# **UpdateCreditNoteDraft**
> void UpdateCreditNoteDraft (string companySlug, long draftId, InvoiceishDraftRequest invoiceishDraftRequest)



Updates credit note draft with provided id. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class UpdateCreditNoteDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var draftId = 789L;  // long | The draftId (primary key of the returned object) is returned in the GET all drafts call. 
            var invoiceishDraftRequest = new InvoiceishDraftRequest(); // InvoiceishDraftRequest | 

            try
            {
                apiInstance.UpdateCreditNoteDraft(companySlug, draftId, invoiceishDraftRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.UpdateCreditNoteDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCreditNoteDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateCreditNoteDraftWithHttpInfo(companySlug, draftId, invoiceishDraftRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditNotesApi.UpdateCreditNoteDraftWithHttpInfo: " + e.Message);
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

