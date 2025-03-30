# Fiken.Model.JournalEntryLine

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **long** | This will be the net amount (excluding VAT) for debitAccount lines and gross amount  (including VAT) for creditAccount lines. The reason for this difference is due to the  way Fiken calculates VAT based on the debitVatCode and creditVatCode.  | 
**Account** | **string** |  | [optional] [readonly] 
**VatCode** | **string** |  | [optional] [readonly] 
**DebitAccount** | **string** |  | [optional] 
**DebitVatCode** | **long** |  | [optional] 
**CreditAccount** | **string** |  | [optional] 
**CreditVatCode** | **long** |  | [optional] 
**ProjectId** | **List&lt;long&gt;** |  | [optional] [readonly] 
**LastModifiedDate** | **DateOnly** | Date that journal entry line was last modified in Fiken, format yyyy-mm-dd. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

