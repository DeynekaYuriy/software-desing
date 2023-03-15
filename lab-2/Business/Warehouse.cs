using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    //Single Responsibility Principle. Each object has one responsibility and this responsibility is completely encapsulated in a class
    //Liscov Substitution Principle. Objects of a superclass be replaceable with objects of its subclasses without breaking the application
    public class Warehouse : Product
    {
        public string Unit { get; set; }
        public uint Quantity { get; set; }
        public DateTime LastAdmissionDate { get; set; }
        public Warehouse(string name, string unit, uint quantity, DateTime lastAdmissionDate, float price, Currency currency) : base(name, price, currency)
        {
            Unit = unit;
            Quantity = quantity;
            LastAdmissionDate = lastAdmissionDate;
        }
    }
}
