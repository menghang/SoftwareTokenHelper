using SoftwareTokenHelper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTokenHelper.DataModel
{
    internal class AuthEntityRequestData : BaseViewModel
    {
        private bool done = false;
        public bool Done
        {
            get => this.done;
            set => SetProperty(ref this.done, value);
        }
        private string ppid = string.Empty;
        public string PPID
        {
            get => this.ppid;
            set => SetProperty(ref this.ppid, value);
        }
        private string count = string.Empty;
        public string Count
        {
            get => this.count;
            set => SetProperty(ref this.count, value);
        }
        private string requestID = string.Empty;
        public string RequestID
        {
            get => this.requestID;
            set => SetProperty(ref this.requestID, value);
        }
        private string downloadAvailability = string.Empty;
        public string DownloadAvailability
        {
            get => this.downloadAvailability;
            set => SetProperty(ref this.downloadAvailability, value);
        }
        private string timestamp = string.Empty;
        public string Timestamp
        {
            get => this.timestamp;
            set => SetProperty(ref this.timestamp, value);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(AuthEntityRequestData))
            {
                return false;
            }
            else
            {
                return (obj as AuthEntityRequestData)!.RequestID.Equals(this.RequestID);
            }
        }

        public override int GetHashCode()
        {
            return this.RequestID.GetHashCode();
        }
    }
}
