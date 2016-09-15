using DotNetBrowser;
using DotNetBrowser.WPF;
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

namespace Sample_WPFBrowser_MouseMove
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BrowserView webView;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            webView = new WPFBrowserView(BrowserFactory.Create(BrowserType.HEAVYWEIGHT));
            WPFWeb.Children.Add((UIElement)webView.GetComponent());

            webView.Browser.LoadURL("teamdev.com");
        }

        //WPFBrowser component
        private void WPFWeb_MouseMove(object sender, MouseEventArgs e)
        {
            labelX.Content = "X:" + Convert.ToInt16(e.GetPosition(WPFWeb).X);
            labelY.Content = "Y:" + Convert.ToInt16(e.GetPosition(WPFWeb).Y);
        }

        //All components
        private void mainWPF_MouseMove(object sender, MouseEventArgs e)
        {
            allLabelX.Content = "X:" + Convert.ToInt16(e.GetPosition(mainWPF).X);
            allLabelY.Content = "Y:" + Convert.ToInt16(e.GetPosition(mainWPF).Y);
        }
    }
}
