# Cloudmersive.APIClient.NET.ImageRecognition.Api.EditApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditCompositeBasic**](EditApi.md#editcompositebasic) | **POST** /image/edit/composite/{location} | Composite two images together
[**EditDrawRectangle**](EditApi.md#editdrawrectangle) | **POST** /image/edit/draw/rectangle | Draw rectangle onto an image
[**EditDrawText**](EditApi.md#editdrawtext) | **POST** /image/edit/draw/text | Draw text onto an image


<a name="editcompositebasic"></a>
# **EditCompositeBasic**
> byte[] EditCompositeBasic (string location, System.IO.Stream baseImage, System.IO.Stream layeredImage)

Composite two images together

Composites two input images together; a layered image onto a base image.  The first image you input is the base image.  The second image (the layered image) will be composited on top of this base image.  Supports PNG transparency.  To control padding you can include transparent pixels at the border(s) of your layered images as appropriate.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class EditCompositeBasicExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditApi();
            var location = location_example;  // string | Location to composite the layered images; possible values are: \"center\", \"top-left\", \"top-center\", \"top-right\", \"center-left\", \"center-right\", \"bottom-left\", \"bottom-center\", \"bottom-right\"
            var baseImage = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.
            var layeredImage = new System.IO.Stream(); // System.IO.Stream | Image to layer on top of the base image.

            try
            {
                // Composite two images together
                byte[] result = apiInstance.EditCompositeBasic(location, baseImage, layeredImage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditApi.EditCompositeBasic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | **string**| Location to composite the layered images; possible values are: \&quot;center\&quot;, \&quot;top-left\&quot;, \&quot;top-center\&quot;, \&quot;top-right\&quot;, \&quot;center-left\&quot;, \&quot;center-right\&quot;, \&quot;bottom-left\&quot;, \&quot;bottom-center\&quot;, \&quot;bottom-right\&quot; | 
 **baseImage** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 
 **layeredImage** | **System.IO.Stream**| Image to layer on top of the base image. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editdrawrectangle"></a>
# **EditDrawRectangle**
> byte[] EditDrawRectangle (DrawRectangleRequest request)

Draw rectangle onto an image

Draw one or more rectangles, with customized visuals, onto an image

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class EditDrawRectangleExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditApi();
            var request = new DrawRectangleRequest(); // DrawRectangleRequest | 

            try
            {
                // Draw rectangle onto an image
                byte[] result = apiInstance.EditDrawRectangle(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditApi.EditDrawRectangle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DrawRectangleRequest**](DrawRectangleRequest.md)|  | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editdrawtext"></a>
# **EditDrawText**
> byte[] EditDrawText (DrawTextRequest request)

Draw text onto an image

Draw one or more pieces of text, with customized visuals, onto an image

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class EditDrawTextExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditApi();
            var request = new DrawTextRequest(); // DrawTextRequest | 

            try
            {
                // Draw text onto an image
                byte[] result = apiInstance.EditDrawText(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditApi.EditDrawText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DrawTextRequest**](DrawTextRequest.md)|  | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

