# Fiken.Model.Offer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **long** | offer ID | [optional] [readonly] 
**OfferDraftUuid** | **string** | UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters. | [optional] [readonly] 
**Date** | **DateOnly** | Date for offer | [optional] 
**OfferNumber** | **int** | Unique offer number generated by us. | [optional] 
**Net** | **long** | Net amount (in invoice currency) in cents. | [optional] 
**Vat** | **long** | VAT amount (in invoice currency) in cents. | [optional] 
**Gross** | **long** | Gross amount (&#x3D; net+VAT) (in invoice currency) in cents. | [optional] 
**Comment** | **string** | Comment/description | [optional] 
**YourReference** | **string** |  | [optional] 
**OurReference** | **string** |  | [optional] 
**OrderReference** | **string** | Reference if sending invoice via EHF. | [optional] 
**Discount** | **decimal** | The discount amount in the specified currency. | [optional] 
**Address** | [**Address**](Address.md) |  | [optional] 
**Lines** | [**List&lt;InvoiceLineResult&gt;**](InvoiceLineResult.md) |  | [optional] 
**Currency** | **string** | ISO 4217 currency code, default value is NOK | [optional] [default to "NOK"]
**ContactId** | **long** | Contact associated with offer. | [optional] 
**ContactPersonId** | **long** | Contact person associated with offer. Must belong to the provided contact. | [optional] 
**ProjectId** | **long** |  | [optional] 
**Archived** | **bool** | If order confirmation has been archived or not. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

