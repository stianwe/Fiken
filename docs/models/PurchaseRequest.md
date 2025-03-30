# Fiken.Model.PurchaseRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateOnly** | Payment date, format yyyy-mm-dd | 
**Kind** | **string** | Purchased with cash or through a supplier. | 
**Lines** | [**List&lt;OrderLine&gt;**](OrderLine.md) |  | 
**Currency** | **string** | ISO 4217 currency code | 
**TransactionId** | **long** |  | [optional] [readonly] 
**Identifier** | **string** | Invoice/sale number or similar. | [optional] 
**DueDate** | **DateOnly** | Due date of the invoice, format yyyy-mm-dd | [optional] 
**SupplierId** | **long** | Id of supplier if not a cash purchase. | [optional] 
**PaymentAccount** | **string** |  | [optional] 
**PaymentDate** | **DateOnly** | Payment date, format yyyy-mm-dd | [optional] 
**Kid** | **string** | Norwegian KID number. Number from 2 to 25 digits long. | [optional] 
**ProjectId** | **long** | Id of given project. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

