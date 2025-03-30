# Fiken.Api.AccountsApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccount**](AccountsApi.md#getaccount) | **GET** /companies/{companySlug}/accounts/{accountCode} |  |
| [**GetAccounts**](AccountsApi.md#getaccounts) | **GET** /companies/{companySlug}/accounts |  |

<a id="getaccount"></a>
# **GetAccount**
> Account GetAccount (string companySlug, string accountCode)



Retrieves the specified bookkeping account. An account is a string with either four digits, or four digits, a colon and five digits (\"reskontro\").       Examples:       3020 and 1500:10001 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var accountCode = "accountCode_example";  // string | Code number of the bookkeeping account to retrieve for the current year.

            try
            {
                Account result = apiInstance.GetAccount(companySlug, accountCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Account> response = apiInstance.GetAccountWithHttpInfo(companySlug, accountCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.GetAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **accountCode** | **string** | Code number of the bookkeeping account to retrieve for the current year. |  |

### Return type

[**Account**](Account.md)

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

<a id="getaccounts"></a>
# **GetAccounts**
> List&lt;Account&gt; GetAccounts (string companySlug, long fromAccount = null, long toAccount = null, int page = null, int pageSize = null)



Retrieves the bookkeeping accounts for the current year 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var fromAccount = 1000;  // long | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). (optional) 
            var toAccount = 2000;  // long | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). (optional) 
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List<Account> result = apiInstance.GetAccounts(companySlug, fromAccount, toAccount, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Account>> response = apiInstance.GetAccountsWithHttpInfo(companySlug, fromAccount, toAccount, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.GetAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **fromAccount** | **long** | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). | [optional]  |
| **toAccount** | **long** | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). | [optional]  |
| **page** | **int** | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  | [optional] [default to 0] |
| **pageSize** | **int** | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  | [optional] [default to 25] |

### Return type

[**List&lt;Account&gt;**](Account.md)

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

