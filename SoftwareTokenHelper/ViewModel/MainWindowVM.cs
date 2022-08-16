namespace SoftwareTokenHelper.ViewModel
{
    class MainWindowVM : BaseViewModel
    {

        public ClientSettingTabVM ClientSettingTab
        {
            get;
            private set;
        }

        public TokenRequestTabVM TokenRequestTab
        {
            get;
            private set;
        }

        public ServerSettingTabVM ServerSettingTab
        {
            get;
            private set;
        }

        public MainWindowVM()
        {
            this.ClientSettingTab = new();
            this.TokenRequestTab = new();
            this.ServerSettingTab = new();
        }
    }
}
