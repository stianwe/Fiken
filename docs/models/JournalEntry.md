# Fiken.Model.JournalEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | We add the flag &#39;Fri postering registrert via API: &#39;. This must be taken into account in the max length of the description | 
**Date** | **DateOnly** |  | 
**Lines** | [**List&lt;JournalEntryLine&gt;**](JournalEntryLine.md) |  | 
**JournalEntryId** | **long** |  | [optional] [readonly] 
**CreatedDate** | **DateOnly** | Date that journal entry was created in Fiken, format yyyy-mm-dd | [optional] [readonly] 
**LastModifiedDate** | **DateOnly** | Date that journal entry was last modified in Fiken, format yyyy-mm-dd. | [optional] [readonly] 
**TransactionId** | **long** |  | [optional] [readonly] 
**OffsetTransactionId** | **long** | If a journal entry has been cancelled this provides the id of the balancing transaction | [optional] [readonly] 
**JournalEntryNumber** | **int** |  | [optional] [readonly] 
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) |  | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

