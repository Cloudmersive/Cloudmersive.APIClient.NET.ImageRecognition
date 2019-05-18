﻿Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/image -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client



$csprojpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.ImageRecognition/Cloudmersive.APIClient.NET.ImageRecognition.csproj
$nuspecpath = Resolve-Path ./client/src/Cloudmersive.APIClient.NET.ImageRecognition/Cloudmersive.APIClient.NET.ImageRecognition.nuspec

(Get-Content $nuspecpath).replace('<title>Swagger Library</title>', "<title>Cloudmersive Image Recognition and Processing API Client</title>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<authors>$author$</authors>', "<authors>Cloudmersive</authors>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<owners>$author$</owners>', "<owners>Cloudmersive</owners>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<description>A library generated from a Swagger doc</description>', "<description>Image Recognition and Processing APIs let you use Machine Learning to recognize and process images, and also perform useful image modification operations.</description>") | Set-Content $nuspecpath
(Get-Content $nuspecpath).replace('<!-- Authors contain text that appears directly on the gallery -->', "<iconUrl>https://cloudmersive.com/images/cmsdk.png</iconUrl>") | Set-Content $nuspecpath


(Get-Content $csprojpath).replace('<Authors>Swagger</Authors>', "<Authors>Cloudmersive</Authors>") | Set-Content $csprojpath
(Get-Content $csprojpath).replace('<Company>Swagger</Company>', "<Company>Cloudmersive</Company>") | Set-Content $csprojpath
(Get-Content $csprojpath).replace('<AssemblyTitle>Swagger Library</AssemblyTitle>', "<AssemblyTitle>Cloudmersive Image Recognition and Processing API Client</AssemblyTitle>") | Set-Content $csprojpath
(Get-Content $csprojpath).replace('<Description>A library generated from a Swagger doc</Description>', "<Description>Image Recognition and Processing APIs let you use Machine Learning to recognize and process images, and also perform useful image modification operations.</Description>") | Set-Content $csprojpath
(Get-Content $csprojpath).replace('<TargetFramework>net45</TargetFramework>', "<TargetFramework>netcoreapp2.1</TargetFramework>") | Set-Content $csprojpath


./nuget.exe restore ./client/src/Cloudmersive.APIClient.NET.ImageRecognition/Cloudmersive.APIClient.NET.ImageRecognition.csproj -SolutionDirectory ./client

./nuget.exe restore ./client/src/Cloudmersive.APIClient.NET.ImageRecognition.Test/Cloudmersive.APIClient.NET.ImageRecognition.Test.csproj -SolutionDirectory ./client

C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe ./client/Cloudmersive.APIClient.NET.ImageRecognition.sln /t:rebuild 

./nuget.exe pack ./client/src/Cloudmersive.APIClient.NET.ImageRecognition/Cloudmersive.APIClient.NET.ImageRecognition.csproj

#& dotnet build ./client/src/Cloudmersive.APIClient.NET.ImageRecognition/Cloudmersive.APIClient.NET.ImageRecognition.csproj -c Release
#& dotnet pack ./client/src/Cloudmersive.APIClient.NET.ImageRecognition/Cloudmersive.APIClient.NET.ImageRecognition.csproj -c Release

(Get-Content ./client/README.md).replace(' automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project', "") | Set-Content ./client/README.md

Copy-Item ./client/README.md ./README.md

