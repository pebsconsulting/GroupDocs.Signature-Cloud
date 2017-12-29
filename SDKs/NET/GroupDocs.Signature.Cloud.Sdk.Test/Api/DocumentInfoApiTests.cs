﻿using GroupDocs.Signature.Cloud.Sdk.Api;

namespace GroupDocs.Signature.Cloud.Sdk.Test.Api
{
    using NUnit.Framework;
    using GroupDocs.Signature.Cloud.Sdk.Model;
    using GroupDocs.Signature.Cloud.Sdk.Model.Requests;
    using GroupDocs.Signature.Cloud.Sdk.Test.Internal;

    public class DocumentInfoApiTests : BaseApiTest
    {
        /// <summary>
        /// Test DocumentInfoTests
        /// </summary>
        [Test]
        public void DocumentInfoTests()
        {
            var file = new TestFile("one-page.docx");

            var request = new GetDocumentInfoRequest
            {
                FileName = file.FileName,
                Password = null,
                Folder = file.Folder,
                Storage = null,
            };

            var response = SignatureApi.GetDocumentInfo(request);

            Assert.AreEqual(file.FileName, response.Name);
            Assert.AreEqual(1, response.Pages.TotalCount);
        }

        /// <summary>
        /// Test DocumentInfoTests
        /// </summary>
        [Test]
        public void DocumentInfoFromUrlTests()
        {
            var request = new GetDocumentInfoFromUrlRequest
            {
                Url = @"https://www.dropbox.com/s/bzx1xm68zd0c910/PieChart.docx?dl=0",
                Password = null,
                Storage = null,
            };

            var response = SignatureApi.GetDocumentInfoFromUrl(request);
            Assert.AreEqual(1, response.Pages.TotalCount);
        }
    }
}