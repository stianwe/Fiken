# Fiken.Model.InvoiceishDraftLine

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **decimal** | Number of units to be invoiced. | 
**InvoiceishDraftLineId** | **long** | Unique draft line ID | [optional] 
**LastModifiedDate** | **DateOnly** | Date that the draft line was last modified in Fiken, format yyyy-mm-dd. | [optional] [readonly] 
**ProductId** | **long** | Product to be credited/debited on invoice draft line. | [optional] 
**Description** | **string** | Description of the invoiced product or service. | [optional] 
**UnitPrice** | **long** | Net price per unit in invoice currency (in cents). | [optional] 
**VatType** | **string** | Vat Types for SALES: [NONE, HIGH, MEDIUM, RAW_FISH, LOW, EXEMPT_IMPORT_EXPORT, EXEMPT, OUTSIDE, EXEMPT_REVERSE] Vat Types for PURCHASES: [NONE, HIGH, MEDIUM, RAW_FISH, LOW, HIGH_DIRECT, HIGH_BASIS, MEDIUM_DIRECT, MEDIUM_BASIS, NONE_IMPORT_BASIS, HIGH_FOREIGN_SERVICE_DEDUCTIBLE, HIGH_FOREIGN_SERVICE_NONDEDUCTIBLE, LOW_FOREIGN_SERVICE_DEDUCTIBLE, LOW_FOREIGN_SERVICE_NONDEDUCTIBLE, HIGH_PURCHASE_OF_EMISSIONSTRADING_OR_GOLD_DEDUCTIBLE, HIGH_PURCHASE_OF_EMISSIONSTRADING_OR_GOLD_NONDEDUCTIBLE]  | [optional] 
**Discount** | **decimal** | Percentage discount charged on invoice draft line. Should be a value between 0 and 100. Can be decimal values such as 25.5 | [optional] 
**Comment** | **string** | Additional information to be printed on invoice. | [optional] 
**IncomeAccount** | **string** | Field is similar to vatType, it defaults to the product&#39;s income account. Either the line or the product needs to have an income account set. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

