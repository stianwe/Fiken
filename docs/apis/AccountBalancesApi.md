# Fiken.Api.AccountBalancesApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccountBalance**](AccountBalancesApi.md#getaccountbalance) | **GET** /companies/{companySlug}/accountBalances/{accountCode} |  |
| [**GetAccountBalances**](AccountBalancesApi.md#getaccountbalances) | **GET** /companies/{companySlug}/accountBalances |  |

<a id="getaccountbalance"></a>
# **GetAccountBalance**
> AccountBalance GetAccountBalance (string companySlug, string accountCode, DateOnly date)



Retrieves the specified bookkeping account and balance for a given date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetAccountBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountBalancesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var accountCode = "accountCode_example";  // string | Code number of the bookkeeping account to retrieve
            var date = DateOnly.Parse("2013-10-20");  // DateOnly | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\" 

            try
            {
                AccountBalance result = apiInstance.GetAccountBalance(companySlug, accountCode, date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountBalancesApi.GetAccountBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountBalance> response = apiInstance.GetAccountBalanceWithHttpInfo(companySlug, accountCode, date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountBalancesApi.GetAccountBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **accountCode** | **string** | Code number of the bookkeeping account to retrieve |  |
| **date** | **DateOnly** | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  |  |

### Return type

[**AccountBalance**](AccountBalance.md)

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

<a id="getaccountbalances"></a>
# **GetAccountBalances**
> List&lt;AccountBalance&gt; GetAccountBalances (string companySlug, DateOnly date, long fromAccount = null, long toAccount = null, int page = null, int pageSize = null)



Retrieves the bookkeeping accounts and closing balances for a given date. An account is a string with either four digits, or four digits, a colon and five digits (\"reskontro\"). Examples: 3020 and 1500:10001 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetAccountBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountBalancesApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var date = DateOnly.Parse("2013-10-20");  // DateOnly | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\" 
            var fromAccount = 1000;  // long | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). (optional) 
            var toAccount = 2000;  // long | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). (optional) 
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List<AccountBalance> result = apiInstance.GetAccountBalances(companySlug, date, fromAccount, toAccount, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountBalancesApi.GetAccountBalances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountBalancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AccountBalance>> response = apiInstance.GetAccountBalancesWithHttpInfo(companySlug, date, fromAccount, toAccount, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountBalancesApi.GetAccountBalancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **date** | **DateOnly** | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  |  |
| **fromAccount** | **long** | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). | [optional]  |
| **toAccount** | **long** | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). | [optional]  |
| **page** | **int** | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  | [optional] [default to 0] |
| **pageSize** | **int** | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  | [optional] [default to 25] |

### Return type

[**List&lt;AccountBalance&gt;**](AccountBalance.md)

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

