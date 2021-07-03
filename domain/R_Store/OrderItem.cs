using System;
using System.Collections.Generic;
using System.Text;

namespace R_Store
{
   public class OrderItem
    {
        public int ProductId { get; }
        public int Count { get; }
        public decimal Price { get; }
        public OrderItem(int productid, int count, decimal price)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException("Count must be greater than zero.");
            ProductId = productid;
            Count = count;
            Price = price;
        }
    }
}
