using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R_Store
{
    public class Order
    {
        public int Id { get; }
        private List<OrderItem> items;
        public IReadOnlyCollection<OrderItem> Items
        {
            get { return items; }
        }

        public int TotalCount //считаем кол-во
        {
            get { return items.Sum(item => item.Count); }
        }
        public int TotalPrice
        {
            get { return (int)items.Sum(item => item.Price * item.Count); }
        
        }
        public Order(int id, IEnumerable<OrderItem> items)
        {
            if (items == null)
                throw new ArgumentException(nameof(items));

            Id = id;
            this.items = new List<OrderItem>(items);
        
        
        }
        public void AddItem(Product product, int count)
        {
            if (product == null)
                throw new ArgumentException(nameof(Product));

            var item = items.SingleOrDefault(x => x.ProductId == product.Id);
            if (item == null)
            {
                items.Add(new OrderItem(product.Id, count, product.Price));
            }
            else
            {
                items.Remove(item);
                items.Add(new OrderItem(product.Id, item.Count + count, product.Price));
            }
        }

    }
}
