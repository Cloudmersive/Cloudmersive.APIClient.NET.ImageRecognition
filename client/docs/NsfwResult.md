# Cloudmersive.APIClient.NET.ImageRecognition.Model.NsfwResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if the classification was successfully run, false otherwise | [optional] 
**Score** | **double?** | Score between 0.0 and 1.0.  Scores of 0.0-0.2 represent high probability safe content, while scores 0.8-1.0 represent high probability unsafe content.  Content between 0.2 and 0.8 is of increasing raciness. | [optional] 
**ClassificationOutcome** | **string** | Classification result into four categories: SafeContent_HighProbability, UnsafeContent_HighProbability, RacyContent, SafeContent_ModerateProbability | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

