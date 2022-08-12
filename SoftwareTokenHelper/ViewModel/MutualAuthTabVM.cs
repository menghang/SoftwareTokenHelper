using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTokenHelper.ViewModel
{
    internal class MutualAuthTabVM : BaseViewModel
    {
        private string crtFile = string.Empty;
        public string CrtFile
        {
            get => this.crtFile;
            set => SetProperty(ref this.crtFile, value);
        }

        private string crtContent = string.Empty;
        public string CrtContent
        {
            get => this.crtContent;
            set => SetProperty(ref this.crtContent, value);
        }

        private string pkeyFile = string.Empty;
        public string PkeyFile
        {
            get => this.pkeyFile;
            set => SetProperty(ref this.pkeyFile, value);
        }

        private string pkeyContent = string.Empty;
        public string PkeyContent
        {
            get => this.pkeyContent;
            set => SetProperty(ref this.pkeyContent, value);
        }

        public bool UpdateCrtContent()
        {
            bool res = UpdateFileContent(this.CrtFile, out string content);
            this.CrtContent = content;
            return res;
        }

        public bool UpdatePkeyContent()
        {
            bool res = UpdateFileContent(this.PkeyFile, out string content);
            this.PkeyContent = content;
            return res;
        }

        private static bool UpdateFileContent(string file, out string content)
        {
            try
            {
                using (FileStream fs = new(file, FileMode.Open))
                {
                    using (StreamReader sr = new(fs))
                    {
                        content = sr.ReadToEnd();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
                content = string.Empty;
                return false;
            }
        }
    }
}
