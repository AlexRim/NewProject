using System;
using System.Configuration;



namespace MyProject.Utils
{
   public static class Settings
    {
        public static string BaseURL { get; set; }
        public static  string BrowserName { get; set; }
        public static int ImplicitTimeout { get; set; }
        public static int ExplicitTimeout { get; set; }        
        private static string Get(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        static Settings()
        {
            BaseURL = Get("URL");
            BrowserName = Get("browser");
            ImplicitTimeout = Convert.ToInt32(Get("implicitTimeout"));
            ExplicitTimeout= Convert.ToInt32(Get("explicitTimeout"));
        }
    }
}
