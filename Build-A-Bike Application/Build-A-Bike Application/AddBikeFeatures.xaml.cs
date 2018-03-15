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
    /// Interaction logic for AddBikeFeatures.xaml
    /// </summary>
    public partial class AddBikeFeatures : Window
    {
        // Declaring a new list of bikes to order
        public List<Bike> bikeList = new List<Bike>();

        // List of costs for the bikes
        public List<double> bikeCost = new List<double>();

        public double TotalCost { get; set; }

        public int BikeNumber { get; private set; }

        public int StartingIndex = -1;
        
        /// <summary>
        /// Adds 
        /// </summary>
        /// <param name="bikeNumber"></param>
        public AddBikeFeatures(int bikeNumber)
        {
            InitializeComponent();

            int count = 0;

            // Adding ints to the bike list
            for (int i = 0; i < bikeNumber; i++)
            {
                BikeNumCombo.Items.Add(i + 1);
                count++;
            }

            BikeNumber = count;

            OrderIdField.Text = "Order Id: " + Orders.OrderId;
            OrderCost.Text = "Order Cost: ";
            BikeCost.Text = "Bike Cost: ";
        }

        /// <summary>
        /// Returns the user to menu
        /// </summary>
        /// <param name="sender">Object that sent the request</param>
        /// <param name="e">Dummy object</param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            Close();
            window.Show();
        }

        /// <summary>
        /// Checks that all fields have information entered for the given bike number
        /// </summary>
        /// <param name="bikeNum">checking the bike number attributes</param>
        /// <returns></returns>
        private void CheckEntriesComplete(int bikeNum)
        {

            ////// NEW FUNCTION THAT ADVISES THE USER THERE ARE UNSAVED CHANGES TO THE BIKE CLASS
            if (FrameSizeCombo.SelectedIndex != -1)
            {
                MessageBox.Show("Please ensure that you enter the frame size for the bike before you continue.");
            }

            if (FrameColourCombo.SelectedIndex != -1)
            {
                MessageBox.Show("Please ensure that you enter the frame colour for the bike before you continue.");
            }

            if (WheelsCombo.SelectedIndex != -1)
            {
                MessageBox.Show("Please ensure that you enter the wheel type for the bike before you continue.");
            }

            if (GearCombo.SelectedIndex != -1)
            {
                MessageBox.Show("Please ensure that you enter the gear type for the bike before you continue.");
            }

            if (BrakeCombo.SelectedIndex != -1)
            {
                MessageBox.Show("Please ensure that you enter the gear type for the bike before you continue.");
            }

            if (HandlebarCombo.SelectedIndex != -1)
            {
                MessageBox.Show("Please ensure that you enter the handlebar type for the bike before you continue.");
            }

            if (SaddleCombo.SelectedIndex != -1)
            {
                MessageBox.Show("There is still unsaved information for the current bike. It will be unsaved if you select a new bike.");
            }
        }

        // Clears each of the fields
        private void ClearFields()
        {
            FrameSizeCombo.SelectedIndex = -1;
            FrameColourCombo.SelectedIndex = -1;
            WheelsCombo.SelectedIndex = -1;
            GearCombo.SelectedIndex = -1;
            BrakeCombo.SelectedIndex = -1;
            HandlebarCombo.SelectedIndex = -1;
            SaddleCombo.SelectedIndex = -1;
            WarrantyBox.IsChecked = false;
        }

        // Called right at the beginning of the program
        private void BikeNumCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// Button to add or update a bike based on details in the forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBike_Click(object sender, RoutedEventArgs e)
        {
            // +1 Because the indexes are being used (0-5) while 
            int bikeToModify = BikeNumCombo.SelectedIndex +1;
            
            int count = 0;
            bool bikeFound = false;
            foreach (var bike in bikeList)
            {
                // Updating existing bike
                if (bikeList[count].BikeId == bikeToModify)
                {
                    MessageBox.Show("Updating existing bike");
                    ModifyBike(bikeToModify, count, bike);
                    bikeFound = true;
                }
                count++;
            }

            // Adding new bike
            if (!bikeFound)
            {
                MessageBox.Show("Adding new bike");
                MessageBox.Show("bike to modify is " + bikeToModify);
                bikeList.Add(new Bike(Orders.OrderId, bikeToModify));
                Bike bike = bikeList[bikeList.Count -1];
                ModifyBike(bikeToModify, count, bike);
            }
        }

        /// <summary>
        /// Modifies a bike with an already existing Id
        /// </summary>
        private void ModifyBike(int bikeNum, int indexAt, Bike bikeToUpdate)
        {

            MessageBox.Show("bike to update is " + bikeToUpdate);
            MessageBox.Show("BikeNum is " + bikeNum);

            // Update frame size combo
            if (FrameSizeCombo.SelectedIndex != -1 && FrameColourCombo.SelectedIndex != -1)
            {
                bikeToUpdate.UpdateFrame(FrameSizeCombo.Text, FrameColourCombo.Text);
            }

            // Update wheels from combo
            if (WheelsCombo.SelectedIndex != -1)
            {
                bikeToUpdate.UpdateWheels(WheelsCombo.Text);
            }

            // Update gears from combo
            if (GearCombo.SelectedIndex != -1 && BrakeCombo.SelectedIndex != -1)
            {
                bikeToUpdate.UpdateGroupSet(GearCombo.Text, BrakeCombo.Text);
            }

            // Update handlebars from combo
            if (HandlebarCombo.SelectedIndex != -1 && SaddleCombo.SelectedIndex != -1)
            {
                bikeToUpdate.UpdateFinishingSet(HandlebarCombo.Text,SaddleCombo.Text);
            }

            // If a warranty has been added
            if (WarrantyBox.IsChecked == true)
            {
                bikeToUpdate.AddWarranty();
            }

            bikeToUpdate.UpdatePrice();

            OrderCost.Text = "Order Cost: " + Orders.OrderCost;
            BikeCost.Text = "Bike Cost: " + bikeToUpdate.Cost;

            ClearFields();
        }

        // DONT CHECK THE ENTRIES - STORE THE DATA IN THE BIKE CLASS AND THEN CHECK THE BIKES

        // Adds each of the bikes to the class
        // Upon submitting bikes, submit button calls function in bike class, which checks for each bike's completeness in the list
    }
}
