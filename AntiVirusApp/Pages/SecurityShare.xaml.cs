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

namespace AntiVirusApp.Pages
{
    /// <summary>
    /// SecurityShare.xaml 的交互逻辑
    /// </summary>
    public partial class SecurityShare : Page
    {
        public SecurityShare()
        {
            InitializeComponent();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
        private void NaviButton_Click(object sender, RoutedEventArgs e) //重构1：利用Tag属性整合了所有导航页
        {
            Button btn = sender as Button;
            this.frame.Navigate(new Uri("pages/" + btn.Tag.ToString() + ".xaml", UriKind.Relative));
        }

    }
}
