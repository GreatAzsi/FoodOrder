using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder
{
    public class Order
    {
        private List<MenuItem> _menuItems;
        public int ItemCount { get { return _menuItems.Count; } }
        public Order() 
        {
            _menuItems = new List<MenuItem>();
        }
        public bool Add(MenuItem item)
        {
            if (item.IsAvailable)
            {
                _menuItems.Add(item);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int TotalPrice()
        {
            return _menuItems.Sum(item => item.Price);
        }
        public string GetSummary() 
        {
            return $"Total items: {ItemCount}, Total price: {TotalPrice()}";
        }
    }
}
