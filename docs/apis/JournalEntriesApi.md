# Fiken.Api.JournalEntriesApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAttachmentToJournalEntry**](JournalEntriesApi.md#addattachmenttojournalentry) | **POST** /companies/{companySlug}/journalEntries/{journalEntryId}/attachments |  |
| [**CreateGeneralJournalEntry**](JournalEntriesApi.md#creategeneraljournalentry) | **POST** /companies/{companySlug}/generalJournalEntries |  |
| [**GetJournalEntries**](JournalEntriesApi.md#getjournalentries) | **GET** /companies/{companySlug}/journalEntries |  |
| [**GetJournalEntry**](JournalEntriesApi.md#getjournalentry) | **GET** /companies/{companySlug}/journalEntries/{journalEntryId} |  |
| [**GetJournalEntryAttachments**](JournalEntriesApi.md#getjournalentryattachments) | **GET** /companies/{companySlug}/journalEntries/{journalEntryId}/attachments |  |

<a id="addattachmenttojournalentry"></a>
# **AddAttachmentToJournalEntry**
> void AddAttachmentToJournalEntry (string companySlug, long journalEntryId, string filename = null, System.IO.Stream file = null)



Creates and adds a new attachment to a Journal Entry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class AddAttachmentToJournalEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JournalEntriesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var journalEntryId = 789L;  // long | 
            var filename = "filename_example";  // string | Required. The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                apiInstance.AddAttachmentToJournalEntry(companySlug, journalEntryId, filename, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalEntriesApi.AddAttachmentToJournalEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAttachmentToJournalEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddAttachmentToJournalEntryWithHttpInfo(companySlug, journalEntryId, filename, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalEntriesApi.AddAttachmentToJournalEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **journalEntryId** | **long** |  |  |
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

<a id="creategeneraljournalentry"></a>
# **CreateGeneralJournalEntry**
> void CreateGeneralJournalEntry (string companySlug, GeneralJournalEntryRequest generalJournalEntryRequest)



Creates a new general journal entry (fri postering).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateGeneralJournalEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JournalEntriesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var generalJournalEntryRequest = new GeneralJournalEntryRequest(); // GeneralJournalEntryRequest | 

            try
            {
                apiInstance.CreateGeneralJournalEntry(companySlug, generalJournalEntryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalEntriesApi.CreateGeneralJournalEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGeneralJournalEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateGeneralJournalEntryWithHttpInfo(companySlug, generalJournalEntryRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalEntriesApi.CreateGeneralJournalEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **generalJournalEntryRequest** | [**GeneralJournalEntryRequest**](GeneralJournalEntryRequest.md) |  |  |

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

<a id="getjournalentries"></a>
# **GetJournalEntries**
> List&lt;JournalEntry&gt; GetJournalEntries (string companySlug, int page = null, int pageSize = null, DateOnly date = null, DateOnly dateLe = null, DateOnly dateLt = null, DateOnly dateGe = null, DateOnly dateGt = null, DateOnly lastModified = null, DateOnly lastModifiedLe = null, DateOnly lastModifiedLt = null, DateOnly lastModifiedGe = null, DateOnly lastModifiedGt = null, DateOnly createdDate = null, DateOnly createdDateLe = null, DateOnly createdDateLt = null, DateOnly createdDateGe = null, DateOnly createdDateGt = null)



Returns all general journal entries (posteringer) for the specified company.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetJournalEntriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JournalEntriesApi(config);
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
            var createdDate = DateOnly.Parse("2013-10-20");  // DateOnly | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var createdDateLe = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that were created before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var createdDateLt = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that were created strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var createdDateGe = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that were created after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var createdDateGt = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that were created strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 

            try
            {
                List<JournalEntry> result = apiInstance.GetJournalEntries(companySlug, page, pageSize, date, dateLe, dateLt, dateGe, dateGt, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, createdDate, createdDateLe, createdDateLt, createdDateGe, createdDateGt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalEntriesApi.GetJournalEntries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJournalEntriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<JournalEntry>> response = apiInstance.GetJournalEntriesWithHttpInfo(companySlug, page, pageSize, date, dateLe, dateLt, dateGe, dateGt, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, createdDate, createdDateLe, createdDateLt, createdDateGe, createdDateGt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalEntriesApi.GetJournalEntriesWithHttpInfo: " + e.Message);
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
| **createdDate** | **DateOnly** | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **createdDateLe** | **DateOnly** | Returns results that were created before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **createdDateLt** | **DateOnly** | Returns results that were created strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **createdDateGe** | **DateOnly** | Returns results that were created after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **createdDateGt** | **DateOnly** | Returns results that were created strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |

### Return type

[**List&lt;JournalEntry&gt;**](JournalEntry.md)

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

<a id="getjournalentry"></a>
# **GetJournalEntry**
> JournalEntry GetJournalEntry (string companySlug, long journalEntryId)



Returns all journal entries within a given company's Journal Entry Service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetJournalEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JournalEntriesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var journalEntryId = 789L;  // long | 

            try
            {
                JournalEntry result = apiInstance.GetJournalEntry(companySlug, journalEntryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalEntriesApi.GetJournalEntry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJournalEntryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JournalEntry> response = apiInstance.GetJournalEntryWithHttpInfo(companySlug, journalEntryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalEntriesApi.GetJournalEntryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **journalEntryId** | **long** |  |  |

### Return type

[**JournalEntry**](JournalEntry.md)

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

<a id="getjournalentryattachments"></a>
# **GetJournalEntryAttachments**
> List&lt;Attachment&gt; GetJournalEntryAttachments (string companySlug, long journalEntryId)



Returns all attachments for a given Journal Entry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetJournalEntryAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JournalEntriesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var journalEntryId = 789L;  // long | 

            try
            {
                List<Attachment> result = apiInstance.GetJournalEntryAttachments(companySlug, journalEntryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalEntriesApi.GetJournalEntryAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJournalEntryAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Attachment>> response = apiInstance.GetJournalEntryAttachmentsWithHttpInfo(companySlug, journalEntryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalEntriesApi.GetJournalEntryAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **journalEntryId** | **long** |  |  |

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

