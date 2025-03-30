# Fiken.Model.Contact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**ContactId** | **long** |  | [optional] [readonly] 
**CreatedDate** | **DateOnly** | Date that contact was created in Fiken, format yyyy-mm-dd. | [optional] [readonly] 
**LastModifiedDate** | **DateOnly** | Date that contact was last modified in Fiken, format yyyy-mm-dd. | [optional] [readonly] 
**Email** | **string** |  | [optional] 
**OrganizationNumber** | **string** | Brreg organization number. | [optional] 
**CustomerNumber** | **int** |  | [optional] [readonly] 
**CustomerAccountCode** | **string** | Format 1500:XXXXX | [optional] [readonly] 
**PhoneNumber** | **string** |  | [optional] 
**MemberNumber** | **decimal** | A number that can be used to connect a contact to your own data. This field is no longer used and instead memberNumberString should be used. | [optional] 
**MemberNumberString** | **string** | A number/id that can be used to connect a contact to your own data. | [optional] 
**SupplierNumber** | **int** |  | [optional] [readonly] 
**SupplierAccountCode** | **string** | Format 2400:XXXXX | [optional] [readonly] 
**Customer** | **bool** | True if the contact is a customer. It is possible for a contact to be both customer and supplier. | [optional] [default to false]
**Supplier** | **bool** | True if the contact is a supplier. It is possible for a contact to be both supplier and customer. | [optional] [default to false]
**BankAccountNumber** | **string** |  | [optional] 
**ContactPerson** | [**List&lt;ContactPerson&gt;**](ContactPerson.md) |  | [optional] 
**Notes** | [**List&lt;ContactNote&gt;**](ContactNote.md) |  | [optional] [readonly] 
**Currency** | **string** | ISO 4217 currency code. Default foreign currency to use when creating invoice to this contact (USD, EUR, SEK etc) | [optional] 
**Language** | **string** | The language to use when sending documents to this contact. NORWEGIAN or ENGLISH. Defaults to NORWEGIAN. | [optional] 
**Inactive** | **bool** | Whether the contact has been deactivated (true) or is active (false) | [optional] 
**DaysUntilInvoicingDueDate** | **int** | Default number of days until due date for invoices. | [optional] 
**Address** | [**Address**](Address.md) |  | [optional] 
**Groups** | **List&lt;string&gt;** |  | [optional] 
**Documents** | [**List&lt;Attachment&gt;**](Attachment.md) |  | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

