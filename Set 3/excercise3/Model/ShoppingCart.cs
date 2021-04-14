using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Model
{
    public class ShoppingCart
    {
        private readonly List<OrderItem> _orderItems;

        public ShoppingCart()
        {
            _orderItems = new List<OrderItem>();
        }

        public IEnumerable<OrderItem> OrderItems
        {
            get { return _orderItems; }
        }

        public void Add(OrderItem orderItem)
        {
            _orderItems.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;
            foreach (OrderItem orderItem in OrderItems)
            {
                if (orderItem.UOM.Equals("grams", StringComparison.InvariantCultureIgnoreCase))
                {
                    total += orderItem.Quantity * 6m / 1000;
                }
                else if (orderItem.UOM.Equals("bottle", StringComparison.InvariantCultureIgnoreCase))
                {
                    total += orderItem.Quantity * 3m; 
                }
                else if (orderItem.UOM.Equals("bag", StringComparison.InvariantCultureIgnoreCase))
                {
                    total += orderItem.Quantity * .2m;
                    int setsOfFour = orderItem.Quantity / 4;
                    total -= setsOfFour * .15m; //discount on groups of 4 items
                }
            }
            return total;
        }

        public string Content()
        {
            return string.Join("\r\n", OrderItems.Select(item => string.Format("{0} {1} of {2}", item.Quantity , item.UOM, item.Product))); 
        }
    }
}
