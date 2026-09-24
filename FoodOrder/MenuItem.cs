using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        private int _price;
        public int Price { get { return _price; }
            set
            {
                if (value < 0)
                {
                    _price = 0 ;
                }
                _price = value;
            }
        }
        public bool IsAvailable { get; set; }
        private static int _totalItems = 0;
        public void Sellout()
        {
            IsAvailable = false;
        }
        public void Restock()
        {
            IsAvailable = true;
        }
        public MenuItem(string name, string category, int price)
        {
            Name = name;
            Category = category;
            Price = price;
            IsAvailable = true;
            _totalItems++;
        }
        public List<string> GetMenuItemInfo()
        {
            List<string> info = new List<string>();
            info.Add($"Name: {Name}");
            info.Add($"Category: {Category}");
            info.Add($"Price: {Price}");
            info.Add($"Is Available: {IsAvailable}");
            return info;
        }
    }
}
