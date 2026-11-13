using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Labb4GenericCollections.Classes
{
    internal class Order
    {
        // I denna klass använder vi i stället private fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }
        public override string ToString()
        {
            return $"Order ID:{_orderId}\n Table number: {_tableNumber}\n Order items: {_orderItems}";
        }
    }
}
