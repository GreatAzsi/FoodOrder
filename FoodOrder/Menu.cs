using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder
{
    public class Menu
    {
        private List<MenuItem> _menuItems;
        public Menu(string MenuName)
        {
            _menuItems = new List<MenuItem>();
        }
        public void AddMenuItem(MenuItem item)
        {
            _menuItems.Add(item);
        }
        public void RemoveMenuItem(MenuItem item)
        {
            _menuItems.Remove(item);
        }
        public MenuItem FindByName(string name)
        {
            MenuItem foundItem = _menuItems.Find(item => item.Name == name);
            if (foundItem != null)
            {
                return foundItem;
            }
            else
            {
                return null;
            }
        }
        public List<MenuItem> AvailableItems()
        {
            return _menuItems.Where(item => item.IsAvailable).ToList();
        }
        public List<MenuItem> ItemsByCategory(string category)
        {
            return _menuItems.Where(item => item.Category == category).ToList();
        }
        public double AveragePrice(string category)
        {
            List<MenuItem> itemsInCategory = ItemsByCategory(category);
            if (itemsInCategory.Count() > 0)
            {
                return itemsInCategory.Average(item => item.Price);
            }
            else
            {
                return 0;
            }
        }
    }
}
