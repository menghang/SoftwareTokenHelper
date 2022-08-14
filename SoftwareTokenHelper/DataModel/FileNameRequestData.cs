using SoftwareTokenHelper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTokenHelper.DataModel
{
    internal class FileNameRequestData : BaseViewModel
    {
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
