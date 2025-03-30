# Fiken.Model.PurchaseResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateOnly** | Payment date, format yyyy-mm-dd | 
**Kind** | **string** | Purchased with cash or through a supplier. | 
**Paid** | **bool** |  | 
**Lines** | [**List&lt;OrderLine&gt;**](OrderLine.md) |  | 
**Currency** | **string** | ISO 4217 currency code | 
**PurchaseId** | **long** | Id of given purchase. | [optional] [readonly] 
**TransactionId** | **long** |  | [optional] [readonly] 
**Identifier** | **string** | Invoice/sale number or similar. | [optional] 
**DueDate** | **DateOnly** | Due date of the invoice, format yyyy-mm-dd | [optional] 
**Supplier** | [**Contact**](Contact.md) |  | [optional] 
**PaymentAccount** | **string** |  | [optional] 
**PaymentDate** | **DateOnly** | Payment date, format yyyy-mm-dd | [optional] 
**Payments** | [**List&lt;Payment&gt;**](Payment.md) |  | [optional] 
**PurchaseAttachments** | [**List&lt;Attachment&gt;**](Attachment.md) |  | [optional] 
**Kid** | **string** | Norwegian KID number. Number from 2 to 25 digits long. | [optional] 
**Project** | [**List&lt;ProjectResult&gt;**](ProjectResult.md) |  | [optional] 
**Deleted** | **bool** | Whether the purchase has been deleted or not | [optional] 
**Settled** | **bool** | If the purchase as been marked as settled (True) or not (False). | [optional] 
**SettledDate** | **DateOnly** | Date the the purchase was marked as settled, format yyyy-mm-dd | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

