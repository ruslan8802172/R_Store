using System;

namespace R_Store
{
    public class Product
    {
        public int Id { get; }

        public string Title { get; }
        public string Information { get; }
        public string Company { get; }
        public decimal Price { get; } //

        //Полиморфизм - Его суть заключается в том, что один фрагмент кода может работать с разными типами данных.
        public Product(int id, string title,string information, string company, decimal price) //Полиморфизм - Его суть заключается в том, что один фрагмент кода может работать с разными типами данных.
        {
            Id = id; 
            Title = title;
            Information = information;
            Company = company;
            Price = price;
         
         
        }

    }
}