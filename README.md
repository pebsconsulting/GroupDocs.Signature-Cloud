## IMPORTANT NOTICE
This SDK is no longer updated because we have created a newer and much improved version of this SDK available at following product wise repositories

* [GroupDocs.Annotation Cloud SDK for .NET](https://github.com/groupdocs-annotation-cloud/groupdocs-annotation-cloud-dotnet)
* [GroupDocs.Comparison Cloud SDK for .NET](https://github.com/groupdocs-comparison-cloud/groupdocs-comparison-cloud-dotnet)
* [GroupDocs.Conversion Cloud SDK for .NET](https://github.com/groupdocs-conversion-cloud/groupdocs-conversion-cloud-dotnet)
* [GroupDocs.Signature Cloud SDK for .NET](https://github.com/groupdocs-signature-cloud/groupdocs-signature-cloud-dotnet)
* [GroupDocs.Viewer Cloud SDK for .NET](https://github.com/groupdocs-viewer-cloud/groupdocs-viewer-cloud-dotnet)

You are kindly requested to try our new SDKs and then plan to migrate. We will be more than happy to help and assist you if you face any issues during or after migration. We will however continue to provide support to our existing customers for some time.

# GroupDocs.Signature for Cloud SDKs
This folder contains SDKs for [GroupDocs.Signature for Cloud](https://products.groupdocs.cloud/signature/cloud) for various platforms.

# Currently Available SDKs

Directory | Description
--------- | -----------
[.NET SDK](SDKs/NET) | GroupDocs.Signature for Cloud .NET SDK

To use these SDKs, you will need App SID and App Key which can be looked up at [GroupDocs Cloud Dashboard](https://dashboard.groupdocs.cloud) (free registration in GroupDocs Cloud is required for this).

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Signature.Cloud.Sdk;
using GroupDocs.Signature.Cloud.Sdk.Api;
using GroupDocs.Signature.Cloud.Sdk.Model.Requests;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var configuration = new Configuration
            {
                AppSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                AppKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            };

            var apiInstance = new SignatureApi(configuration);

            try
            {
                var request = new GetSupportedFileFormatsRequest();

                // Get supported file formats
                var response = apiInstance.GetSupportedFileFormats(request);

                foreach (var format in response.Formats)
                {
                    Debug.Print(format.ToString());
                }
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignatureApi GetSupportedFileFormats: " + e.Message);
            }

        }
    }
}
```

# Licensing
All GroupDocs.Signature for Cloud SDKs are licensed under [MIT License](LICENSE).

# Resources
+ [**Website**](https://www.groupdocs.cloud)
+ [**Product Home**](https://products.groupdocs.cloud/signature/cloud)
+ [**Documentation**](https://docs.groupdocs.cloud/display/signaturecloud/Home)
+ [**Free Support Forum**](https://forum.groupdocs.cloud/c/signature)
+ [**Paid Support Helpdesk**](https://helpdesk.groupdocs.cloud)
+ [**Blog**](https://blog.groupdocs.cloud/category/groupdocs-products/groupdocs-signature-product-family)
