using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    //Single Responsibility Principle.Each object has one responsibility and this responsibility is completely encapsulated in a class
    //Liscov Substitution Principle. Objects of a superclass be replaceable with objects of its subclasses without breaking the application
    //Open Closed Principle. Objects or entities open for extension but closed for modification
    public class Product : Money, IProduct
    {
        public string Name { get; set; }

        public Product(string name, float price, Currency currency) : base(currency, price)
        {
            Name = name;
        }

        public void DecreasePrice(float amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Value can't be less than 0");
            }
            if (amount > GetAmount())
            {
                throw new ArgumentException("Price of the product can't be less than 0");
            }
            Subtract(amount);
        }
    }
}
