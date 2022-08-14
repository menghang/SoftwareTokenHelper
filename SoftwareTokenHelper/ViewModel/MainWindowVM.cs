namespace SoftwareTokenHelper.ViewModel
{
    class MainWindowVM : BaseViewModel
    {

        public ClientSettingTabVM MutualAuthTab
        {
            get;
            private set;
        }

        public MainWindowVM()
        {
            this.MutualAuthTab = new ClientSettingTabVM();
        }
    }
}
