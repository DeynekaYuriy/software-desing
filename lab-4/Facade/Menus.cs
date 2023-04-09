using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4.Facade
{
    public class MenuFacade
    {
        public Order BigMacMenu()
        {
            Order order = new Order();
            order.Items.Add(new BigMacBurger(2));
            order.Items.Add(new Cola(2));
            order.Items.Add(new Sauce(2));
            order.Items.Add(new Fries(2));
            order.Items.Add(new Napkin(6));
            return order;
        }
        public Order BigMacMenuWithPakaging()
        {
            Order order = BigMacMenu();
            order.Items.Add(new Packaging(1));
            return order;
        }
    }
}
