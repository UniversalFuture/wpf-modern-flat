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
using WpfModernFlat.Controls;

namespace WpfModernFlatSampleApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FlatWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FlatWindow_Loaded(object sender, RoutedEventArgs e)
        {
            new FlatBrowserPOC().Show();
        }
    }
}
