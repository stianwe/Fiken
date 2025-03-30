# Fiken.Api.GroupsApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGroups**](GroupsApi.md#getgroups) | **GET** /companies/{companySlug}/groups |  |

<a id="getgroups"></a>
# **GetGroups**
> List&lt;string&gt; GetGroups (string companySlug, int page = null, int pageSize = null)



Returns all customer groups for given company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List<string> result = apiInstance.GetGroups(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<string>> response = apiInstance.GetGroupsWithHttpInfo(companySlug, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupsWithHttpInfo: " + e.Message);
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

**List<string>**

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

