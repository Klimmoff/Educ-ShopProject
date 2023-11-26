using Products_Is42_2023.Data.Models;
using Products_Is42_2023.Data.ViewModels;
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
    /// Логика взаимодействия для PageAddProduct.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {
        AddProductViewModel model = new AddProductViewModel();
        public PageAddProduct()
        {
            InitializeComponent();
            model.CmbxCreater(cmbxProductManufacturer);
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmbxProductManufacturer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddProductViewModel._manufacurerIdValue = (int)cmbxProductManufacturer.SelectedValue;
        }
    }
}
