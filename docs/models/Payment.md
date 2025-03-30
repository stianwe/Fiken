# Fiken.Model.Payment
Returns a payment object with additional fields currrencyAmount, currency, and fee if it is a foreign currency payment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateOnly** | Payment date, format yyyy-mm-dd | 
**Account** | **string** | Account associated with payment. | 
**Amount** | **long** | Amount paid in the specified currency. If no currency is provided then currency defaults to \&quot;NOK\&quot;. Formatted in cents (34000 &#x3D; 340.00) | 
**PaymentId** | **long** | Id of given payment. | [optional] [readonly] 
**AmountInNok** | **long** | Attribute of a foreign payment only. Is required if amount is provided in currency other than NOK and should be the actual amount that was received in the bank account. Formatted in cents (500000 &#x3D; 5000.00) | [optional] [readonly] 
**Currency** | **string** | Only specify the currency if other than \&quot;NOK\&quot;, otherwise default currency is \&quot;NOK\&quot;. ISO 4217 currency code | [optional] 
**Fee** | **long** | Any fees additional to the amount paid in the specified currency. This is always a \&quot;NOK\&quot; amount even if the sale currency is a different currency. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

