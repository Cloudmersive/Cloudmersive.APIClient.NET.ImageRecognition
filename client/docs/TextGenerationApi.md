# Cloudmersive.APIClient.NET.ImageRecognition.Api.TextGenerationApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TextGenerationCreateHandwritingPng**](TextGenerationApi.md#textgenerationcreatehandwritingpng) | **POST** /image/text/create/handwriting/png | Create an image of handwriting in PNG format


<a name="textgenerationcreatehandwritingpng"></a>
# **TextGenerationCreateHandwritingPng**
> Object TextGenerationCreateHandwritingPng (CreateHandwritingRequest request)

Create an image of handwriting in PNG format

Uses Deep Learning to generate realistic handwriting and returns the result as a PNG image

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class TextGenerationCreateHandwritingPngExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TextGenerationApi();
            var request = new CreateHandwritingRequest(); // CreateHandwritingRequest | Draw text parameters

            try
            {
                // Create an image of handwriting in PNG format
                Object result = apiInstance.TextGenerationCreateHandwritingPng(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextGenerationApi.TextGenerationCreateHandwritingPng: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateHandwritingRequest**](CreateHandwritingRequest.md)| Draw text parameters | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

