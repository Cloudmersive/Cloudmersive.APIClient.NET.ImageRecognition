# Cloudmersive.APIClient.NET.ImageRecognition.Api.InfoApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InfoGetDominantColor**](InfoApi.md#infogetdominantcolor) | **POST** /image/get-info/dominant-color | Returns the dominant colors of the image


<a name="infogetdominantcolor"></a>
# **InfoGetDominantColor**
> DominantColorResult InfoGetDominantColor (System.IO.Stream imageFile)

Returns the dominant colors of the image

Uses advanced image processing to extract the top 5 dominant colors in the image, returned in the order of dominance with the most-dominant color first.  These are the primary perceptual colors used in the image as perceived by a viewer.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class InfoGetDominantColorExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new InfoApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Returns the dominant colors of the image
                DominantColorResult result = apiInstance.InfoGetDominantColor(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InfoApi.InfoGetDominantColor: " + e.Message );
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

[**DominantColorResult**](DominantColorResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

