using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder
{
    public class ConsoleView
    {
        public void ShowMenuItem(MenuItem item)
        {
            List<string> info = item.GetMenuItemInfo();
            foreach (string line in info)
            {
                Console.WriteLine(line);
            }
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowItems(List<MenuItem> items)
        {
            foreach (MenuItem item in items)
            {
                ShowMenuItem(item);
            }
        }
    }
}
