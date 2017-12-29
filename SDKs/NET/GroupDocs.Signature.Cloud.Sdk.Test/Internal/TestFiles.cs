namespace GroupDocs.Signature.Cloud.Sdk.Test.Internal
{
    public static class TestFiles
    {
        public static readonly TestFile Pdf01 = new TestFile("01_pages.pdf", "storage");
        public static readonly TestFile Pdf02 = new TestFile("02_pages.pdf", "storage");

        public static readonly TestFile Words01 = new TestFile("01_pages.docx", "storage");
        public static readonly TestFile Words02 = new TestFile("02_pages.docx", "storage");

        public static readonly TestFile Image01 = new TestFile("01_pages.img", "storage");
        public static readonly TestFile Image02 = new TestFile("01_pages.png", "storage");

        public static readonly TestFile Slides01 = new TestFile("01_pages.pptx", "storage");
        public static readonly TestFile Slides02 = new TestFile("02_pages.pptx", "storage");

        public static readonly TestFile Cells01 = new TestFile("01_pages.xlsx", "storage");
        

        public static readonly TestFile WordsUrl = new TestFile("one-page.docx")
        {
            Url = "https://www.dropbox.com/s/bzx1xm68zd0c910/PieChart.docx?dl=1"
        };

        public static readonly TestFile SlidesUrl = new TestFile("with-notes.pptx")
        {
            Url = "https://www.dropbox.com/s/r2eioe2atushqcf/with-notes.pptx?dl=1"
        };

        public static readonly TestFile SignedWords01 = new TestFile("01_pages.docx", "signed");
        public static readonly TestFile SignedPdf01 = new TestFile("01_pages.pdf", "signed");
        public static readonly TestFile SignedSlides01 = new TestFile("01_pages.pptx", "signed");
        public static readonly TestFile SignedCells01 = new TestFile("01_pages.xlsx", "signed");
        
    }
}