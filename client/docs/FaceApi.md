# Cloudmersive.APIClient.NET.ImageRecognition.Api.FaceApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FaceCompare**](FaceApi.md#facecompare) | **POST** /image/face/compare-and-match | Compare and match faces
[**FaceCropFirst**](FaceApi.md#facecropfirst) | **POST** /image/face/crop/first | Crop image to face with square crop
[**FaceCropFirstRound**](FaceApi.md#facecropfirstround) | **POST** /image/face/crop/first/round | Crop image to face with round crop
[**FaceDetectAge**](FaceApi.md#facedetectage) | **POST** /image/face/detect-age | Detect the age of people in an image
[**FaceDetectGender**](FaceApi.md#facedetectgender) | **POST** /image/face/detect-gender | Detect the gender of people in an image
[**FaceLocate**](FaceApi.md#facelocate) | **POST** /image/face/locate | Detect and find faces in an image
[**FaceLocateWithLandmarks**](FaceApi.md#facelocatewithlandmarks) | **POST** /image/face/locate-with-landmarks | Detect and find faces and landmarks eyes and nose and mouth in image


<a name="facecompare"></a>
# **FaceCompare**
> FaceCompareResponse FaceCompare (System.IO.Stream inputImage, System.IO.Stream matchFace)

Compare and match faces

Find the faces in an input image, and compare against a reference image to determine if there is a match against the face in the reference image.  The reference image (second parameter) should contain exactly one face.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class FaceCompareExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FaceApi();
            var inputImage = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on; this image can contain one or more faces which will be matched against face provided in the second image.  Common file formats such as PNG, JPEG are supported.
            var matchFace = new System.IO.Stream(); // System.IO.Stream | Image of a single face to compare and match against.

            try
            {
                // Compare and match faces
                FaceCompareResponse result = apiInstance.FaceCompare(inputImage, matchFace);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaceApi.FaceCompare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputImage** | **System.IO.Stream**| Image file to perform the operation on; this image can contain one or more faces which will be matched against face provided in the second image.  Common file formats such as PNG, JPEG are supported. | 
 **matchFace** | **System.IO.Stream**| Image of a single face to compare and match against. | 

### Return type

[**FaceCompareResponse**](FaceCompareResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="facecropfirst"></a>
# **FaceCropFirst**
> byte[] FaceCropFirst (System.IO.Stream imageFile)

Crop image to face with square crop

Crop an image to the face (rectangular crop).  If there is more than one face present, choose the first one.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class FaceCropFirstExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FaceApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Crop image to face with square crop
                byte[] result = apiInstance.FaceCropFirst(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaceApi.FaceCropFirst: " + e.Message );
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

<a name="facecropfirstround"></a>
# **FaceCropFirstRound**
> byte[] FaceCropFirstRound (System.IO.Stream imageFile)

Crop image to face with round crop

Crop an image to the face (circular/round crop).  If there is more than one face present, choose the first one.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class FaceCropFirstRoundExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FaceApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Crop image to face with round crop
                byte[] result = apiInstance.FaceCropFirstRound(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaceApi.FaceCropFirstRound: " + e.Message );
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

<a name="facedetectage"></a>
# **FaceDetectAge**
> AgeDetectionResult FaceDetectAge (System.IO.Stream imageFile)

Detect the age of people in an image

Identify the age, position, and size of human faces in an image, along with a recognition confidence level.  People in the image do NOT need to be facing the camera; they can be facing away, edge-on, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class FaceDetectAgeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FaceApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect the age of people in an image
                AgeDetectionResult result = apiInstance.FaceDetectAge(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaceApi.FaceDetectAge: " + e.Message );
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

[**AgeDetectionResult**](AgeDetectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="facedetectgender"></a>
# **FaceDetectGender**
> GenderDetectionResult FaceDetectGender (System.IO.Stream imageFile)

Detect the gender of people in an image

Identify the gender, position, and size of human faces in an image, along with a recognition confidence level.  People in the image should be facing the camera.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class FaceDetectGenderExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FaceApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect the gender of people in an image
                GenderDetectionResult result = apiInstance.FaceDetectGender(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaceApi.FaceDetectGender: " + e.Message );
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

[**GenderDetectionResult**](GenderDetectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="facelocate"></a>
# **FaceLocate**
> FaceLocateResponse FaceLocate (System.IO.Stream imageFile)

Detect and find faces in an image

Locate the positions of all faces in an image

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class FaceLocateExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FaceApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect and find faces in an image
                FaceLocateResponse result = apiInstance.FaceLocate(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaceApi.FaceLocate: " + e.Message );
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

[**FaceLocateResponse**](FaceLocateResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="facelocatewithlandmarks"></a>
# **FaceLocateWithLandmarks**
> FaceLocateWithLandmarksResponse FaceLocateWithLandmarks (System.IO.Stream imageFile)

Detect and find faces and landmarks eyes and nose and mouth in image

Locate the positions of all faces in an image, along with the eyes, eye brows, nose and mouth components of each

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class FaceLocateWithLandmarksExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FaceApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect and find faces and landmarks eyes and nose and mouth in image
                FaceLocateWithLandmarksResponse result = apiInstance.FaceLocateWithLandmarks(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaceApi.FaceLocateWithLandmarks: " + e.Message );
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

[**FaceLocateWithLandmarksResponse**](FaceLocateWithLandmarksResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

