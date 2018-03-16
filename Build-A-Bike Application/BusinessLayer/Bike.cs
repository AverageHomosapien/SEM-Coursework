using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

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
        public string Size { get; set; }
        public string Colour { get; set; }
        public string Wheels { get; set; }
        public string Gears { get; set; }
        public string Brakes { get; set; }
        public string Handlebars { get; set; }
        public string Saddle { get; set; }
        public bool ExtendedWarranty { get; set; }
        public double Cost { get; set; }


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
            Cost = Cost + 100;
        }

        // Updates the frame
        public void UpdateFrame(string firstCombo, string secondCombo, BikeStock stock)
        {
            double temp = 0;

            if (stock.FrameCost != 0)
            {
                Cost = Cost - stock.FrameCost;
            }

            temp = stock.Frame(firstCombo, secondCombo);
            Cost = Cost + temp;
            stock.FrameCost = temp;
        }

        // Updates the wheels
        public void UpdateWheels(string comboBox, BikeStock stock)
        {
            double temp = 0;
            
            if (stock.WheelCost!= 0)
            {
                Cost = Cost - stock.WheelCost;
            }

            temp = stock.Wheels(comboBox);
            Cost = Cost + temp;
            stock.WheelCost = temp;
        }

        // Updates the group set
        public void UpdateGroupSet(string firstCombo, string secondCombo, BikeStock stock)
        {
            double temp = 0;
            
            if (stock.GroupSetCost != 0)
            {
                Cost = Cost - stock.GroupSetCost;
            }

            temp = stock.GroupSet(firstCombo, secondCombo);
            Cost = Cost + temp;
            stock.GroupSetCost = temp;
        }

        // Updates the finishing set
        public void UpdateFinishingSet(string firstCombo, string secondCombo, BikeStock stock)
        {
            double temp = 0;
            
            if (stock.FinishingSetCost != 0)
            {
                Cost = Cost - stock.FinishingSetCost;
            }

            temp = stock.FinishingSet(firstCombo, secondCombo);
            Cost += temp;
            stock.FinishingSetCost = temp;
        }

        // Updates the total price for the bike
        public void UpdatePrice()
        {
            bool newBike = true;

            int count = 0;

            foreach (var order in Orders.Bikes)
            {
            // If Bike Id has already been added to the total orders cost
                if (order == BikeId)
                {
                    newBike = false;
                    break;
                    // deduct former cost
                }

                count++;
            }

            // If the bike is new
            if (newBike)
            {
                Orders.OrderCost += Cost;
                Orders.Bikes.Add(BikeId);
                Orders.BikeCosts.Add(Cost);
            }
            else
            {
                Orders.OrderCost -= Orders.BikeCosts[count];
                Orders.OrderCost += Cost;
                Orders.BikeCosts[count] = Cost;
            }
        }

        public void CancelOrder()
        {

        }

        // NEW BIKE METHOD???
    }
}
