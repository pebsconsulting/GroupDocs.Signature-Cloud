using GroupDocs.Signature.Cloud.Sdk.Api;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Verification_Barcode_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Verification Post Barcode
        /// </summary>
        [Test]
        public void PostVerifyBarcodeTest()
        {
            var file = TestFiles.SignedPdf01;
            var verifyOptionsData = new PdfVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = "Code128",
                Text = "12345678",
                VerifyAllPages = false
            };
            var request = new PostVerificationBarcodeRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationBarcode(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }

        /// <summary>
        /// Test Signature Post Barcode from Url
        /// </summary>
        [Test]
        public void PostVerifyBarcodeUrlTest()
        {
            var verifyOptionsData = new WordsVerifyBarcodeOptionsData()
            {
                DocumentPageNumber = 1,
                BarcodeTypeName = "Code128",
                VerifyAllPages = false,
                Text = "12345678"
            };
            var request = new PostVerificationBarcodeFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationBarcodeFromUrl(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }
    }
}