# Cloudmersive.APIClient.NET.ImageRecognition.Model.NsfwAdvancedResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if the classification was successfully run, false otherwise | [optional] 
**CleanResult** | **bool?** | True if the result was clean, false otherwise | [optional] 
**ContainsNudity** | **bool?** | True if the image contains nudity or sex, false otherwise | [optional] 
**ContainsGraphicViolence** | **bool?** | True if the image contains graphic violence and/or gore, false otherwise | [optional] 
**ContainsNonGraphicViolence** | **bool?** | True if the image contains non-graphic violence, e.g. weapons, false otherwise | [optional] 
**ContainsSelfHarm** | **bool?** | True if the image contains self-harm or suicide imagery, false otherwise | [optional] 
**ContainsHate** | **bool?** | True if the image contains hate, false otherwise | [optional] 
**ContainsPotentialIllegalActivity** | **bool?** | True if the image contains potentially illegal activity such as drugs, false otherwise | [optional] 
**ContainsMedicalImagery** | **bool?** | True if the image contains medical imagery, false otherwise | [optional] 
**ContainsProfanity** | **bool?** | True if the image contains profanity or obscenities, false otherwise | [optional] 
**Score** | **double?** | Score between 0.0 and 1.0.  Scores of 0.0-0.2 represent high probability safe content, while scores 0.8-1.0 represent high probability unsafe content.  Content between 0.2 and 0.8 is of increasing raciness. | [optional] 
**ClassificationOutcome** | **string** | Classification result into four categories: SafeContent_HighProbability, UnsafeContent_HighProbability, RacyContent, SafeContent_ModerateProbability | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

