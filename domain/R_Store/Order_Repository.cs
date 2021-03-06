using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R_Store
{
    public class Order_Repository : IOOOrder_Repository //Наследование
    {
        private readonly List<Order> orders = new List<Order>();
        public Order Create()
        {
            int nextId = orders.Count + 1;
            var order = new Order(nextId, new OrderItem[0]);
            orders.Add(order);

            return order;
        }

        public Order GetById(int id)
        {
            return orders.Single(order => order.Id == id);
        }

        public void Update(Order order)
        {
            
        }
    }
}
