using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bike
    {
        public Bike(int orderId, int bikeId)
        {
            OrderId = orderId;
            BikeId = bikeId;   
            ExtendedWarranty = false;
        }

        public int BikeId { get; private set; }
        public int OrderId { get; private set; }
        public string BikeSize { get; set; }
        public string Frame { get; set; }
        public string Colour { get; set; }
        public string Wheels { get; set; }
        public string Gears { get; set; }
        public string Brakes { get; set; }
        public string Handlebars { get; set; }
        public string Saddle { get; set; }
        public bool ExtendedWarranty { get; set; }
        public int Cost { get; set; }

        public int CalculateCost()
        {
            return -1;
        }

        public int CalculateTimescale()
        {
            return -1;
        }

        public void AddWarranty()
        {
            ExtendedWarranty = true;
        }

        public void CancelOrder()
        {

        }

        // NEW BIKE METHOD???
    }
}
