using System.Configuration;

namespace hospitalAddIn
{
    internal static class Config
    {
        public static ConvertCodesConfigModel getConvertCodeConfig() {
            var config = new ConvertCodesConfigModel();
            // Read Config File
            overridefromConfig("icdCodesFilePath", ref config.icdCodesFilePath);
            overridefromConfig("icdCodeColumn", ref config.icdCodeColumn);
            overridefromConfig("icdTextColumn", ref config.icdTextColumn);
            overridefromConfigInt("icdRowStart", ref config.icdRowStart);
            overridefromConfigInt("icdRowEnd", ref config.icdRowEnd);

            overridefromConfig("cptCodesFilePath", ref config.cptCodesFilePath);
            overridefromConfig("cptCodeColumn", ref config.cptCodeColumn);
            overridefromConfig("cptTextColumn", ref config.cptTextColumn);
            overridefromConfigInt("cptRowStart", ref config.cptRowStart);
            overridefromConfigInt("cptRowEnd", ref config.cptRowEnd);

            return config;
        }

        private static void overridefromConfig(string configName, ref string field) { 
            string config = ConfigurationManager.AppSettings[configName];
            if (config != null) {
                field = config;
            }
        }

        private static void overridefromConfigInt(string configName, ref int field)
        {
            string config = ConfigurationManager.AppSettings[configName];
            if (config != null)
            {
                field = int.Parse(config);
            }
        }

        public static void saveConvertCodesConfig(ConvertCodesConfigModel config) {
            ConfigurationManager.AppSettings["icdCodesFilePath"] = config.icdCodesFilePath;
            ConfigurationManager.AppSettings["icdCodeColumn"] = config.icdCodeColumn;
            ConfigurationManager.AppSettings["icdTextColumn"] = config.icdTextColumn;
            ConfigurationManager.AppSettings["icdRowStart"] = config.icdRowStart.ToString();
            ConfigurationManager.AppSettings["icdRowEnd"] = config.icdRowEnd.ToString();
            ConfigurationManager.AppSettings["cptCodesFilePath"] = config.cptCodesFilePath;
            ConfigurationManager.AppSettings["cptCodeColumn"] = config.cptCodeColumn;
            ConfigurationManager.AppSettings["cptTextColumn"] = config.cptTextColumn;
            ConfigurationManager.AppSettings["cptRowStart"] = config.cptRowStart.ToString();
            ConfigurationManager.AppSettings["cptRowEnd"] = config.cptRowEnd.ToString();
        }

        public static HighlightKeywordsConfigModel getHighlightKeywordsConfig() {
            var config = new HighlightKeywordsConfigModel();
            // Read Config File
            overridefromConfig("keywordsFilePath", ref config.keywordsFilePath);
            return config;
        }

        public static void saveHighlightKeywordsConfig(HighlightKeywordsConfigModel config) {
            ConfigurationManager.AppSettings["keywordsFilePath"] = config.keywordsFilePath;
        }
    }
}
