# Fiken.Api.ProductsApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateProduct**](ProductsApi.md#createproduct) | **POST** /companies/{companySlug}/products |  |
| [**CreateProductSalesReport**](ProductsApi.md#createproductsalesreport) | **POST** /companies/{companySlug}/products/salesReport |  |
| [**DeleteProduct**](ProductsApi.md#deleteproduct) | **DELETE** /companies/{companySlug}/products/{productId} |  |
| [**GetProduct**](ProductsApi.md#getproduct) | **GET** /companies/{companySlug}/products/{productId} |  |
| [**GetProducts**](ProductsApi.md#getproducts) | **GET** /companies/{companySlug}/products |  |
| [**UpdateProduct**](ProductsApi.md#updateproduct) | **PUT** /companies/{companySlug}/products/{productId} |  |

<a id="createproduct"></a>
# **CreateProduct**
> void CreateProduct (string companySlug, Product product)



Creates a new product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var product = new Product(); // Product | 

            try
            {
                apiInstance.CreateProduct(companySlug, product);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.CreateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateProductWithHttpInfo(companySlug, product);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.CreateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **product** | [**Product**](Product.md) |  |  |

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

<a id="createproductsalesreport"></a>
# **CreateProductSalesReport**
> List&lt;ProductSalesReportResult&gt; CreateProductSalesReport (string companySlug, ProductSalesReportRequest productSalesReportRequest)



Creates a report based on provided specifications.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateProductSalesReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var productSalesReportRequest = new ProductSalesReportRequest(); // ProductSalesReportRequest | 

            try
            {
                List<ProductSalesReportResult> result = apiInstance.CreateProductSalesReport(companySlug, productSalesReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.CreateProductSalesReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProductSalesReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ProductSalesReportResult>> response = apiInstance.CreateProductSalesReportWithHttpInfo(companySlug, productSalesReportRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.CreateProductSalesReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **productSalesReportRequest** | [**ProductSalesReportRequest**](ProductSalesReportRequest.md) |  |  |

### Return type

[**List&lt;ProductSalesReportResult&gt;**](ProductSalesReportResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteproduct"></a>
# **DeleteProduct**
> void DeleteProduct (string companySlug, long productId)



Delete product with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class DeleteProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var productId = 789L;  // long | The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber. 

            try
            {
                apiInstance.DeleteProduct(companySlug, productId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteProductWithHttpInfo(companySlug, productId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.DeleteProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **productId** | **long** | The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber.  |  |

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

<a id="getproduct"></a>
# **GetProduct**
> Product GetProduct (string companySlug, long productId)



Returns product with specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var productId = 789L;  // long | The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber. 

            try
            {
                Product result = apiInstance.GetProduct(companySlug, productId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Product> response = apiInstance.GetProductWithHttpInfo(companySlug, productId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.GetProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **productId** | **long** | The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber.  |  |

### Return type

[**Product**](Product.md)

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

<a id="getproducts"></a>
# **GetProducts**
> List&lt;Product&gt; GetProducts (string companySlug, int page = null, int pageSize = null, DateOnly createdDate = null, DateOnly createdDateLe = null, DateOnly createdDateLt = null, DateOnly createdDateGe = null, DateOnly createdDateGt = null, DateOnly lastModified = null, DateOnly lastModifiedLe = null, DateOnly lastModifiedLt = null, DateOnly lastModifiedGe = null, DateOnly lastModifiedGt = null, string name = null, string productNumber = null, bool active = null)



Returns all products for given company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var createdDate = DateOnly.Parse("2013-10-20");  // DateOnly | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var createdDateLe = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that were created before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var createdDateLt = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that were created strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var createdDateGe = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that were created after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var createdDateGt = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that were created strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModified = DateOnly.Parse("2013-10-20");  // DateOnly | Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedLe = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedLt = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedGe = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var lastModifiedGt = DateOnly.Parse("2013-10-20");  // DateOnly | Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional) 
            var name = "name_example";  // string | Find all results with product name equal to the specified parameter. (optional) 
            var productNumber = "productNumber_example";  // string | Find all results with product number (varenummer) equal to the specified parameter. (optional) 
            var active = true;  // bool | Returns active (true) or inactive (false) products. (optional) 

            try
            {
                List<Product> result = apiInstance.GetProducts(companySlug, page, pageSize, createdDate, createdDateLe, createdDateLt, createdDateGe, createdDateGt, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, name, productNumber, active);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Product>> response = apiInstance.GetProductsWithHttpInfo(companySlug, page, pageSize, createdDate, createdDateLe, createdDateLt, createdDateGe, createdDateGt, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, name, productNumber, active);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.GetProductsWithHttpInfo: " + e.Message);
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
| **createdDate** | **DateOnly** | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **createdDateLe** | **DateOnly** | Returns results that were created before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **createdDateLt** | **DateOnly** | Returns results that were created strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **createdDateGe** | **DateOnly** | Returns results that were created after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **createdDateGt** | **DateOnly** | Returns results that were created strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModified** | **DateOnly** | Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedLe** | **DateOnly** | Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedLt** | **DateOnly** | Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedGe** | **DateOnly** | Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **lastModifiedGt** | **DateOnly** | Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]  |
| **name** | **string** | Find all results with product name equal to the specified parameter. | [optional]  |
| **productNumber** | **string** | Find all results with product number (varenummer) equal to the specified parameter. | [optional]  |
| **active** | **bool** | Returns active (true) or inactive (false) products. | [optional]  |

### Return type

[**List&lt;Product&gt;**](Product.md)

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

<a id="updateproduct"></a>
# **UpdateProduct**
> void UpdateProduct (string companySlug, long productId, Product product)



Updates an existing product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class UpdateProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var productId = 789L;  // long | The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber. 
            var product = new Product(); // Product | 

            try
            {
                apiInstance.UpdateProduct(companySlug, productId, product);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateProductWithHttpInfo(companySlug, productId, product);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.UpdateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **productId** | **long** | The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber.  |  |
| **product** | [**Product**](Product.md) |  |  |

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
| **200** | Updated |  * Location - Full URL of updated project <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

