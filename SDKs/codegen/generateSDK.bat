rd /S /Q "c:\tmp\csharp"

java -jar SDKs\codegen\swagger-codegen-cli-2.3.0.jar generate ^
-i SDKs\spec\groupdocsforcloud_signature_csharp.json ^
-l csharp ^
-t SDKs\codegen\Templates\csharp ^
-o c:/tmp/csharp/ ^
-c SDKs\codegen\config.json

SDKs\codegen\Tools\SplitCSharpCodeFile.exe ^
C:\tmp\csharp\src\GroupDocs.Signature.Cloud.Sdk\Api\SignatureApi.cs ^
C:\tmp\csharp\src\GroupDocs.Signature.Cloud.Sdk\Model\Requests\

xcopy /Y "c:\tmp\csharp\src\GroupDocs.Signature.Cloud.Sdk\Model" "SDKs\NET\GroupDocs.Signature.Cloud.Sdk\Model" /E
xcopy /Y "c:\tmp\csharp\src\GroupDocs.Signature.Cloud.Sdk\Api" "SDKs\NET\GroupDocs.Signature.Cloud.Sdk\Api" /E

rd /S /Q "c:\tmp\csharp"
