namespace SoftwareTokenHelper.ViewModel
{
    class MainWindowVM : BaseViewModel
    {

        public MutualAuthTabVM MutualAuthTab
        {
            get;
            private set;
        }

        public MainWindowVM()
        {
            this.MutualAuthTab = new MutualAuthTabVM();
        }
    }
}
