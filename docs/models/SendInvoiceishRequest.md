# Fiken.Model.SendInvoiceishRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | **List&lt;SendInvoiceishRequest.MethodEnum&gt;** | The method of sending. Has to be auto, email, ehf, efaktura, sms or letter. If several methods are provided they should be in prioritized order as Fiken will only send the invoice to  the first successful available method. Method \&quot;auto\&quot; tries available methods for given customer based on the information registered for the customer. The order of priority is EHF, eFaktura, Sms, and email. Method \&quot;letter\&quot; means physical letter, printed and sent by our postal service partner (extra charge per letter, available for recipient addresses in Norway only). The option \&quot;includeDocumentAttachments\&quot; is not supported by method \&quot;letter\&quot;, attachments are not included even if this option is set.  | 
**IncludeDocumentAttachments** | **bool** | Whether the document&#39;s attachment should be included when sending (True) or not (False). | [default to true]
**RecipientName** | **string** |  | [optional] 
**RecipientEmail** | **string** |  | [optional] 
**Message** | **string** | Additional message to send with document. | [optional] 
**EmailSendOption** | **string** | document_link, attachment or auto. Defaults to auto which uses customer/company settings. | [optional] [default to EmailSendOptionEnum.Auto]
**MergeInvoiceAndAttachments** | **bool** | If sending with emailSendOption &#x3D; attachment, this merges them into a single document if true. | [optional] [default to false]
**OrganizationNumber** | **string** | Brreg organization number. Defaults to the customers organization number if not provided. | [optional] 
**MobileNumber** | **string** | Defaults to the customers phone number. Format should include the country code. If a Norwegian phone number, the country code is not necessary. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

