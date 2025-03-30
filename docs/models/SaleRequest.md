# Fiken.Model.SaleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateOnly** | Date of the invoice, format yyyy-mm-dd | 
**Kind** | **string** | Either cash_sale, invoice, or external_invoice. | 
**Lines** | [**List&lt;OrderLine&gt;**](OrderLine.md) |  | 
**Currency** | **string** | ISO 4217 currency code | 
**SaleNumber** | **string** | Identifier for sale. | [optional] 
**TotalPaid** | **long** | Total amount paid in NOK | [optional] 
**TotalPaidInCurrency** | **long** | Total amount paid in other currency. | [optional] 
**CustomerId** | **long** | customerId &#x3D; contactId where customer &#x3D; true | [optional] 
**DueDate** | **DateOnly** | Due date of the invoice, format yyyy-mm-dd | [optional] 
**Kid** | **string** | Norwegian KID number. Number from 2 to 25 digits long. | [optional] 
**PaymentAccount** | **string** |  | [optional] 
**PaymentDate** | **DateOnly** | Payment date of the invoice, format yyyy-mm-dd | [optional] 
**PaymentFee** | **long** | Fee associated with payment of sale. | [optional] 
**ProjectId** | **long** | Id of given project. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

