# Cloudmersive.APIClient.NET.ImageRecognition.Api.NsfwApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NsfwClassify**](NsfwApi.md#nsfwclassify) | **POST** /image/nsfw/classify | Not safe for work (NSFW) content classification for Images
[**NsfwClassifyAdvanced**](NsfwApi.md#nsfwclassifyadvanced) | **POST** /image/nsfw/classify/advanced | Advanced content moderation and not safe for work (NSFW) content classification for Images
[**NsfwClassifyDocument**](NsfwApi.md#nsfwclassifydocument) | **POST** /image/nsfw/classify/document | Not safe for work (NSFW) content classification for Documents
[**NsfwClassifyVideo**](NsfwApi.md#nsfwclassifyvideo) | **POST** /image/nsfw/classify/video | Not safe for work (NSFW) content classification for Video


<a name="nsfwclassify"></a>
# **NsfwClassify**
> NsfwResult NsfwClassify (System.IO.Stream imageFile)

Not safe for work (NSFW) content classification for Images

Classify an image into Not Safe For Work (NSFW)/Pornographic/Nudity/Racy content and Safe Content.  Helpful for filtering out unsafe content when processing user images.  Input image should be JPG, PNG or GIF.  Consumes 20 API calls.

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
                // Not safe for work (NSFW) content classification for Images
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

<a name="nsfwclassifyadvanced"></a>
# **NsfwClassifyAdvanced**
> NsfwAdvancedResult NsfwClassifyAdvanced (System.IO.Stream imageFile)

Advanced content moderation and not safe for work (NSFW) content classification for Images

Uses advanced AI to classify an image into Not Safe For Work (NSFW) or not and determine if it contains nudity, graphic violence, non-graphic violence, self-harm, hate, potential illegal activity, medical imagery, or profanity.  Helpful for filtering out unsafe content when processing user images.  Input image should be JPG, PNG.  Consumes 100 API calls.  Requires Managed Instance or Private Cloud deployment, and a GPU.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class NsfwClassifyAdvancedExample
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
                // Advanced content moderation and not safe for work (NSFW) content classification for Images
                NsfwAdvancedResult result = apiInstance.NsfwClassifyAdvanced(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NsfwApi.NsfwClassifyAdvanced: " + e.Message );
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

[**NsfwAdvancedResult**](NsfwAdvancedResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nsfwclassifydocument"></a>
# **NsfwClassifyDocument**
> NsfwResult NsfwClassifyDocument (System.IO.Stream imageFile)

Not safe for work (NSFW) content classification for Documents

Classify a document (PDF, DOCX, DOC, XLSX, XLS, PPTX, PPT) into Not Safe For Work (NSFW)/Pornographic/Nudity/Racy content and Safe Content.  Helpful for filtering out unsafe content when processing user images.  Consumes 20 API calls per image.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class NsfwClassifyDocumentExample
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
                // Not safe for work (NSFW) content classification for Documents
                NsfwResult result = apiInstance.NsfwClassifyDocument(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NsfwApi.NsfwClassifyDocument: " + e.Message );
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

<a name="nsfwclassifyvideo"></a>
# **NsfwClassifyVideo**
> NsfwResult NsfwClassifyVideo (System.IO.Stream videoFile)

Not safe for work (NSFW) content classification for Video

Classify a video into Not Safe For Work (NSFW)/Pornographic/Nudity/Racy content and Safe Content.  Helpful for filtering out unsafe content when processing user images.  Input image should be MP4, MOV, WEBM, MKV, AVI, FLV, MPG, GIF.  Consumes 20 API calls per frame analyzed.  Requires Cloudmersive Managed Instance or Private Cloud deployment.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class NsfwClassifyVideoExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new NsfwApi();
            var videoFile = new System.IO.Stream(); // System.IO.Stream | Video file to perform the operation on.  Common file formats such as MP4, MPG are supported.

            try
            {
                // Not safe for work (NSFW) content classification for Video
                NsfwResult result = apiInstance.NsfwClassifyVideo(videoFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NsfwApi.NsfwClassifyVideo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **videoFile** | **System.IO.Stream**| Video file to perform the operation on.  Common file formats such as MP4, MPG are supported. | 

### Return type

[**NsfwResult**](NsfwResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

