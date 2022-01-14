using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab14Wpf
{
    public enum ProductCategorys
    {
        Meal,
        HouseСhemicals
    }
    public class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public ProductCategorys ProductCategory { get; set; }

        public override string ToString()
        {
            return ProductName;
        }

    }
    
}
