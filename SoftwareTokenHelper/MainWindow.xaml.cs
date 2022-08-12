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

        public MainWindow()
        {
            InitializeComponent();
            this.view = new MainWindowVM();
            this.DataContext = this.view;
        }

        private void TextBoxCrtFile_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LoadFile(out string file))
            {
                this.view.MutualAuthTab.CrtFile = file;
                this.view.MutualAuthTab.UpdateCrtContent();
            }
        }

        private void TextBoxPkeyFile_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LoadFile(out string file))
            {
                this.view.MutualAuthTab.PkeyFile = file;
                this.view.MutualAuthTab.UpdatePkeyContent();
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
    }
}
