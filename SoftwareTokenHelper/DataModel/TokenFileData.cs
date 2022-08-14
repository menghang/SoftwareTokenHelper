using SoftwareTokenHelper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTokenHelper.DataModel
{
    internal class TokenFileData : BaseViewModel
    {
        private string ppid = string.Empty;
        public string PPID
        {
            get => this.ppid;
            set => SetProperty(ref this.ppid, value);
        }
        private string tokenID = string.Empty;
        public string TokenID
        {
            get => this.tokenID;
            set => SetProperty(ref this.tokenID, value);
        }
        private string token = string.Empty;
        public string Token
        {
            get => this.token;
            set => SetProperty(ref this.token, value);
        }
        private string crc = string.Empty;
        public string CRC
        {
            get => this.crc;
            set => SetProperty(ref this.crc, value);
        }
        private string requestID = string.Empty;
        public string RequestID
        {
            get => this.requestID;
            set => SetProperty(ref this.requestID, value);
        }
        private string fileName = string.Empty;
        public string FileName
        {
            get => this.fileName;
            set => SetProperty(ref this.fileName, value);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(TokenFileData))
            {
                return false;
            }
            else
            {
                return (obj as TokenFileData)!.TokenID.Equals(this.TokenID);
            }
        }

        public override int GetHashCode()
        {
            return this.TokenID.GetHashCode();
        }
    }
}
