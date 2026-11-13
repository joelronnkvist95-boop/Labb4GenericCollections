using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4GenericCollections.Classes
{
    internal class Restaurant
    {
        List<MenuItem> menu = new List<MenuItem>();
        Queue<Order> orders = new Queue<Order>();

        public void AddToMenu(MenuItem menuItem)
        {
            menu.Add(menuItem);
            Console.WriteLine($"{menuItem} har lagts till i menyn.");
        }
        public void ShowMenu()
        {
            int menuCount = 1;
            foreach(MenuItem m in menu)
            {
                Console.WriteLine($"{menuCount}: {m}");
                menuCount++;
            }
        }
        public void CreateOrder(Order order)
        {
            orders.Enqueue(order);
            Console.WriteLine($"Beställning nr {orders.Count} har lagts till");
        }
        public void HandleOrder()
        {
            orders.Dequeue();
        }
        public void ShowOrders()
        {
            foreach(Order o in orders)
            {
                Console.WriteLine(o);
            }
        }
        public void ShowNextOrder()
        {
            Order nextOrder = orders.Peek();
            Console.WriteLine($"Nästa order i kön: {nextOrder}");
        }
        public void ShowOrderCount()
        {
            Console.WriteLine($"Det är {orders.Count} beställningar i kön");
        }

    }
}



