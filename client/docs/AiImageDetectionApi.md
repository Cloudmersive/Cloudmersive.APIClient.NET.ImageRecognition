# Cloudmersive.APIClient.NET.ImageRecognition.Api.AiImageDetectionApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AiImageDetectionDetectFile**](AiImageDetectionApi.md#aiimagedetectiondetectfile) | **POST** /image/ai-detection/file | Detect if an input image was generated using AI


<a name="aiimagedetectiondetectfile"></a>
# **AiImageDetectionDetectFile**
> ImageAiDetectionResult AiImageDetectionDetectFile (System.IO.Stream imageFile)

Detect if an input image was generated using AI

Detects if the input image was generated using AI tools.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class AiImageDetectionDetectFileExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AiImageDetectionApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect if an input image was generated using AI
                ImageAiDetectionResult result = apiInstance.AiImageDetectionDetectFile(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AiImageDetectionApi.AiImageDetectionDetectFile: " + e.Message );
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

[**ImageAiDetectionResult**](ImageAiDetectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

