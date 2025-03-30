# Fiken.Api.InboxApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateInboxDocument**](InboxApi.md#createinboxdocument) | **POST** /companies/{companySlug}/inbox |  |
| [**GetInbox**](InboxApi.md#getinbox) | **GET** /companies/{companySlug}/inbox |  |
| [**GetInboxDocument**](InboxApi.md#getinboxdocument) | **GET** /companies/{companySlug}/inbox/{inboxDocumentId} |  |

<a id="createinboxdocument"></a>
# **CreateInboxDocument**
> void CreateInboxDocument (string companySlug, string name = null, string filename = null, string description = null, System.IO.Stream file = null)



Upload a document to the inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateInboxDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InboxApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var name = "name_example";  // string | The name of the inbox document, usually the same as the filename (optional) 
            var filename = "filename_example";  // string | The filename of the file uploaded (optional) 
            var description = "description_example";  // string | Additional description of the inbox document (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                apiInstance.CreateInboxDocument(companySlug, name, filename, description, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxApi.CreateInboxDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInboxDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateInboxDocumentWithHttpInfo(companySlug, name, filename, description, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxApi.CreateInboxDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **name** | **string** | The name of the inbox document, usually the same as the filename | [optional]  |
| **filename** | **string** | The filename of the file uploaded | [optional]  |
| **description** | **string** | Additional description of the inbox document | [optional]  |
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

<a id="getinbox"></a>
# **GetInbox**
> List&lt;InboxResult&gt; GetInbox (string companySlug, int page = null, int pageSize = null, string sortBy = null, string status = null, string name = null)



Returns the contents of the inbox for given company.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InboxApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var sortBy = "createdDate asc";  // string | Sorts results in either ascending (asc) or descending (desc) order based on the parameter value. (optional)  (default to createdDate desc)
            var status = "all";  // string |  (optional)  (default to all)
            var name = "name_example";  // string | Filter documents based on their name, case-insensitive substring match. (optional) 

            try
            {
                List<InboxResult> result = apiInstance.GetInbox(companySlug, page, pageSize, sortBy, status, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxApi.GetInbox: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInboxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<InboxResult>> response = apiInstance.GetInboxWithHttpInfo(companySlug, page, pageSize, sortBy, status, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxApi.GetInboxWithHttpInfo: " + e.Message);
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
| **sortBy** | **string** | Sorts results in either ascending (asc) or descending (desc) order based on the parameter value. | [optional] [default to createdDate desc] |
| **status** | **string** |  | [optional] [default to all] |
| **name** | **string** | Filter documents based on their name, case-insensitive substring match. | [optional]  |

### Return type

[**List&lt;InboxResult&gt;**](InboxResult.md)

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

<a id="getinboxdocument"></a>
# **GetInboxDocument**
> InboxResult GetInboxDocument (string companySlug, long inboxDocumentId)



Returns the inbox document with specified id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetInboxDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InboxApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var inboxDocumentId = 789L;  // long | 

            try
            {
                InboxResult result = apiInstance.GetInboxDocument(companySlug, inboxDocumentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxApi.GetInboxDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInboxDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InboxResult> response = apiInstance.GetInboxDocumentWithHttpInfo(companySlug, inboxDocumentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxApi.GetInboxDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **inboxDocumentId** | **long** |  |  |

### Return type

[**InboxResult**](InboxResult.md)

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

