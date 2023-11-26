using Products_Is42_2023.Data;
using Products_Is42_2023.Pages;
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

namespace Products_Is42_2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameObj.mainFrame = FrameMain;
            FrameObj.statusBarText = statusText;
            FrameObj.mainFrame.Navigate(new PageMain());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (!FrameObj.mainFrame.CanGoBack)
                MessageBox.Show("Мы на главной");
            else
                FrameObj.mainFrame.GoBack();
        }

        private void btnFaq_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
