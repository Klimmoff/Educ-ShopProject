using Products_Is42_2023.Data.Context;
using Products_Is42_2023.Data.Core;
using Products_Is42_2023.Data.Models;
using Products_Is42_2023.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using Products_Is42_2023.Data.OtherClass;

namespace Products_Is42_2023.Data.ViewModels
{
    class AddProductViewModel : ValidObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        ProductRepository productRepository;

        public static int _manufacurerIdValue;
        public AddProductViewModel()
        {
            productRepository = new ProductRepository();
        }

        private RelayCommand addProduct;
        public RelayCommand AddProduct
        {
            get
            {
                return addProduct ??
                  (addProduct = new RelayCommand(async obj =>
                  {
                      Product product = new Product
                      {
                          Title = Title,
                          Description = Description,
                          Cost = Cost,
                          MainImagePath = ImgPath,
                          ManufacturerId = _manufacurerIdValue,
                          IsActive = !IsActive
                      };

                      if(product != null)
                      {
                          await productRepository.AddProduct(product);
                          Title = string.Empty;
                          Cost = 0;
                          Description = string.Empty;
                          ImgPath = string.Empty;
                          IsActive = false;
                      }
                  }));
            }
        }

        
        private string _title;
        [Required(ErrorMessage = "Название должно быть заполнено!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Короткое название продукта")]
        public string Title
        {
            get { return _title; }
            set
            {
                ValidateProperty(value, "Title");
                OnPropertyChanged(ref _title, value);
            }
        }
        private int _cost;
        [Required(ErrorMessage = "Ценник отсутствует")]
        public int Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                ValidateProperty(value, "Cost");
                OnPropertyChanged();
            }
        }
        private string _description;
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Описание должно иметь более 5 символов")]

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                ValidateProperty(value, "Description");
                OnPropertyChanged();
            }
        }
        private string _imgPath;
        public string ImgPath
        {
            get => _imgPath;
            set
            {
                _imgPath = value;
                OnPropertyChanged();
            }
        }
        private int _manufacturerId;


        public int ManufacturerId
        {
            get => _manufacturerId;
            set
            {
                _manufacturerId = _manufacurerIdValue;
                OnPropertyChanged();
            }
        }
        private bool _isActive;


        public bool IsActive
        {
            get => _isActive;
            set
            {
                _isActive = value;
                OnPropertyChanged();
            }
        }
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private List<Manufacturer> Manufacturers() => ConnectDb.db.Manufacturer.ToList();

        public void CmbxCreater(ComboBox comboBox)
        {
            comboBox.SelectedValuePath = "Id";
            comboBox.DisplayMemberPath = "Name";
            comboBox.ItemsSource = Manufacturers();
        }

        public void SetMessageInStatus(string phoneModel)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Start();
            FrameObj.statusBarText.Text = $"Модель телефона {phoneModel} успешно добавлена в БД";
        }

        private void timerTick(object sender, EventArgs e)
        {
            FrameObj.statusBarText.Text = string.Empty;
        }
        private void ValidateProperty<T>(T value, string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = name
            });
        }
    }
}
