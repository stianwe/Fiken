# Fiken.Api.ContactsApi

All URIs are relative to *https://api.fiken.no/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAttachmentToContact**](ContactsApi.md#addattachmenttocontact) | **POST** /companies/{companySlug}/contacts/{contactId}/attachments |  |
| [**AddContactPersonToContact**](ContactsApi.md#addcontactpersontocontact) | **POST** /companies/{companySlug}/contacts/{contactId}/contactPerson |  |
| [**CreateContact**](ContactsApi.md#createcontact) | **POST** /companies/{companySlug}/contacts |  |
| [**DeleteContact**](ContactsApi.md#deletecontact) | **DELETE** /companies/{companySlug}/contacts/{contactId} |  |
| [**DeleteContactContactPerson**](ContactsApi.md#deletecontactcontactperson) | **DELETE** /companies/{companySlug}/contacts/{contactId}/contactPerson/{contactPersonId} |  |
| [**GetContact**](ContactsApi.md#getcontact) | **GET** /companies/{companySlug}/contacts/{contactId} |  |
| [**GetContactContactPerson**](ContactsApi.md#getcontactcontactperson) | **GET** /companies/{companySlug}/contacts/{contactId}/contactPerson |  |
| [**GetContactPerson**](ContactsApi.md#getcontactperson) | **GET** /companies/{companySlug}/contacts/{contactId}/contactPerson/{contactPersonId} |  |
| [**GetContacts**](ContactsApi.md#getcontacts) | **GET** /companies/{companySlug}/contacts |  |
| [**UpdateContact**](ContactsApi.md#updatecontact) | **PUT** /companies/{companySlug}/contacts/{contactId} |  |
| [**UpdateContactContactPerson**](ContactsApi.md#updatecontactcontactperson) | **PUT** /companies/{companySlug}/contacts/{contactId}/contactPerson/{contactPersonId} |  |

<a id="addattachmenttocontact"></a>
# **AddAttachmentToContact**
> void AddAttachmentToContact (string companySlug, long contactId, string filename = null, string comment = null, System.IO.Stream file = null)



Creates and adds a new attachment/document to a contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class AddAttachmentToContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var contactId = 789L;  // long | 
            var filename = "filename_example";  // string | Required. The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf (optional) 
            var comment = "comment_example";  // string | Not required. (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                apiInstance.AddAttachmentToContact(companySlug, contactId, filename, comment, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.AddAttachmentToContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAttachmentToContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddAttachmentToContactWithHttpInfo(companySlug, contactId, filename, comment, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.AddAttachmentToContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **contactId** | **long** |  |  |
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

<a id="addcontactpersontocontact"></a>
# **AddContactPersonToContact**
> void AddContactPersonToContact (string companySlug, long contactId, ContactPerson contactPerson)



Adds a new contact person to a contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class AddContactPersonToContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var contactId = 789L;  // long | 
            var contactPerson = new ContactPerson(); // ContactPerson | 

            try
            {
                apiInstance.AddContactPersonToContact(companySlug, contactId, contactPerson);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.AddContactPersonToContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddContactPersonToContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddContactPersonToContactWithHttpInfo(companySlug, contactId, contactPerson);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.AddContactPersonToContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **contactId** | **long** |  |  |
| **contactPerson** | [**ContactPerson**](ContactPerson.md) |  |  |

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
| **200** | Created |  * Location - Full URL of updated project <br>  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createcontact"></a>
# **CreateContact**
> void CreateContact (string companySlug, Contact contact)



Creates a new contact. The Location response header returns the URL of the newly created contact.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class CreateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var contact = new Contact(); // Contact | 

            try
            {
                apiInstance.CreateContact(companySlug, contact);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateContactWithHttpInfo(companySlug, contact);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.CreateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **contact** | [**Contact**](Contact.md) |  |  |

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

<a id="deletecontact"></a>
# **DeleteContact**
> Contact DeleteContact (string companySlug, long contactId)



Deletes the contact if possible (no associated journal entries/sales/invoices/etc). If not possible to delete will set the contact to inactive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class DeleteContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var contactId = 789L;  // long | 

            try
            {
                Contact result = apiInstance.DeleteContact(companySlug, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Contact> response = apiInstance.DeleteContactWithHttpInfo(companySlug, contactId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.DeleteContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **contactId** | **long** |  |  |

### Return type

[**Contact**](Contact.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Contact deleted successfully. |  -  |
| **200** | Contact set to inactive because it has associated journal entries/sales/invoices/etc. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecontactcontactperson"></a>
# **DeleteContactContactPerson**
> void DeleteContactContactPerson (string companySlug, long contactId, long contactPersonId)



Delete a contact's contact person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class DeleteContactContactPersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var contactId = 789L;  // long | 
            var contactPersonId = 789L;  // long | 

            try
            {
                apiInstance.DeleteContactContactPerson(companySlug, contactId, contactPersonId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteContactContactPerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactContactPersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteContactContactPersonWithHttpInfo(companySlug, contactId, contactPersonId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.DeleteContactContactPersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **contactId** | **long** |  |  |
| **contactPersonId** | **long** |  |  |

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

<a id="getcontact"></a>
# **GetContact**
> Contact GetContact (string companySlug, long contactId)



Retrieves specified contact. ContactId is returned with a GET contacts call as the first returned field. ContactId is returned in the Location response header for POST contact. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var contactId = 789L;  // long | 

            try
            {
                Contact result = apiInstance.GetContact(companySlug, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Contact> response = apiInstance.GetContactWithHttpInfo(companySlug, contactId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.GetContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **contactId** | **long** |  |  |

### Return type

[**Contact**](Contact.md)

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

<a id="getcontactcontactperson"></a>
# **GetContactContactPerson**
> List&lt;ContactPerson&gt; GetContactContactPerson (string companySlug, long contactId)



Retrieves contact person(s) for a specified contact. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetContactContactPersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var contactId = 789L;  // long | 

            try
            {
                List<ContactPerson> result = apiInstance.GetContactContactPerson(companySlug, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactContactPerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactContactPersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ContactPerson>> response = apiInstance.GetContactContactPersonWithHttpInfo(companySlug, contactId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.GetContactContactPersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **contactId** | **long** |  |  |

### Return type

[**List&lt;ContactPerson&gt;**](ContactPerson.md)

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

<a id="getcontactperson"></a>
# **GetContactPerson**
> ContactPerson GetContactPerson (string companySlug, long contactId, long contactPersonId)



Retrieves specified contact person 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetContactPersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var contactId = 789L;  // long | 
            var contactPersonId = 789L;  // long | 

            try
            {
                ContactPerson result = apiInstance.GetContactPerson(companySlug, contactId, contactPersonId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactPerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactPersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContactPerson> response = apiInstance.GetContactPersonWithHttpInfo(companySlug, contactId, contactPersonId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.GetContactPersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **contactId** | **long** |  |  |
| **contactPersonId** | **long** |  |  |

### Return type

[**ContactPerson**](ContactPerson.md)

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

<a id="getcontacts"></a>
# **GetContacts**
> List&lt;Contact&gt; GetContacts (string companySlug, int page = null, int pageSize = null, DateOnly lastModified = null, DateOnly lastModifiedLe = null, DateOnly lastModifiedLt = null, DateOnly lastModifiedGe = null, DateOnly lastModifiedGt = null, DateOnly createdDate = null, DateOnly createdDateLe = null, DateOnly createdDateLt = null, DateOnly createdDateGe = null, DateOnly createdDateGt = null, int supplierNumber = null, int customerNumber = null, int memberNumber = null, string memberNumberString = null, string name = null, string organizationNumber = null, string email = null, bool customer = null, bool supplier = null, bool inactive = null, string group = null, string sortBy = null, string phoneNumber = null)



Retrieves all contacts for the specified company.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class GetContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var page = 0;  // int | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 25;  // int | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
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
            var supplierNumber = 56;  // int | Find all results with the supplier number equal to the specified parameter. (optional) 
            var customerNumber = 56;  // int | Find all results with the customer number equal to the specified parameter. (optional) 
            var memberNumber = 56;  // int | Find all results with the member number equal to the specified parameter. (optional) 
            var memberNumberString = "memberNumberString_example";  // string | Find all results with the member number equal to the specified parameter. (optional) 
            var name = "name_example";  // string | Find all results with the name equal to the specified parameter. (optional) 
            var organizationNumber = "organizationNumber_example";  // string | Find all results with the organization number equal to the specified parameter. (optional) 
            var email = "email_example";  // string | Find all results with the email equal to the specified parameter. (optional) 
            var customer = true;  // bool | Returns all contacts that are customers. If filter is set for both supplier and customer = true, only contacts that are both supplier and customer will be returned. (optional) 
            var supplier = true;  // bool | Returns all contacts that are suppliers. If filter is set for both supplier and customer = true, only contacts that are both supplier and customer will be returned. (optional) 
            var inactive = true;  // bool | Return all active contacts (false) or all inactive contacts (true). (optional) 
            var group = "group_example";  // string | Return contacts in contact group, exact match only. Groups are only used for customers, not suppliers. (optional) 
            var sortBy = "lastModified asc";  // string |  (optional)  (default to createdDate asc)
            var phoneNumber = "phoneNumber_example";  // string | Find all results with the phone number equal to the specified parameter. (optional) 

            try
            {
                List<Contact> result = apiInstance.GetContacts(companySlug, page, pageSize, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, createdDate, createdDateLe, createdDateLt, createdDateGe, createdDateGt, supplierNumber, customerNumber, memberNumber, memberNumberString, name, organizationNumber, email, customer, supplier, inactive, group, sortBy, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Contact>> response = apiInstance.GetContactsWithHttpInfo(companySlug, page, pageSize, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, createdDate, createdDateLe, createdDateLt, createdDateGe, createdDateGt, supplierNumber, customerNumber, memberNumber, memberNumberString, name, organizationNumber, email, customer, supplier, inactive, group, sortBy, phoneNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.GetContactsWithHttpInfo: " + e.Message);
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
| **supplierNumber** | **int** | Find all results with the supplier number equal to the specified parameter. | [optional]  |
| **customerNumber** | **int** | Find all results with the customer number equal to the specified parameter. | [optional]  |
| **memberNumber** | **int** | Find all results with the member number equal to the specified parameter. | [optional]  |
| **memberNumberString** | **string** | Find all results with the member number equal to the specified parameter. | [optional]  |
| **name** | **string** | Find all results with the name equal to the specified parameter. | [optional]  |
| **organizationNumber** | **string** | Find all results with the organization number equal to the specified parameter. | [optional]  |
| **email** | **string** | Find all results with the email equal to the specified parameter. | [optional]  |
| **customer** | **bool** | Returns all contacts that are customers. If filter is set for both supplier and customer &#x3D; true, only contacts that are both supplier and customer will be returned. | [optional]  |
| **supplier** | **bool** | Returns all contacts that are suppliers. If filter is set for both supplier and customer &#x3D; true, only contacts that are both supplier and customer will be returned. | [optional]  |
| **inactive** | **bool** | Return all active contacts (false) or all inactive contacts (true). | [optional]  |
| **group** | **string** | Return contacts in contact group, exact match only. Groups are only used for customers, not suppliers. | [optional]  |
| **sortBy** | **string** |  | [optional] [default to createdDate asc] |
| **phoneNumber** | **string** | Find all results with the phone number equal to the specified parameter. | [optional]  |

### Return type

[**List&lt;Contact&gt;**](Contact.md)

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

<a id="updatecontact"></a>
# **UpdateContact**
> void UpdateContact (string companySlug, long contactId, Contact contact)



Updates an existing contact.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class UpdateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var contactId = 789L;  // long | 
            var contact = new Contact(); // Contact | 

            try
            {
                apiInstance.UpdateContact(companySlug, contactId, contact);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateContactWithHttpInfo(companySlug, contactId, contact);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.UpdateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **contactId** | **long** |  |  |
| **contact** | [**Contact**](Contact.md) |  |  |

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

<a id="updatecontactcontactperson"></a>
# **UpdateContactContactPerson**
> void UpdateContactContactPerson (string companySlug, long contactId, long contactPersonId, ContactPerson contactPerson)



Updates an existing contact person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Fiken.Api;
using Fiken.Client;
using Fiken.Model;

namespace Example
{
    public class UpdateContactContactPersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.fiken.no/api/v2";
            // Configure OAuth2 access token for authorization: fiken_api_oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var companySlug = "companySlug_example";  // string | Slug of company to retrieve
            var contactId = 789L;  // long | 
            var contactPersonId = 789L;  // long | 
            var contactPerson = new ContactPerson(); // ContactPerson | 

            try
            {
                apiInstance.UpdateContactContactPerson(companySlug, contactId, contactPersonId, contactPerson);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateContactContactPerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateContactContactPersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateContactContactPersonWithHttpInfo(companySlug, contactId, contactPersonId, contactPerson);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.UpdateContactContactPersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **companySlug** | **string** | Slug of company to retrieve |  |
| **contactId** | **long** |  |  |
| **contactPersonId** | **long** |  |  |
| **contactPerson** | [**ContactPerson**](ContactPerson.md) |  |  |

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

