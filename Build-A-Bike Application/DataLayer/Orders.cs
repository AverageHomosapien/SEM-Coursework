﻿using System;
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
        public static int OrderId = 0;

        public static double OrderCost = 0;

        public static List<int> Bikes = new List<int>();
        public static List<double> BikeCosts = new List<double>();
    }
}
