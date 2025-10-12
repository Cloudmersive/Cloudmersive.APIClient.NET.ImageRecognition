# Cloudmersive.APIClient.NET.ImageRecognition.Api.ResizeApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ResizePost**](ResizeApi.md#resizepost) | **POST** /image/resize/preserveAspectRatio/{maxWidth}/{maxHeight} | Resize an image while preserving aspect ratio
[**ResizeResizeAISuperSampling**](ResizeApi.md#resizeresizeaisupersampling) | **POST** /image/resize/ai/target | Resize an image with AI super sampling
[**ResizeResizeSimple**](ResizeApi.md#resizeresizesimple) | **POST** /image/resize/target/{width}/{height} | Resize an image


<a name="resizepost"></a>
# **ResizePost**
> byte[] ResizePost (int? maxWidth, int? maxHeight, System.IO.Stream imageFile)

Resize an image while preserving aspect ratio

Resize an image to a maximum width and maximum height, while preserving the image's original aspect ratio.  Resize is EXIF-aware.

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
                // Resize an image while preserving aspect ratio
                byte[] result = apiInstance.ResizePost(maxWidth, maxHeight, imageFile);
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

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resizeresizeaisupersampling"></a>
# **ResizeResizeAISuperSampling**
> byte[] ResizeResizeAISuperSampling (System.IO.Stream imageFile)

Resize an image with AI super sampling

Use AI super sampling to resize a small or low resolution image to twice the size.  Input image should be PNG or JPG, and smaller than 200 x 200 pixels (larger images will be resized down).  Consumes 20 API calls.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class ResizeResizeAISuperSamplingExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ResizeApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Resize an image with AI super sampling
                byte[] result = apiInstance.ResizeResizeAISuperSampling(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResizeApi.ResizeResizeAISuperSampling: " + e.Message );
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

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resizeresizesimple"></a>
# **ResizeResizeSimple**
> byte[] ResizeResizeSimple (int? width, int? height, System.IO.Stream imageFile)

Resize an image

Resize an image to a specific width and specific height.  Resize is EXIF-aware.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class ResizeResizeSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ResizeApi();
            var width = 56;  // int? | Width of the output image - final image will be exactly this width
            var height = 56;  // int? | Height of the output image - final image will be exactly this height
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Resize an image
                byte[] result = apiInstance.ResizeResizeSimple(width, height, imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResizeApi.ResizeResizeSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **width** | **int?**| Width of the output image - final image will be exactly this width | 
 **height** | **int?**| Height of the output image - final image will be exactly this height | 
 **imageFile** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

