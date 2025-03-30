# Fiken.Model.Product

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Product name. | 
**IncomeAccount** | **string** | The accounting account that will receive the payment. | 
**VatType** | **string** | One of {\&quot;HIGH\&quot;, \&quot;MEDIUM\&quot;, \&quot;LOW\&quot;, \&quot;EXEMPT\&quot;, \&quot;EXEMPT_IMPORT_EXPORT\&quot;, \&quot;EXEMPT_REVERSE\&quot;, \&quot;OUTSIDE\&quot;, \&quot;NONE\&quot;}. \&quot;HIGH\&quot; is the most common. | 
**ProductId** | **long** | Product Id. | [optional] [readonly] 
**CreatedDate** | **DateOnly** | Date that product was created in Fiken, format yyyy-mm-dd | [optional] [readonly] 
**LastModifiedDate** | **DateOnly** | Date that product was last modified in Fiken, format yyyy-mm-dd. | [optional] [readonly] 
**UnitPrice** | **long** | The net unit price in cents. | [optional] 
**Active** | **bool** | If product is in use (True) or not (False). | [default to true]
**ProductNumber** | **string** |  | [optional] 
**Stock** | **float** | Number of products available in stock. If not provided, stock value is set to null. Decimal values are accepted. For example 5.5 | [optional] 
**Note** | **string** | Optional field for additional information. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

