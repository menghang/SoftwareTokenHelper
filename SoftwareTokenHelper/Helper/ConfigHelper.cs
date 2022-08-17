using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTokenHelper.Helper
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class ConfigHelper
    {
        [JsonProperty]
        public string ServerUrl { get; set; } = string.Empty;
        [JsonProperty]
        public string AuthEntityRequestUri { get; set; } = string.Empty;
        [JsonProperty]
        public string FileNameRequestUri { get; set; } = string.Empty;
        [JsonProperty]
        public string FileDownloadUri { get; set; } = string.Empty;
        [JsonProperty]
        public string RegisterAuthEntityUri { get; set; } = string.Empty;
        [JsonProperty]
        public string DestroyAuthEntityUri { get; set; } = string.Empty;
        [JsonProperty]
        public string UserAgent { get; set; } = string.Empty;

        private const string ConfigFile = "SoftwareTokenHelper.config.json";

        public async Task<bool> SaveConfig()
        {
            try
            {
                using (FileStream fs = new(ConfigFile, FileMode.Create))
                {
                    using (StreamWriter sw = new(fs, Encoding.UTF8))
                    {
                        string json = JsonConvert.SerializeObject(this, Formatting.Indented);
                        await sw.WriteAsync(json);
                        await sw.FlushAsync();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Fail to save config");
                return false;
            }
        }

        public async Task<bool> LoadConfig()
        {
            try
            {
                using (FileStream fs = new(ConfigFile, FileMode.Open))
                {
                    using (StreamReader sr = new(fs, Encoding.UTF8))
                    {
                        string json = await sr.ReadToEndAsync();
                        ConfigHelper? config = JsonConvert.DeserializeObject<ConfigHelper>(json);
                        if (config != null)
                        {
                            this.ServerUrl = config.ServerUrl;
                            this.AuthEntityRequestUri = config.AuthEntityRequestUri;
                            this.FileNameRequestUri = config.FileNameRequestUri;
                            this.FileDownloadUri = config.FileDownloadUri;
                            this.RegisterAuthEntityUri = config.RegisterAuthEntityUri;
                            this.DestroyAuthEntityUri = config.DestroyAuthEntityUri;
                            this.UserAgent = config.UserAgent;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Fail to read config");
                return false;
            }
        }
    }
}
