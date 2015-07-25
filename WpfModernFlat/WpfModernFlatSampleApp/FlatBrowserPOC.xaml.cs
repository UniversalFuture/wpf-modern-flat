using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfModernFlat.Controls;
using Awesomium.Core;

namespace WpfModernFlatSampleApp
{
    /// <summary>
    /// Interaction logic for FlatBrowserPOC.xaml
    /// </summary>
    public partial class FlatBrowserPOC : FlatWindow
    {
        public FlatBrowserPOC()
        {
            InitializeComponent();
        }

        private void flatButton_Click(object sender, RoutedEventArgs e)
        {
            nav();
        }

        void nav()
        {
            if (Regex.IsMatch(flatTextBox.Text, @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$"))
            {
                web.Source = flatTextBox.Text.ToUri();
            }
            else
                search();

        }

        void search()
        {
            web.Source = $"https://www.google.com/search?q={flatTextBox.Text}".ToUri();
        }

        private void web_DocumentReady(object sender, DocumentReadyEventArgs e)
        {
            flatTextBox.Text = web.Source.ToString();
            btnBack.Visibility = web.CanGoBack() ? Visibility.Visible : Visibility.Hidden;
            btnForward.Visibility = web.CanGoForward() ? Visibility.Visible : Visibility.Hidden;
        }

        private void flatTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                nav();
        }

        private void appbar_heart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (web.IsLoading)
                web.Stop();
            else
                web.ExecuteJavascript("window.location.reload();");
        }

        private void appbar_magnify_MouseDown(object sender, MouseButtonEventArgs e)
        {
            search();
        }

        private void web_AddressChanged(object sender, UrlEventArgs e)
        {
            //MessageBox.Show("g");
        }

        private void web_LoadingFrameComplete(object sender, FrameEventArgs e)
        {
            flatTextBox.RightContent = Resources["appbar_heart"];
        }

        private void web_LoadingFrame(object sender, LoadingFrameEventArgs e)
        {
            flatTextBox.RightContent = Resources["appbar_cancel"];
        }

        private void web_LoadingFrameComplete(object sender, LoadingFrameFailedEventArgs e)
        {
            flatTextBox.RightContent = Resources["appbar_heart"];
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            web.GoBack();
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            web.GoForward();
        }
    }
}
