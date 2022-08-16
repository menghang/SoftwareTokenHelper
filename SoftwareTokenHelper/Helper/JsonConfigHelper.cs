using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTokenHelper.Helper
{
    internal class JsonConfigHelper
    {
        public string ServerUrl { get; set; } = string.Empty;
        public string AuthEntityRequestUri { get; set; } = string.Empty;
        public string FileNameRequestUri { get; set; } = string.Empty;
        public string FileDownloadUri { get; set; } = string.Empty;
        public string RegisterAuthEntityUri { get; set; } = string.Empty;
        public string DestroyAuthEntityUri { get; set; } = string.Empty;
        public string UserAgent { get; set; } = string.Empty;

        private const string ConfigFile = "config.json";

        public bool LoadConfigFile()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
