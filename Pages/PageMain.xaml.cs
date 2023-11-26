using Products_Is42_2023.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Products_Is42_2023.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.mainFrame.Navigate(new PageProduct());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.mainFrame.Navigate(new PageAddProduct());
        }
    }
}
