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
using System.Windows.Shapes;

using AntiVirusApp.Data;
using System.Collections.ObjectModel;

namespace AntiVirusApp
{
    /// <summary>
    /// FolderSelector.xaml 的交互逻辑
    /// </summary>
    public partial class FolderSelector : Window //路径选择窗口
    {
        #region Properties
        public string SelectedPath
        {
            get;
            private set;
        }

        public string InitialPath
        {
            set
            {
                string initialPath = value;
                BaseItem foundItem = (DataContext as BaseItem).FindFullPath(initialPath);
            }
        }

        #endregion

        #region CTOR
        public FolderSelector()
        {
            InitializeComponent();

            DataContext = new ItemsManager().Root;
        }
        #endregion

        #region UI events
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            SelectedPath = tbSelectedFolder.Text;

            DialogResult = true;
            Close();
        }

        private void tvFolders_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvi = e.OriginalSource as TreeViewItem;
            tvi.BringIntoView();
        }
        #endregion
    }
}
