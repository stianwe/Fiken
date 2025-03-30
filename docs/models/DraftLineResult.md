# Fiken.Model.DraftLineResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Description of the sale/purchase line. | [optional] 
**VatType** | **string** | Vat Types for SALES: [NONE, HIGH, MEDIUM, RAW_FISH, LOW, EXEMPT_IMPORT_EXPORT, EXEMPT, OUTSIDE, EXEMPT_REVERSE] Vat Types for PURCHASES: [NONE, HIGH, MEDIUM, RAW_FISH, LOW, HIGH_DIRECT, HIGH_BASIS, MEDIUM_DIRECT, MEDIUM_BASIS, NONE_IMPORT_BASIS, HIGH_FOREIGN_SERVICE_DEDUCTIBLE, HIGH_FOREIGN_SERVICE_NONDEDUCTIBLE, LOW_FOREIGN_SERVICE_DEDUCTIBLE, LOW_FOREIGN_SERVICE_NONDEDUCTIBLE, HIGH_PURCHASE_OF_EMISSIONSTRADING_OR_GOLD_DEDUCTIBLE, HIGH_PURCHASE_OF_EMISSIONSTRADING_OR_GOLD_NONDEDUCTIBLE]  | [optional] 
**IncomeAccount** | **string** | Field is similar to vatType, it defaults to the product&#39;s income account. Either the line or the product needs to have an income account set. | [optional] 
**Net** | **long** | Net amount (in creditNote currency) in cents. | [optional] 
**Gross** | **long** | Gross amount (&#x3D; net+VAT) (in creditNote currency) in cents. | [optional] 
**Project** | [**ProjectResult**](ProjectResult.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

