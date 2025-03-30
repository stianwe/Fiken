# Fiken.Model.SaleResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SaleId** | **long** | Sale Id | [optional] [readonly] 
**LastModifiedDate** | **DateOnly** | Date that the sale was last modified in Fiken, format yyyy-mm-dd. | [optional] [readonly] 
**TransactionId** | **long** |  | [optional] [readonly] 
**SaleNumber** | **string** | Identifier for sale. | [optional] 
**Date** | **DateOnly** | Due date of the invoice, format yyyy-mm-dd | [optional] 
**Kind** | **string** | Either cash_sale, invoice, or external_invoice. | [optional] 
**NetAmount** | **long** | Total net amount of the sale to be paid. | [optional] 
**VatAmount** | **long** | VAT amount on sale. | [optional] 
**Settled** | **bool** | If the sale as been marked as settled (True) or not (False). | [optional] 
**SettledDate** | **DateOnly** | Date the the sale was marked as settled, format yyyy-mm-dd | [optional] 
**WriteOff** | **bool** | If a loss has been registered for this sale (tapsføring av salg). | [optional] 
**TotalPaid** | **long** | Total amount paid in NOK | [optional] [readonly] 
**TotalPaidInCurrency** | **long** | Total amount paid in other currency. | [optional] [readonly] 
**OutstandingBalance** | **long** |  | [optional] 
**OutstandingBalanceInCurrency** | **long** | Outstanding balance in other currency. | [optional] [readonly] 
**Lines** | [**List&lt;OrderLine&gt;**](OrderLine.md) |  | [optional] 
**Customer** | [**Contact**](Contact.md) |  | [optional] 
**Currency** | **string** | ISO 4217 currency code | [optional] 
**DueDate** | **DateOnly** | Due date of the invoice, format yyyy-mm-dd | [optional] 
**Kid** | **string** | Norwegian KID number. Number from 2 to 25 digits long. | [optional] 
**PaymentAccount** | **string** |  | [optional] 
**SalePayments** | [**List&lt;Payment&gt;**](Payment.md) |  | [optional] 
**SaleAttachments** | [**List&lt;Attachment&gt;**](Attachment.md) |  | [optional] 
**PaymentDate** | **DateOnly** | Payment date of the invoice, format yyyy-mm-dd | [optional] [readonly] 
**Project** | [**ProjectResult**](ProjectResult.md) |  | [optional] 
**Notes** | [**List&lt;Note&gt;**](Note.md) |  | [optional] [readonly] 
**Deleted** | **bool** | Whether the sale has been deleted or not | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

