namespace hospitalAddIn
{
    internal class ConvertCodesConfigModel
    {
        public string icdCodesFilePath { get; set; }
        public string cptCodesFilePath { get; set; }
        public string icdCodeColumn { get; set; } = "B";
        public string icdTextColumn { get; set; } = "D";
        public int icdRowStart { get; set; } = 2;
        public int icdRowEnd { get; set; } = 999;
        public string cptCodeColumn { get; set; } = "C";
        public string cptTextColumn { get; set; } = "E";
        public int cptRowStart { get; set; } = 2;
        public int cptRowEnd { get; set; } = 999;
    }
}
