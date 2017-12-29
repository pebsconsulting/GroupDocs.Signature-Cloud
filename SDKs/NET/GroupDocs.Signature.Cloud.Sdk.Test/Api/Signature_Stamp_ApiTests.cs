using GroupDocs.Signature.Cloud.Sdk.Api;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class Signature_Stamp_ApiTests : BaseApiTest
    {
        /// <summary>
        /// Test Signature Post Stamp
        /// </summary>
        [Test]
        public void PostStampTest()
        {
            var file = TestFiles.Pdf02;
            var signOptionsData = new PdfSignStampOptionsData()
            {
                BackgroundColor = new Color() { Web = "#fcfcfc" },
                DocumentPageNumber = 1,
                Height = 80,
                HorizontalAlignment = SignStampOptionsData.HorizontalAlignmentEnum.Right,
                Left = 10,
                LocationMeasureType = SignStampOptionsData.LocationMeasureTypeEnum.Pixels,
                Margin = new PaddingData() { Left = 10, Right = 10, Bottom = 10, Top = 10 },
                MarginMeasureType = SignStampOptionsData.MarginMeasureTypeEnum.Pixels,
                Opacity = 0.5,
                SignAllPages = false,
                Top = 100,
                VerticalAlignment = SignStampOptionsData.VerticalAlignmentEnum.Center,
                Width = 100
            };
            var request = new PostStampRequest
            {
                Name = TestFiles.Pdf02.FileName,
                SignOptionsData = signOptionsData,
                Password = null,
                Folder = TestFiles.Pdf02.Folder
            };

            var response = SignatureApi.PostStamp(request);
            Assert.IsTrue(!string.IsNullOrEmpty(response.FileName));
        }
    }
}