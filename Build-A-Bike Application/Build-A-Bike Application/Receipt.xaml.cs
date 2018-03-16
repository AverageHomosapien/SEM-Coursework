using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessLayer;
using DataLayer;

namespace Build_A_Bike_Application
{
    /// <summary>
    /// Interaction logic for Receipt.xaml
    /// </summary>
    public partial class Receipt : Window
    {
        private List<Bike> bikes = new List<Bike>();

        public Receipt(List<Bike> bikeList)
        {
            InitializeComponent();
            bikes = bikeList;
            
            HideBlocks();
            int count = 0;
            foreach (var bike in bikeList)
            {
                ShowBlocks(count, bike.Cost, bike.ExtendedWarranty);
                count++;
            }

            TotalBlock.Text = "Total Cost: £" + Orders.OrderCost;
        }

        /// <summary>
        /// Closes the window
        /// </summary>
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

        // Hides all the price blocks on the page
        private void HideBlocks()
        {
            Bike1Block.Text = "";
            Bike2Block.Text = "";
            Bike3Block.Text = "";
            Bike4Block.Text = "";
            Bike5Block.Text = "";
            Bike6Block.Text = "";

            Bike1Warranty.Text = "";
            Bike2Warranty.Text = "";
            Bike3Warranty.Text = "";
            Bike4Warranty.Text = "";
            Bike5Warranty.Text = "";
            Bike6Warranty.Text = "";
        }

        /// <summary>
        /// Shows blocks one by one for the receipt
        /// </summary>
        /// <param name="blockNum">Bike in list</param>
        /// <param name="cost">Cost of bike</param>
        /// <param name="warranty">If warranty is chosen</param>
        private void ShowBlocks(int blockNum, double cost, bool warranty)
        {
            switch (blockNum)
            {
                case 0:
                    Bike1Block.Text = "Bike 1: £" + cost;
                    if (warranty)
                    {
                        Bike1Warranty.Text = "Warranty: Yes";
                    }
                    else
                    {
                        Bike1Warranty.Text = "Warranty: No";
                    }
                    break;
                case 1:
                    Bike2Block.Text = "Bike 2: £" + cost;
                    if (warranty)
                    {
                        Bike2Warranty.Text = "Warranty: Yes";
                    }
                    else
                    {
                        Bike2Warranty.Text = "Warranty: No";
                    }
                    break;
                case 2:
                    Bike3Block.Text = "Bike 3: £" + cost;
                    if (warranty)
                    {
                        Bike3Warranty.Text = "Warranty: Yes";
                    }
                    else
                    {
                        Bike3Warranty.Text = "Warranty: No";
                    }
                    break;
                case 3:
                    Bike4Block.Text = "Bike 4: £" + cost;
                    if (warranty)
                    {
                        Bike4Warranty.Text = "Warranty: Yes";
                    }
                    else
                    {
                        Bike4Warranty.Text = "Warranty: No";
                    }
                    break;
                case 4:
                    Bike5Block.Text = "Bike 5: £" + cost;
                    if (warranty)
                    {
                        Bike5Warranty.Text = "Warranty: Yes";
                    }
                    else
                    {
                        Bike5Warranty.Text = "Warranty: No";
                    }
                    break;
                case 5:
                    Bike6Block.Text = "Bike 6: £" + cost;
                    if (warranty)
                    {
                        Bike6Warranty.Text = "Warranty: Yes";
                    }
                    else
                    {
                        Bike6Warranty.Text = "Warranty: No";
                    }
                    break;
            }
        }
    }
}
