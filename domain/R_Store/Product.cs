using System;

namespace R_Store
{
    public class Product
    {
        public int Id { get; }

        public string Title { get; }

        public string Company { get; }

        public string Information { get; }

        public string Price { get; } //или можно decimal
        public Product(int id, string title,string information, string company, string price)
        {
            Id = id; 
            Title = title;
            Information = information;
            Company = company;
            Price = price;
         
         
        }

    }
}