using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BikeStock
    {
        // Available stock left for different parts of the bike
        public int AvailableFrame { get; private set; }
        public int AvailableWheels { get; private set; }
        public int AvailableGroupSet { get; private set; }
        public int AvailableFinishingSet { get; private set; }


        public double FrameCost { get; set; }
        public double WheelCost { get; set; }
        public double GroupSetCost { get; set; }
        public double FinishingSetCost { get; set; }

        /// <summary>
        /// Returns cost and stock level of wheels
        /// /// </summary>
        /// <param name="selection">Wheel type</param>
        public double Wheels(string selection)
        {
            switch (selection)
            {
                case "Standard":
                    AvailableWheels = 6;
                    return 60;
                case "Race":
                    AvailableWheels = 3;
                    return 120;
                case "Offroad":
                    AvailableWheels = 4;
                    return 90;
                default:
                    throw new Exception("Wheel error");
                    
            }
        }

        /// <summary>
        /// Returns stock and cost of frame
        /// </summary>
        /// <param name="firstSelection">Frame size</param>
        /// <param name="secondSelection">Frame colour</param>
        public double Frame(string firstSelection, string secondSelection)
        {
            switch (firstSelection)
            {
                // Returns based on frame input
                case "Small":
                    if (secondSelection == "Fire Red")
                    {
                        AvailableFrame = 4;
                        return 80;
                    }
                    else if (secondSelection == "Leaf Green")
                    {
                        AvailableFrame = 3;
                        return 80;
                    }
                    else
                    {
                        AvailableFrame = 6;
                        return 80;
                    }
                case "Medium":
                    if (secondSelection == "Fire Red")
                    {
                        AvailableFrame = 6;
                        return 100;
                    }
                    else if (secondSelection == "Leaf Green")
                    {
                        AvailableFrame = 5;
                        return 100;
                    }
                    else
                    {
                        AvailableFrame = 8;
                        return 100;
                    }
                case "Large":
                    if (secondSelection == "Fire Red")
                    {
                        AvailableFrame = 3;
                        return 140;
                    }
                    else if (secondSelection == "Leaf Green")
                    {
                        AvailableFrame = 2;
                        return 140;
                    }
                    else
                    {
                        AvailableFrame = 5;
                        return 140;
                    }
                default:
                    throw new Exception("Frame error");
            }
        }

        /// <summary>
        /// Returns groupset stock level and cost
        /// </summary>
        /// <param name="firstSelection">Cost bracket</param>
        /// <param name="secondSelection">Brakes</param>
        public double GroupSet(string firstSelection, string secondSelection)
        {
            switch (firstSelection)
            {
                // Returns based on group set
                case "Low Cost":
                    if (secondSelection == "Brakes")
                    {
                        AvailableGroupSet = 6;
                        return 50;
                    }
                    else
                    {
                        AvailableGroupSet = 3;
                        return 80;
                    }
                case "Medium Cost":
                    if (secondSelection == "Brakes")
                    {
                        AvailableGroupSet = 8;
                        return 80;
                    }
                    else
                    {
                        AvailableGroupSet = 6;
                        return 120;
                    }
                case "High Cost":
                    if (secondSelection == "Brakes")
                    {
                        AvailableGroupSet = 4;
                        return 120;
                    }
                    else
                    {
                        AvailableGroupSet = 1;
                        return 160;
                    }
                default:
                    throw new Exception("Group set error.");
            }
        }

        /// <summary>
        /// Returns the cost and stock level of Finishing Set
        /// </summary>
        /// <param name="firstSelection"></param>
        /// <param name="secondSelection"></param>
        public double FinishingSet(string firstSelection, string secondSelection)
        {
            switch (firstSelection)
            {
                case "Standard":
                    if (secondSelection == "Standard")
                    {
                        AvailableFinishingSet = 10;
                        return 100;
                    }
                    else if (secondSelection == "Race")
                    {
                        AvailableFinishingSet = 5;
                        return 100;
                    }
                    else
                    {
                        AvailableFinishingSet = 3;
                        return 100;
                    }
                case "Race":
                    if (secondSelection == "Standard")
                    {
                        AvailableFinishingSet = 5;
                        return 120;
                    }
                    else if (secondSelection == "Race")
                    {
                        AvailableFinishingSet = 8;
                        return 120;
                    }
                    else
                    {
                        AvailableFinishingSet = 4;
                        return 120;
                    }
                case "Offroad":
                    if (secondSelection == "Standard")
                    {
                        AvailableFinishingSet = 4;
                        return 120;
                    }
                    else if (secondSelection == "Race")
                    {
                        AvailableFinishingSet = 3;
                        return 120;
                    }
                    else
                    {
                        AvailableFinishingSet = 8;
                        return 120;
                    }
                default:
                    throw new Exception("Finishing set error");
            }
        }
    }
}
