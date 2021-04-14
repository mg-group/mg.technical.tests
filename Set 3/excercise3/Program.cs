using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex.Model;

namespace Ex
{
    //Exercise 3: How would you refactor the ShoppingCart class to allow adding new pricing 
    //            strategies without having to update its internal logic every time.
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();
            cart.Add(new OrderItem()
            {
                Product = "Bread",
                UOM = "grams",
                Quantity = 250
            }); 
            cart.Add(new OrderItem()
            {
                Product = "Coke",
                UOM = "bottle",
                Quantity = 4
            });
            cart.Add(new OrderItem()
            {
                Product = "Potato chips",
                UOM = "bag",
                Quantity = 4
            });

            Console.WriteLine("You pay ${0} for:\r\n{1}", cart.TotalAmount(), cart.Content());
            Console.Read();
        }
    }
}
