namespace hospitalAddIn
{
    internal class ConvertCodesConfigModel
    {
        public string icdCodesFilePath;
        public string cptCodesFilePath;
        public string icdCodeColumn = "B";
        public string icdTextColumn = "D";
        public int icdRowStart = 2;
        public int icdRowEnd = 999;
        public string cptCodeColumn = "C";
        public string cptTextColumn = "E";
        public int cptRowStart = 2;
        public int cptRowEnd = 999;
    }
}
