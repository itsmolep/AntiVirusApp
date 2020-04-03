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

using System.ComponentModel;
using System.Reflection;
using System.Resources;
using System.Windows.Resources;


namespace AntiVirusApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.mainFrame.Navigate(new Uri("pages/home.xaml", UriKind.Relative));
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void NaviButton_Click(object sender, RoutedEventArgs e) //重构1：利用Tag属性整合了所有导航页
        {
            Button btn = sender as Button;
            this.mainFrame.Navigate(new Uri("pages/" + btn.Tag.ToString() + ".xaml", UriKind.Relative));
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) //实现无边框窗口拖动
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void Quit_Click(object sender, RoutedEventArgs e) //窗口关闭
        {
            this.Close();
        }

        private void Min_Click(object sender, RoutedEventArgs e) //窗口最小化
        {
            WindowState = WindowState.Minimized;
        }
    }
}