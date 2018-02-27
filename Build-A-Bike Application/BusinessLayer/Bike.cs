using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bike
    {
        public Bike(int orderId)
        {
            OrderId = orderId;
        }

        public int BikeId { get; private set; }
        public int OrderId { get; private set; }

        private string _bikeSize;
        public string BikeSize
        {
            get => _bikeSize;
            set
            {
                if (value != "small" || value != "medium" || value != "large")
                {
                    throw new Exception
                        ("Please ensure that you are entering a valid bike size.");
                }
                _bikeSize = value;
            }
        }

        public string Frame { get; set; }
        public string GroupSet { get; set; }
        public string FinishingSet { get; set; }
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

        }

        public void CancelOrder()
        {

        }

        // NEW BIKE METHOD???
    }
}
