using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTokenHelper.ViewModel
{
    internal class ServerSettingTabVM : BaseViewModel
    {
        private string serverUrl = string.Empty;
        public string ServerUrl
        {
            get => this.serverUrl;
            set => this.SetProperty(ref this.serverUrl, value);
        }

        private string authEntityRequestUri = string.Empty;
        public string AuthEntityRequestUri
        {
            get => this.authEntityRequestUri;
            set => this.SetProperty(ref this.authEntityRequestUri, value);
        }

        private string fileNameRequestUri = string.Empty;
        public string FileNameRequestUri
        {
            get => this.fileNameRequestUri;
            set => this.SetProperty(ref this.fileNameRequestUri, value);
        }

        private string fileDownloadUri = string.Empty;
        public string FileDownloadUri
        {
            get => this.fileDownloadUri;
            set => this.SetProperty(ref this.fileDownloadUri, value);
        }

        private string registerAuthEntityUri = string.Empty;
        public string RegisterAuthEntityUri
        {
            get => this.registerAuthEntityUri;
            set => this.SetProperty(ref this.registerAuthEntityUri, value);
        }

        private string destroyAuthEntityUri = string.Empty;
        public string DestroyAuthEntityUri
        {
            get => this.destroyAuthEntityUri;
            set => this.SetProperty(ref this.destroyAuthEntityUri, value);
        }

        private string userAgent = string.Empty;
        public string UserAgent
        {
            get => this.userAgent;
            set => SetProperty(ref this.userAgent, value);
        }
    }
}
