# Fiken.Model.OrderLine

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the product or service. | 
**VatType** | **string** | Vat Types for SALES: [NONE, HIGH, MEDIUM, RAW_FISH, LOW, EXEMPT_IMPORT_EXPORT, EXEMPT, OUTSIDE, EXEMPT_REVERSE] Vat Types for PURCHASES: [NONE, HIGH, MEDIUM, RAW_FISH, LOW, HIGH_DIRECT, HIGH_BASIS, MEDIUM_DIRECT, MEDIUM_BASIS, NONE_IMPORT_BASIS, HIGH_FOREIGN_SERVICE_DEDUCTIBLE, HIGH_FOREIGN_SERVICE_NONDEDUCTIBLE, LOW_FOREIGN_SERVICE_DEDUCTIBLE, LOW_FOREIGN_SERVICE_NONDEDUCTIBLE, HIGH_PURCHASE_OF_EMISSIONSTRADING_OR_GOLD_DEDUCTIBLE, HIGH_PURCHASE_OF_EMISSIONSTRADING_OR_GOLD_NONDEDUCTIBLE]  | 
**NetPrice** | **long** | Net amount of order line in cents. Either netPrice or netPriceInCurrency must be provided. | [optional] 
**Vat** | **long** | VAT amount of order line in cents. | [optional] 
**Account** | **string** | Expense account (kostnadskonto) associated with payment. | [optional] 
**NetPriceInCurrency** | **long** | Net amount in currency (in cents) | [optional] 
**VatInCurrency** | **long** | VAT amount in currency (in cents) | [optional] 
**ProjectId** | **long** | If a purchase is split over several projects, project/line can be specified. This field is only to be used for purchases. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

