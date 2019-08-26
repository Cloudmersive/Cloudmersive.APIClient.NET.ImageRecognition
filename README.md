# Cloudmersive.APIClient.NET.ImageRecognition - the C# library for the imageapi

Image Recognition and Processing APIs let you use Machine Learning to recognize and process images, and also perform useful image modification operations.

This C# SDK is:

- API version: v1
- SDK version: 2.0.9
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NET.ImageRecognition.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.ImageRecognition.Api;
using Cloudmersive.APIClient.NET.ImageRecognition.Client;
using Cloudmersive.APIClient.NET.ImageRecognition.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new ArtisticApi();
            var style = style_example;  // string | The style of the painting to apply.  To start, try \"udnie\" a painting style.  Possible values are: \"udnie\", \"wave\", \"la_muse\", \"rain_princess\".
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Transform an image into an artistic painting automatically
                byte[] result = apiInstance.ArtisticPainting(style, imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ArtisticApi.ArtisticPainting: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ArtisticApi* | [**ArtisticPainting**](docs/ArtisticApi.md#artisticpainting) | **POST** /image/artistic/painting/{style} | Transform an image into an artistic painting automatically
*EditApi* | [**EditAutoOrient**](docs/EditApi.md#editautoorient) | **POST** /image/edit/auto-orient/remove-exif | Normalizes image rotation and removes EXIF rotation data
*EditApi* | [**EditCompositeBasic**](docs/EditApi.md#editcompositebasic) | **POST** /image/edit/composite/{location} | Composite two images together
*EditApi* | [**EditContrastAdaptive**](docs/EditApi.md#editcontrastadaptive) | **POST** /image/edit/contrast/{gamma}/adaptive | Adaptively adjust the contrast of the image to be more appealing and easy to see
*EditApi* | [**EditDrawPolygon**](docs/EditApi.md#editdrawpolygon) | **POST** /image/edit/draw/polygon | Draw a polygon onto an image
*EditApi* | [**EditDrawRectangle**](docs/EditApi.md#editdrawrectangle) | **POST** /image/edit/draw/rectangle | Draw a rectangle onto an image
*EditApi* | [**EditDrawText**](docs/EditApi.md#editdrawtext) | **POST** /image/edit/draw/text | Draw text onto an image
*EditApi* | [**EditRotate**](docs/EditApi.md#editrotate) | **POST** /image/edit/rotate/{degrees}/angle | Rotate an image any number of degrees
*FaceApi* | [**FaceCompare**](docs/FaceApi.md#facecompare) | **POST** /image/face/compare-and-match | Compare and match faces
*FaceApi* | [**FaceCropFirst**](docs/FaceApi.md#facecropfirst) | **POST** /image/face/crop/first | Crop image to face (square)
*FaceApi* | [**FaceCropFirstRound**](docs/FaceApi.md#facecropfirstround) | **POST** /image/face/crop/first/round | Crop image to face (round)
*FaceApi* | [**FaceDetectAge**](docs/FaceApi.md#facedetectage) | **POST** /image/face/detect-age | Detect the age of people in an image
*FaceApi* | [**FaceDetectGender**](docs/FaceApi.md#facedetectgender) | **POST** /image/face/detect-gender | Detect the gender of people in an image
*FaceApi* | [**FaceLocate**](docs/FaceApi.md#facelocate) | **POST** /image/face/locate | Find faces in an image
*FaceApi* | [**FaceLocateWithLandmarks**](docs/FaceApi.md#facelocatewithlandmarks) | **POST** /image/face/locate-with-landmarks | Find faces and face landmarks (eyes, eye brows, nose, mouth) in an image
*NsfwApi* | [**NsfwClassify**](docs/NsfwApi.md#nsfwclassify) | **POST** /image/nsfw/classify | Not safe for work (NSFW) racy content classification
*RecognizeApi* | [**RecognizeDescribe**](docs/RecognizeApi.md#recognizedescribe) | **POST** /image/recognize/describe | Describe an image in natural language
*RecognizeApi* | [**RecognizeDetectAndUnskewDocument**](docs/RecognizeApi.md#recognizedetectandunskewdocument) | **POST** /image/recognize/detect-document/unskew | Detect and unskew a photo of a document
*RecognizeApi* | [**RecognizeDetectObjects**](docs/RecognizeApi.md#recognizedetectobjects) | **POST** /image/recognize/detect-objects | Detect objects, including types and locations, in an image
*RecognizeApi* | [**RecognizeDetectPeople**](docs/RecognizeApi.md#recognizedetectpeople) | **POST** /image/recognize/detect-people | Detect people, including locations, in an image
*RecognizeApi* | [**RecognizeDetectTextFine**](docs/RecognizeApi.md#recognizedetecttextfine) | **POST** /image/recognize/detect-text/fine | Detect fine text in a photo of a document
*RecognizeApi* | [**RecognizeDetectTextLarge**](docs/RecognizeApi.md#recognizedetecttextlarge) | **POST** /image/recognize/detect-text/large | Detect large text in a photo
*RecognizeApi* | [**RecognizeDetectVehicleLicensePlates**](docs/RecognizeApi.md#recognizedetectvehiclelicenseplates) | **POST** /image/recognize/detect-vehicle-license-plates | Detect vehicle license plates in an image
*ResizeApi* | [**ResizePost**](docs/ResizeApi.md#resizepost) | **POST** /image/resize/preserveAspectRatio/{maxWidth}/{maxHeight} | Resize an image with parameters


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AgeDetectionResult](docs/AgeDetectionResult.md)
 - [Model.DetectedLicensePlate](docs/DetectedLicensePlate.md)
 - [Model.DetectedObject](docs/DetectedObject.md)
 - [Model.DrawPolygonInstance](docs/DrawPolygonInstance.md)
 - [Model.DrawPolygonRequest](docs/DrawPolygonRequest.md)
 - [Model.DrawRectangleInstance](docs/DrawRectangleInstance.md)
 - [Model.DrawRectangleRequest](docs/DrawRectangleRequest.md)
 - [Model.DrawTextInstance](docs/DrawTextInstance.md)
 - [Model.DrawTextRequest](docs/DrawTextRequest.md)
 - [Model.Face](docs/Face.md)
 - [Model.FaceCompareResponse](docs/FaceCompareResponse.md)
 - [Model.FaceLocateResponse](docs/FaceLocateResponse.md)
 - [Model.FaceLocateWithLandmarksResponse](docs/FaceLocateWithLandmarksResponse.md)
 - [Model.FaceMatch](docs/FaceMatch.md)
 - [Model.FacePoint](docs/FacePoint.md)
 - [Model.FaceWithLandmarks](docs/FaceWithLandmarks.md)
 - [Model.FineTextDetectionResult](docs/FineTextDetectionResult.md)
 - [Model.FineTextItem](docs/FineTextItem.md)
 - [Model.GenderDetectionResult](docs/GenderDetectionResult.md)
 - [Model.ImageDescriptionResponse](docs/ImageDescriptionResponse.md)
 - [Model.NsfwResult](docs/NsfwResult.md)
 - [Model.ObjectDetectionResult](docs/ObjectDetectionResult.md)
 - [Model.PersonWithAge](docs/PersonWithAge.md)
 - [Model.PersonWithGender](docs/PersonWithGender.md)
 - [Model.PolygonPoint](docs/PolygonPoint.md)
 - [Model.RecognitionOutcome](docs/RecognitionOutcome.md)
 - [Model.TextDetectionResult](docs/TextDetectionResult.md)
 - [Model.TextItem](docs/TextItem.md)
 - [Model.VehicleLicensePlateDetectionResult](docs/VehicleLicensePlateDetectionResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

