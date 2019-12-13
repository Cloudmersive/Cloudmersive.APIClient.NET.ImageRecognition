# Cloudmersive.APIClient.NET.ImageRecognition.Api.RecognizeApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RecognizeDescribe**](RecognizeApi.md#recognizedescribe) | **POST** /image/recognize/describe | Describe an image in natural language
[**RecognizeDetectAndUnskewDocument**](RecognizeApi.md#recognizedetectandunskewdocument) | **POST** /image/recognize/detect-document/unskew | Detect and unskew a photo of a document
[**RecognizeDetectObjects**](RecognizeApi.md#recognizedetectobjects) | **POST** /image/recognize/detect-objects | Detect objects including types and locations in an image
[**RecognizeDetectPeople**](RecognizeApi.md#recognizedetectpeople) | **POST** /image/recognize/detect-people | Detect people including locations in an image
[**RecognizeDetectTextFine**](RecognizeApi.md#recognizedetecttextfine) | **POST** /image/recognize/detect-text/fine | Detect fine text in a photo of a document
[**RecognizeDetectTextLarge**](RecognizeApi.md#recognizedetecttextlarge) | **POST** /image/recognize/detect-text/large | Detect large text in a photo
[**RecognizeDetectVehicleLicensePlates**](RecognizeApi.md#recognizedetectvehiclelicenseplates) | **POST** /image/recognize/detect-vehicle-license-plates | Detect vehicle license plates in an image
[**RecognizeFindSymbol**](RecognizeApi.md#recognizefindsymbol) | **POST** /image/recognize/find/symbol | Find the location of a symbol in an image


<a name="recognizedescribe"></a>
# **RecognizeDescribe**
> ImageDescriptionResponse RecognizeDescribe (System.IO.Stream imageFile)

Describe an image in natural language

Generate an English language text description of the image as a sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class RecognizeDescribeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Describe an image in natural language
                ImageDescriptionResponse result = apiInstance.RecognizeDescribe(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.RecognizeDescribe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageFile** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 

### Return type

[**ImageDescriptionResponse**](ImageDescriptionResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recognizedetectandunskewdocument"></a>
# **RecognizeDetectAndUnskewDocument**
> byte[] RecognizeDetectAndUnskewDocument (System.IO.Stream imageFile, string postProcessingEffect = null)

Detect and unskew a photo of a document

Detect and unskew a photo of a document (e.g. taken on a cell phone) into a perfectly square image.  Great for document scanning applications; once unskewed, this image is perfect for converting to PDF using the Convert API or optical character recognition using the OCR API.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class RecognizeDetectAndUnskewDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.
            var postProcessingEffect = postProcessingEffect_example;  // string | Optional, post-processing effects to apply to the email, default is None.  Possible values are None and BlackAndWhite (force the image into a black and white view to aid in OCR operations). (optional) 

            try
            {
                // Detect and unskew a photo of a document
                byte[] result = apiInstance.RecognizeDetectAndUnskewDocument(imageFile, postProcessingEffect);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.RecognizeDetectAndUnskewDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageFile** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 
 **postProcessingEffect** | **string**| Optional, post-processing effects to apply to the email, default is None.  Possible values are None and BlackAndWhite (force the image into a black and white view to aid in OCR operations). | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recognizedetectobjects"></a>
# **RecognizeDetectObjects**
> ObjectDetectionResult RecognizeDetectObjects (System.IO.Stream imageFile)

Detect objects including types and locations in an image

Identify the position, size and description of objects in an image, along with a recognition confidence level.  Detects both human people and objects in an image.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class RecognizeDetectObjectsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect objects including types and locations in an image
                ObjectDetectionResult result = apiInstance.RecognizeDetectObjects(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.RecognizeDetectObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageFile** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 

### Return type

[**ObjectDetectionResult**](ObjectDetectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recognizedetectpeople"></a>
# **RecognizeDetectPeople**
> ObjectDetectionResult RecognizeDetectPeople (System.IO.Stream imageFile)

Detect people including locations in an image

Identify the position, and size of human people in an image, along with a recognition confidence level.  People in the image do NOT need to be facing the camera; they can be facing away, edge-on, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class RecognizeDetectPeopleExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect people including locations in an image
                ObjectDetectionResult result = apiInstance.RecognizeDetectPeople(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.RecognizeDetectPeople: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageFile** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 

### Return type

[**ObjectDetectionResult**](ObjectDetectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recognizedetecttextfine"></a>
# **RecognizeDetectTextFine**
> FineTextDetectionResult RecognizeDetectTextFine (System.IO.Stream imageFile)

Detect fine text in a photo of a document

Identify the position, and size of small/fine text within a photograph of a document.  Identify the location of small text in a photo - such as words and other forms of high density text.  Can be used on a scan of a document or a photograph (e.g. smartphone camera) of a document, page or receipt.  For OCR purposes - please see our Deep Learning OCR APIs.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class RecognizeDetectTextFineExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect fine text in a photo of a document
                FineTextDetectionResult result = apiInstance.RecognizeDetectTextFine(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.RecognizeDetectTextFine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageFile** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 

### Return type

[**FineTextDetectionResult**](FineTextDetectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recognizedetecttextlarge"></a>
# **RecognizeDetectTextLarge**
> TextDetectionResult RecognizeDetectTextLarge (System.IO.Stream imageFile)

Detect large text in a photo

Identify the position, and size of large text within a photograph.  Identify the location of large text in a photo - such as signs, titles, etc. and other forms of large, low-density text.  Not suitable for high-density text (e.g. scans of documents, receipts, etc.) for OCR purposes - for OCR, please see our Deep Learning OCR APIs.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class RecognizeDetectTextLargeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect large text in a photo
                TextDetectionResult result = apiInstance.RecognizeDetectTextLarge(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.RecognizeDetectTextLarge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageFile** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 

### Return type

[**TextDetectionResult**](TextDetectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recognizedetectvehiclelicenseplates"></a>
# **RecognizeDetectVehicleLicensePlates**
> VehicleLicensePlateDetectionResult RecognizeDetectVehicleLicensePlates (System.IO.Stream imageFile)

Detect vehicle license plates in an image

Identify the position, and size, and content of vehicle license plates in an image.  License plates should be within 15-20 degrees on-axis to the camera.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class RecognizeDetectVehicleLicensePlatesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect vehicle license plates in an image
                VehicleLicensePlateDetectionResult result = apiInstance.RecognizeDetectVehicleLicensePlates(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.RecognizeDetectVehicleLicensePlates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageFile** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 

### Return type

[**VehicleLicensePlateDetectionResult**](VehicleLicensePlateDetectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recognizefindsymbol"></a>
# **RecognizeFindSymbol**
> FindSymbolResult RecognizeFindSymbol (System.IO.Stream inputImage, System.IO.Stream targetImage)

Find the location of a symbol in an image

Determine if an image contains a symbol, and if so, the location of that symbol in the image.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class RecognizeFindSymbolExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RecognizeApi();
            var inputImage = new System.IO.Stream(); // System.IO.Stream | Image file to search through for the target image.
            var targetImage = new System.IO.Stream(); // System.IO.Stream | Image to find in the input image.

            try
            {
                // Find the location of a symbol in an image
                FindSymbolResult result = apiInstance.RecognizeFindSymbol(inputImage, targetImage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.RecognizeFindSymbol: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputImage** | **System.IO.Stream**| Image file to search through for the target image. | 
 **targetImage** | **System.IO.Stream**| Image to find in the input image. | 

### Return type

[**FindSymbolResult**](FindSymbolResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

