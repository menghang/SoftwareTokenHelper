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
            get => this.ppid;
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

        private ObservableCollection<AuthEntityRequestData> authEntityRequestTable = new();
        public ObservableCollection<AuthEntityRequestData> AuthEntityRequestTable
        {
            get => this.authEntityRequestTable;
            set => SetProperty(ref this.authEntityRequestTable, value);
        }
        public AuthEntityRequestData SelectedAuthEntityRequest { get; set; } = new();

        private ObservableCollection<FileNameRequestData> fileNameRequestTable = new();
        public ObservableCollection<FileNameRequestData> FileNameRequestTable
        {
            get => this.fileNameRequestTable;
            set => SetProperty(ref this.fileNameRequestTable, value);
        }
        public FileNameRequestData SelectedFileNameRequest { get; set; } = new();


        private ObservableCollection<TokenData> tokenTable = new();
        public ObservableCollection<TokenData> TokenTable
        {
            get => this.tokenTable;
            set => SetProperty(ref this.tokenTable, value);
        }
        public TokenData SelectedToken { get; set; } = new();

    }
}
