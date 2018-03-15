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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Build_A_Bike_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewBikeOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Checking that a value has been selected
                if (BikeNumCombo.SelectedIndex == -1)
                {
                    throw new Exception
                        ("Please ensure that you select the number of bikes to be ordered");
                }

                int tempNum = Int32.Parse(BikeNumCombo.Text);

                // New bike order with the number of bikes selected from the main menu
                var bikeOrder = new AddBikeFeatures(tempNum);
                bikeOrder.Show();
                MessageBox.Show("The order only updates if a category is complete when a bike is added.");
                Close();
            }
            catch (Exception newBikeException)
            {
                MessageBox.Show(newBikeException.Message, "error");
            }

        }
    }
}
