namespace FoodOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem burger = new MenuItem("Cheeseburger", "Food", 8);
            MenuItem cola = new MenuItem("Coca-Cola", "Drink", 5);
            ConsoleView view = new ConsoleView();
            view.ShowMenuItem(burger);
            view.ShowMenuItem(cola);
            view.ShowMessage("-----------------------------------------------------------------------");
            MenuItem pizza = new MenuItem("Pizza", "Food", 12);
            MenuItem water = new MenuItem("Water", "Drink", 2);
            MenuItem salad = new MenuItem("Salad", "Food", 7);
            List<MenuItem> menuItems = new List<MenuItem> { burger, cola, pizza, water, salad };
            
            view.ShowItems(menuItems);
            view.ShowMessage($"Total menu items: {menuItems.Count}");
            view.ShowMessage("-----------------------------------------------------------------------");
            Menu menu = new Menu("Main Menu");
            menu.AddMenuItem(burger);
            menu.AddMenuItem(cola);
            menu.AddMenuItem(pizza);
            menu.AddMenuItem(water);
            menu.AddMenuItem(salad);
            if (menu.FindByName("Pizza") != null)
            {
                view.ShowMessage($"Found menu item: {menu.FindByName("Pizza").Name}");
            }
            else
            {
                view.ShowMessage("Menu item not found.");
            }
            
            
            view.ShowMessage("-----------------------------------------------------------------------");
            view.ShowItems(menu.AvailableItems());
            view.ShowMessage("-----------------------------------------------------------------------");
            //view.ShowItems(menu.ItemsByCategory("Sports"));
            view.ShowItems(menu.ItemsByCategory("Food"));
            view.ShowItems(menu.ItemsByCategory("Drink"));
            view.ShowMessage("-----------------------------------------------------------------------");

            Order order = new Order();
            order.Add(burger);
            pizza.Sellout();
            order.Add(pizza);
            view.ShowMessage(order.GetSummary());

        }
    }
}
