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

namespace Build_A_Bike_Application
{
    /// <summary>
    /// Interaction logic for AddBikeFeatures.xaml
    /// </summary>
    public partial class AddBikeFeatures : Window
    {
        private int _previousBikeSelect = 1;

        // Declaring a new list of bikes to order
        public List<Bike> bikeList = new List<Bike>();
        public double TotalCost { get; set; }

        private int _numberOfBikes = 0;

        public int StartingIndex = -1;
        
        public AddBikeFeatures(int bikeNumber)
        {
            InitializeComponent();

            // Adding ints to the bike list
            for (int i = 0; i < bikeNumber; i++)
            {
                BikeNumCombo.Items.Add(i + 1);
                _numberOfBikes++;
            }
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

        private void BikeNumCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddBike_Click(object sender, RoutedEventArgs e)
        {
            int bikeToModify = BikeNumCombo.SelectedIndex + 1;

            if (bikeList[])
        }

        // DONT CHECK THE ENTRIES - STORE THE DATA IN THE BIKE CLASS AND THEN CHECK THE BIKES

        // Adds each of the bikes to the class
        // Upon submitting bikes, submit button calls function in bike class, which checks for each bike's completeness in the list
    }
}
