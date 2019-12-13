# Cloudmersive.APIClient.NET.ImageRecognition.Api.NsfwApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NsfwClassify**](NsfwApi.md#nsfwclassify) | **POST** /image/nsfw/classify | Not safe for work NSFW racy content classification


<a name="nsfwclassify"></a>
# **NsfwClassify**
> NsfwResult NsfwClassify (System.IO.Stream imageFile)

Not safe for work NSFW racy content classification

Classify an image into Not Safe For Work (NSFW)/Porn/Racy content and Safe Content.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class NsfwClassifyExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new NsfwApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Not safe for work NSFW racy content classification
                NsfwResult result = apiInstance.NsfwClassify(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NsfwApi.NsfwClassify: " + e.Message );
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

[**NsfwResult**](NsfwResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

