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
        public string BikeSize { get; set; }
        public string Frame { get; set; }
        public string Colour { get; set; }
        public string Wheels { get; set; }
        public string Gears { get; set; }
        public string Brakes { get; set; }
        public string Handlebars { get; set; }
        public string Saddle { get; set; }
        public bool ExtendedWarranty { get; set; }
        public double Cost { get; set; }

        public double FrameCost { get; set; }
        public double WheelCost { get; set; }
        public double GroupSetCost { get; set; }
        public double FinishingSetCost { get; set; }

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
            MessageBox.Show("Added warranty");
        }

        // Updates the frame
        public void UpdateFrame(string firstCombo, string secondCombo)
        {
            double temp = 0;

            if (FrameCost != 0)
            {
                Cost = Cost - FrameCost;
            }

            temp = BikeStock.Frame(firstCombo, secondCombo);
            Cost = Cost + temp;
            FrameCost= temp;
        }

        // Updates the wheels
        public void UpdateWheels(string comboBox)
        {
            double temp = 0;
            
            if (WheelCost!= 0)
            {
                Cost = Cost - WheelCost;
                MessageBox.Show("Deducting cost");
            }

            temp = BikeStock.Wheels(comboBox);
            Cost = Cost + temp;
            WheelCost = temp;
        }

        // Updates the group set
        public void UpdateGroupSet(string firstCombo, string secondCombo)
        {
            double temp = 0;
            
            if (GroupSetCost != 0)
            {
                Cost = Cost - GroupSetCost;
                MessageBox.Show("Deducting cost");
            }

            temp = BikeStock.GroupSet(firstCombo, secondCombo);
            Cost = Cost + temp;
            GroupSetCost = temp;
        }

        // Updates the finishing set
        public void UpdateFinishingSet(string firstCombo, string secondCombo)
        {
            double temp = 0;
            
            if (FinishingSetCost != 0)
            {
                Cost = Cost - FinishingSetCost;
                MessageBox.Show("Deducting cost");
            }

            temp = BikeStock.FinishingSet(firstCombo, secondCombo);
            Cost += temp;
            FinishingSetCost = temp;
        }

        // Updates the total price for the bike
        public void UpdatePrice()
        {
            bool newBike = true;

            int count = 0;

            foreach (var order in Orders.bikes)
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
                Orders.bikes.Add(BikeId);
                Orders.bikeCosts.Add(Cost);
            }
            else
            {
                Orders.OrderCost -= Orders.bikeCosts[count];
                Orders.OrderCost += Cost;
                Orders.bikeCosts[count] = Cost;
            }

            MessageBox.Show("Cost is " + Cost);
        }

        public void CancelOrder()
        {

        }

        // NEW BIKE METHOD???
    }
}
