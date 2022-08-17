using SoftwareTokenHelper.Helper;
using SoftwareTokenHelper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SoftwareTokenHelper
{
    public partial class MainWindow : Window
    {
        private readonly MainWindowVM view;
        private readonly ConfigHelper config;

        public MainWindow()
        {
            this.config = new();
            InitializeComponent();
            this.view = new MainWindowVM();
            this.DataContext = this.view;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (await this.config.LoadConfig())
            {
                this.view.ServerSettingTab.LoadConfig(this.config);
            }
        }

        private void TextBoxCrtFile_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LoadFile(out string file))
            {
                this.view.ClientSettingTab.CrtFile = file;
                this.view.ClientSettingTab.UpdateCrtContent();
            }
        }

        private void TextBoxPkeyFile_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LoadFile(out string file))
            {
                this.view.ClientSettingTab.PkeyFile = file;
                this.view.ClientSettingTab.UpdatePkeyContent();
            }
        }

        private static bool LoadFile(out string file)
        {
            Microsoft.Win32.OpenFileDialog fileDialog = new();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Select file";
            fileDialog.Filter = "All Files|*.*";
            if (fileDialog.ShowDialog() == true)
            {
                file = fileDialog.FileName;
                return true;
            }
            else
            {
                file = string.Empty;
                return false;
            }
        }

        private async void ButtonServerSettingSaveConfig_Click(object sender, RoutedEventArgs e)
        {
            this.view.ServerSettingTab.ExportConfig(this.config);
            await this.config.SaveConfig();
        }

        private async void ButtonServerSettingLoadConfig_Click(object sender, RoutedEventArgs e)
        {
            if (await this.config.LoadConfig())
            {
                this.view.ServerSettingTab.LoadConfig(this.config);
            }
        }
    }
}
