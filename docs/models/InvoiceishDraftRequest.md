# Fiken.Model.InvoiceishDraftRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of draft. | 
**DaysUntilDueDate** | **int** | Days until due date of the invoice draft. | 
**CustomerId** | **long** | customerId &#x3D; contactId where customer &#x3D; true | 
**Uuid** | **string** | UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters. | [optional] 
**IssueDate** | **DateOnly** | Issue date of the invoice draft, format yyyy-mm-dd | [optional] 
**InvoiceText** | **string** | Comment/description printed above the invoice lines. If not present, and standard text is registered, standard text is printed. | [optional] 
**YourReference** | **string** |  | [optional] 
**OurReference** | **string** |  | [optional] 
**OrderReference** | **string** | Reference if sending invoice via EHF. | [optional] 
**Lines** | [**List&lt;InvoiceishDraftLine&gt;**](InvoiceishDraftLine.md) |  | [optional] 
**Currency** | **string** | ISO 4217 currency code | [optional] 
**BankAccountNumber** | **string** |  | [optional] 
**Iban** | **string** |  | [optional] 
**Bic** | **string** |  | [optional] 
**PaymentAccount** | **string** |  | [optional] 
**ContactPersonId** | **long** | Id of the contact person. Must be associated with the provided customer. | [optional] 
**ProjectId** | **long** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

