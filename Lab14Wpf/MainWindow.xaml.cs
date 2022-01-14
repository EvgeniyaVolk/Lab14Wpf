using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab14Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Печенье",
                Price = 120,
                Image= @"D:\Microsoft Visual Studio\РАЗРАБОТКА ПО ТЕХНОЛОГИИ WINDOWS PRESENTATION FOUNDATION\Lab14Wpf\Lab14Wpf\Data\food.png",
                ProductCategory = ProductCategorys.Meal
            });
            products.Add(new Product()
            {
                ProductName = "Стейк",
                Price = 500,
                Image = @"D:\Microsoft Visual Studio\РАЗРАБОТКА ПО ТЕХНОЛОГИИ WINDOWS PRESENTATION FOUNDATION\Lab14Wpf\Lab14Wpf\Data\food.png",
                ProductCategory = ProductCategorys.Meal
            });
            products.Add(new Product()
            {
                ProductName = "Багет",
                Price = 80,
                Image = @"D:\Microsoft Visual Studio\РАЗРАБОТКА ПО ТЕХНОЛОГИИ WINDOWS PRESENTATION FOUNDATION\Lab14Wpf\Lab14Wpf\Data\food.png",
                ProductCategory = ProductCategorys.Meal
            });
            products.Add(new Product()
            {
                ProductName = "Мыло",
                Price = 50,
                Image= @"D:\Microsoft Visual Studio\РАЗРАБОТКА ПО ТЕХНОЛОГИИ WINDOWS PRESENTATION FOUNDATION\Lab14Wpf\Lab14Wpf\Data\химия.png",
                ProductCategory = ProductCategorys.HouseСhemicals
            });
            products.Add(new Product()
            {
                ProductName = "Очиститель",
                Price = 150,
                Image = @"D:\Microsoft Visual Studio\РАЗРАБОТКА ПО ТЕХНОЛОГИИ WINDOWS PRESENTATION FOUNDATION\Lab14Wpf\Lab14Wpf\Data\химия.png",
                ProductCategory = ProductCategorys.HouseСhemicals
            });
            products.Add(new Product()
            {
                ProductName = "Спрей",
                Price = 250,
                Image = @"D:\Microsoft Visual Studio\РАЗРАБОТКА ПО ТЕХНОЛОГИИ WINDOWS PRESENTATION FOUNDATION\Lab14Wpf\Lab14Wpf\Data\химия.png",
                ProductCategory = ProductCategorys.HouseСhemicals
            });
            lstBox.ItemsSource = products;
        }
    }
}
