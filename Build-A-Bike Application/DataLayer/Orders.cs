using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    /// <summary>
    /// Contains the order number
    /// </summary>
    public static class Orders
    {
        // Need to add an incrementing feature after the order has been fully completed and paid for
        public static int OrderId = 905;

        public static double OrderCost = 0;

        public static List<int> bikes = new List<int>();
        public static List<double> bikeCosts = new List<double>();
    }
}
