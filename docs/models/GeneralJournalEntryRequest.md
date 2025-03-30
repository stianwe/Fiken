# Fiken.Model.GeneralJournalEntryRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JournalEntries** | [**List&lt;JournalEntry&gt;**](JournalEntry.md) |  | 
**Description** | **string** | We add the flag &#39;Fri postering registrert via API: &#39;. This must be taken into account in the max length of the description | [optional] 
**Open** | **bool** | The journal entry can be set to either open or closed (closed is the default). In the case of an open journal entry these can be deleted without creating a counter transaction. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

