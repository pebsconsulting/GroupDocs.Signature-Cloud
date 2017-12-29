using GroupDocs.Signature.Cloud.Sdk.Api;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Verification_Text_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Verification Post Text
        /// </summary>
        [Test]
        public void PostVerifyTextTest()
        {
            var file = TestFiles.SignedPdf01;
            var verifyOptionsData = new PdfVerifyTextOptionsData()
            {
                DocumentPageNumber = 1,
                Text = "1234567890",
                VerifyAllPages = false
            };
            var request = new PostVerificationTextRequest
            {
                Name = file.FileName,
                VerifyOptionsData = verifyOptionsData,
                Password = null,
                Folder = file.Folder
            };

            var response = SignatureApi.PostVerificationText(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }

        /// <summary>
        /// Test Signature Post Text from Url
        /// </summary>
        [Test]
        public void PostVerifyTextUrlTest()
        {
            var verifyOptionsData = new WordsVerifyTextOptionsData()
            {
                DocumentPageNumber = 1,
                Text = "1234567890",
                VerifyAllPages = false
            };
            var request = new PostVerificationTextFromUrlRequest
            {
                Url = TestFiles.WordsUrl.Url,
                Password = null,
                VerifyOptionsData = verifyOptionsData
            };

            var response = SignatureApi.PostVerificationTextFromUrl(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }
    }
}