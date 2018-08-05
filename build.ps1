Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/image -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client






(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj).replace('<Authors>Swagger</Authors>', "<Authors>Cloudmersive</Authors>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj).replace('<Company>Swagger</Company>', "<Company>Cloudmersive</Company>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj).replace('<AssemblyTitle>Swagger Library</AssemblyTitle>', "<AssemblyTitle>Cloudmersive Image Recognition and Processing API Client</AssemblyTitle>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj).replace('<Description>A library generated from a Swagger doc</Description>', "<Description>Image Recognition and Processing APIs let you use Machine Learning to recognize and process images, and also perform useful image modification operations.</Description>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj
(Get-Content ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj).replace('<TargetFramework>net45</TargetFramework>', "<TargetFramework>netcoreapp2.1</TargetFramework>") | Set-Content ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj






& dotnet build ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj -c Release
& dotnet pack ./client/src/Cloudmersive.APIClient.NETCore.ImageRecognition/Cloudmersive.APIClient.NETCore.ImageRecognition.csproj -c Release