namespace hospitalAddIn
{
    internal static class Config
    {
        public static ConvertCodesConfigModel getConvertCodeConfig() {
            var config = new ConvertCodesConfigModel();
            return config;
        }

        static void saveConvertCodesConfig(ConvertCodesConfigModel config) { }

        public static HighlightKeywordsConfigModel getHighlightKeywordsConfig() {
            return new HighlightKeywordsConfigModel();
        }

        static void saveHighlightKeywordsConfig(HighlightKeywordsConfigModel config) { 
        
        }
    }
}
