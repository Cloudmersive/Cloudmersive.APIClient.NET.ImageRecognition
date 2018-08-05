# Cloudmersive.APIClient.NET.ImageRecognition.Api.ResizeApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ResizePost**](ResizeApi.md#resizepost) | **POST** /image/resize/preserveAspectRatio/{maxWidth}/{maxHeight} | Resize an image with parameters


<a name="resizepost"></a>
# **ResizePost**
> Object ResizePost (int? maxWidth, int? maxHeight, System.IO.Stream imageFile)

Resize an image with parameters

Resize an image to a maximum width and maximum height, while preserving the image's original aspect ratio

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class ResizePostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ResizeApi();
            var maxWidth = 56;  // int? | Maximum width of the output image - final image will be as large as possible while less than or equial to this width
            var maxHeight = 56;  // int? | Maximum height of the output image - final image will be as large as possible while less than or equial to this height
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Resize an image with parameters
                Object result = apiInstance.ResizePost(maxWidth, maxHeight, imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResizeApi.ResizePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **maxWidth** | **int?**| Maximum width of the output image - final image will be as large as possible while less than or equial to this width | 
 **maxHeight** | **int?**| Maximum height of the output image - final image will be as large as possible while less than or equial to this height | 
 **imageFile** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

