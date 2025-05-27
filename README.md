# Cloudmersive.APIClient.NET.ImageRecognition - the C# library for the imageapi

Image Recognition and Processing APIs let you use Machine Learning to recognize and process images, and also perform useful image modification operations.

This C# SDK is:

- API version: v1
- SDK version: 3.0.9
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

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ArtisticApi* | [**ArtisticPainting**](docs/ArtisticApi.md#artisticpainting) | **POST** /image/artistic/painting/{style} | Transform an image into an artistic painting automatically
*ConvertApi* | [**ConvertToBmp**](docs/ConvertApi.md#converttobmp) | **POST** /image/convert/to/bmp | Convert input image to Bitmap BMP format
*ConvertApi* | [**ConvertToGif**](docs/ConvertApi.md#converttogif) | **POST** /image/convert/to/gif | Convert input image to GIF format
*ConvertApi* | [**ConvertToJpg**](docs/ConvertApi.md#converttojpg) | **POST** /image/convert/to/jpg/{quality} | Convert input image to JPG, JPEG format
*ConvertApi* | [**ConvertToPhotoshop**](docs/ConvertApi.md#converttophotoshop) | **POST** /image/convert/to/psd | Convert input image to Photoshop PSD format
*ConvertApi* | [**ConvertToPng**](docs/ConvertApi.md#converttopng) | **POST** /image/convert/to/png | Convert input image to PNG format
*ConvertApi* | [**ConvertToTiff**](docs/ConvertApi.md#converttotiff) | **POST** /image/convert/to/tiff | Convert input image to TIFF format
*ConvertApi* | [**ConvertToWebP**](docs/ConvertApi.md#converttowebp) | **POST** /image/convert/to/webp | Convert input image to WebP format
*EditApi* | [**EditAutoOrient**](docs/EditApi.md#editautoorient) | **POST** /image/edit/auto-orient/remove-exif | Normalizes image rotation and removes EXIF rotation data
*EditApi* | [**EditCompositeBasic**](docs/EditApi.md#editcompositebasic) | **POST** /image/edit/composite/{location} | Composite two images together
*EditApi* | [**EditCompositePrecise**](docs/EditApi.md#editcompositeprecise) | **POST** /image/edit/composite/precise | Composite two images together precisely
*EditApi* | [**EditContrastAdaptive**](docs/EditApi.md#editcontrastadaptive) | **POST** /image/edit/contrast/{gamma}/adaptive | Adaptively adjust the contrast of the image to be more appealing and easy to see
*EditApi* | [**EditCropCircle**](docs/EditApi.md#editcropcircle) | **POST** /image/edit/crop/circle/{left}/{top}/{radius} | Crop an image to an circular area
*EditApi* | [**EditCropRectangle**](docs/EditApi.md#editcroprectangle) | **POST** /image/edit/crop/rectangle/{left}/{top}/{width}/{height} | Crop an image to a rectangular area
*EditApi* | [**EditDrawPolygon**](docs/EditApi.md#editdrawpolygon) | **POST** /image/edit/draw/polygon | Draw a polygon onto an image
*EditApi* | [**EditDrawRectangle**](docs/EditApi.md#editdrawrectangle) | **POST** /image/edit/draw/rectangle | Draw a rectangle onto an image
*EditApi* | [**EditDrawText**](docs/EditApi.md#editdrawtext) | **POST** /image/edit/draw/text | Draw text onto an image
*EditApi* | [**EditDropShadow**](docs/EditApi.md#editdropshadow) | **POST** /image/edit/drop-shadow/{X}/{Y}/{sigma}/{opacity} | Add a customizeable drop shadow to an image
*EditApi* | [**EditInvert**](docs/EditApi.md#editinvert) | **POST** /image/edit/invert | Invert, negate the colors in the image
*EditApi* | [**EditRemoveExifData**](docs/EditApi.md#editremoveexifdata) | **POST** /image/edit/remove-exif | Remove EXIF data from the image
*EditApi* | [**EditRemoveTransparency**](docs/EditApi.md#editremovetransparency) | **POST** /image/edit/remove-transparency | Remove transparency from the image
*EditApi* | [**EditRotate**](docs/EditApi.md#editrotate) | **POST** /image/edit/rotate/{degrees}/angle | Rotate an image any number of degrees
*FaceApi* | [**FaceCompare**](docs/FaceApi.md#facecompare) | **POST** /image/face/compare-and-match | Compare and match faces
*FaceApi* | [**FaceCropFirst**](docs/FaceApi.md#facecropfirst) | **POST** /image/face/crop/first | Crop image to face with square crop
*FaceApi* | [**FaceCropFirstRound**](docs/FaceApi.md#facecropfirstround) | **POST** /image/face/crop/first/round | Crop image to face with round crop
*FaceApi* | [**FaceDetectAge**](docs/FaceApi.md#facedetectage) | **POST** /image/face/detect-age | Detect the age of people in an image
*FaceApi* | [**FaceDetectGender**](docs/FaceApi.md#facedetectgender) | **POST** /image/face/detect-gender | Detect the gender of people in an image
*FaceApi* | [**FaceLocate**](docs/FaceApi.md#facelocate) | **POST** /image/face/locate | Detect and find faces in an image
*FaceApi* | [**FaceLocateWithLandmarks**](docs/FaceApi.md#facelocatewithlandmarks) | **POST** /image/face/locate-with-landmarks | Detect and find faces and landmarks eyes and nose and mouth in image
*FilterApi* | [**FilterBlackAndWhite**](docs/FilterApi.md#filterblackandwhite) | **POST** /image/filter/black-and-white | Convert image to black-and-white grayscale
*FilterApi* | [**FilterDespeckle**](docs/FilterApi.md#filterdespeckle) | **POST** /image/filter/despeckle | Despeckle to remove point noise from the image
*FilterApi* | [**FilterEdgeDetect**](docs/FilterApi.md#filteredgedetect) | **POST** /image/filter/edge-detect/{radius} | Detect and highlight edges in an image
*FilterApi* | [**FilterEmboss**](docs/FilterApi.md#filteremboss) | **POST** /image/filter/emboss/{radius}/{sigma} | Emboss an image
*FilterApi* | [**FilterGaussianBlur**](docs/FilterApi.md#filtergaussianblur) | **POST** /image/filter/blur/guassian/{radius}/{sigma} | Perform a guassian blur on the input image
*FilterApi* | [**FilterMotionBlur**](docs/FilterApi.md#filtermotionblur) | **POST** /image/filter/blur/motion/{radius}/{sigma}/{angle} | Perform a motion blur on the input image
*FilterApi* | [**FilterPosterize**](docs/FilterApi.md#filterposterize) | **POST** /image/filter/posterize | Posterize the image by reducing distinct colors
*FilterApi* | [**FilterSwirl**](docs/FilterApi.md#filterswirl) | **POST** /image/filter/swirl | Swirl distort the image
*InfoApi* | [**InfoGetDominantColor**](docs/InfoApi.md#infogetdominantcolor) | **POST** /image/get-info/dominant-color | Returns the dominant colors of the image
*InfoApi* | [**InfoGetMetadata**](docs/InfoApi.md#infogetmetadata) | **POST** /image/get-info/metadata | Returns the image metadata including EXIF and resolution
*NsfwApi* | [**NsfwClassify**](docs/NsfwApi.md#nsfwclassify) | **POST** /image/nsfw/classify | Not safe for work (NSFW) content classification for Images
*NsfwApi* | [**NsfwClassifyDocument**](docs/NsfwApi.md#nsfwclassifydocument) | **POST** /image/nsfw/classify/document | Not safe for work (NSFW) content classification for Documents
*NsfwApi* | [**NsfwClassifyVideo**](docs/NsfwApi.md#nsfwclassifyvideo) | **POST** /image/nsfw/classify/video | Not safe for work (NSFW) content classification for Video
*RecognizeApi* | [**RecognizeDescribe**](docs/RecognizeApi.md#recognizedescribe) | **POST** /image/recognize/describe | Describe an image in natural language
*RecognizeApi* | [**RecognizeDetectAndUnskewDocument**](docs/RecognizeApi.md#recognizedetectandunskewdocument) | **POST** /image/recognize/detect-document/unskew | Detect and unskew a photo of a document
*RecognizeApi* | [**RecognizeDetectObjects**](docs/RecognizeApi.md#recognizedetectobjects) | **POST** /image/recognize/detect-objects | Detect objects including types and locations in an image
*RecognizeApi* | [**RecognizeDetectPeople**](docs/RecognizeApi.md#recognizedetectpeople) | **POST** /image/recognize/detect-people | Detect people including locations in an image
*RecognizeApi* | [**RecognizeDetectTextFine**](docs/RecognizeApi.md#recognizedetecttextfine) | **POST** /image/recognize/detect-text/fine | Detect fine text in a photo of a document
*RecognizeApi* | [**RecognizeDetectTextLarge**](docs/RecognizeApi.md#recognizedetecttextlarge) | **POST** /image/recognize/detect-text/large | Detect large text in a photo
*RecognizeApi* | [**RecognizeDetectVehicleLicensePlates**](docs/RecognizeApi.md#recognizedetectvehiclelicenseplates) | **POST** /image/recognize/detect-vehicle-license-plates | Detect vehicle license plates in an image
*RecognizeApi* | [**RecognizeFindSymbol**](docs/RecognizeApi.md#recognizefindsymbol) | **POST** /image/recognize/find/symbol | Find the location of a symbol in an image
*RecognizeApi* | [**RecognizeSimilarityCompare**](docs/RecognizeApi.md#recognizesimilaritycompare) | **POST** /image/recognize/similarity/compare | Compare two images for similarity
*RecognizeApi* | [**RecognizeSimilarityHash**](docs/RecognizeApi.md#recognizesimilarityhash) | **POST** /image/recognize/similarity/hash | Generate a perceptual image hash
*RecognizeApi* | [**RecognizeSimilarityHashDistance**](docs/RecognizeApi.md#recognizesimilarityhashdistance) | **POST** /image/recognize/similarity/hash/distance | Calculates the similarity between two perceptual image hashes
*ResizeApi* | [**ResizePost**](docs/ResizeApi.md#resizepost) | **POST** /image/resize/preserveAspectRatio/{maxWidth}/{maxHeight} | Resize an image while preserving aspect ratio
*ResizeApi* | [**ResizeResizeAISuperSampling**](docs/ResizeApi.md#resizeresizeaisupersampling) | **POST** /image/resize/ai/target | Resize an image with AI super sampling
*ResizeApi* | [**ResizeResizeSimple**](docs/ResizeApi.md#resizeresizesimple) | **POST** /image/resize/target/{width}/{height} | Resize an image
*TextGenerationApi* | [**TextGenerationCreateHandwritingPng**](docs/TextGenerationApi.md#textgenerationcreatehandwritingpng) | **POST** /image/text/create/handwriting/png | Create an image of handwriting in PNG format


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AgeDetectionResult](docs/AgeDetectionResult.md)
 - [Model.ColorResult](docs/ColorResult.md)
 - [Model.CreateHandwritingRequest](docs/CreateHandwritingRequest.md)
 - [Model.DetectedLicensePlate](docs/DetectedLicensePlate.md)
 - [Model.DetectedObject](docs/DetectedObject.md)
 - [Model.DominantColorResult](docs/DominantColorResult.md)
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
 - [Model.FindSymbolResult](docs/FindSymbolResult.md)
 - [Model.FineTextDetectionResult](docs/FineTextDetectionResult.md)
 - [Model.FineTextItem](docs/FineTextItem.md)
 - [Model.ImageDescriptionResponse](docs/ImageDescriptionResponse.md)
 - [Model.ImageMetadata](docs/ImageMetadata.md)
 - [Model.ImageMetadataExifValue](docs/ImageMetadataExifValue.md)
 - [Model.ImageSimilarityComparisonResponse](docs/ImageSimilarityComparisonResponse.md)
 - [Model.ImageSimilarityHashDistanceRequest](docs/ImageSimilarityHashDistanceRequest.md)
 - [Model.ImageSimilarityHashDistanceResponse](docs/ImageSimilarityHashDistanceResponse.md)
 - [Model.ImageSimilarityHashResponse](docs/ImageSimilarityHashResponse.md)
 - [Model.NsfwResult](docs/NsfwResult.md)
 - [Model.ObjectDetectionResult](docs/ObjectDetectionResult.md)
 - [Model.PersonWithAge](docs/PersonWithAge.md)
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

