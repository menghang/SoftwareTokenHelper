using SoftwareTokenHelper.DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTokenHelper.ViewModel
{
    internal class TokenRequestTabVM : BaseViewModel
    {
        private string ppid = string.Empty;
        public string PPID
        {
            get => this.PPID;
            set => SetProperty(ref this.ppid, value);
        }

        private int count = 0;
        public string Count
        {
            get => this.count.ToString();
            set
            {
                try
                {
                    Convert.ToInt32(value);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                }
                OnPropertyChanged(nameof(this.Count));
            }
        }

        private string requestID = string.Empty;
        public string RequestID
        {
            get => this.requestID;
            set => SetProperty(ref this.requestID, value);
        }

        public string fileName = string.Empty;
        public string FileName
        { 
            get => this.fileName;
            set => SetProperty(ref this.fileName, value);
        }

        public ObservableCollection<AuthEntityRequestData> AuthEntityRequestTable { get; private set; } = new();

        public ObservableCollection<FileNameRequestData> FileNameRequestTable { get; private set; } = new();

        public ObservableCollection<TokenFileData> TokenFileTable { get; private set; } = new();
    }
}
