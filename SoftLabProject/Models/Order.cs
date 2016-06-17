using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftLabProject.Models
{
    public class Order
    {
        public int ID;
        public DateTime OrderDate;
        public int CustomerID;
        public IList<OrderItem> OrderDetails;
    }
    public class OrderItem
    {

    }
}