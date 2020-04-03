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
    /// QuickScan.xaml 的交互逻辑
    /// </summary>
    public partial class QuickScan : Page
    {
        private Dictionary<string, Uri> views = new Dictionary<string, Uri>(); //包含Progressing页面
        public QuickScan()
        {
            InitializeComponent();
            views.Add("Progressing", new Uri("pages/Progressing.xaml", UriKind.Relative));
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Start_Scan_Click(object sender, RoutedEventArgs e)
        {
            Progressing p = new Progressing();
            this.NavigationService.Navigate(p, DateTime.Now);
            //点击按钮后自动进行扫描，等待后续增加参数完善此函数
        }
    }
}
