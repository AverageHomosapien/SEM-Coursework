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
using BusinessLayer;

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

                // Staff Id check
                bool result = Int32.TryParse(StaffIdBox.Text, out var number);
                if (!result)
                {
                    throw new Exception
                        ("Please ensure you enter a valid staff id");
                }

                if (number > 1000 || number < 1)
                {
                    throw new Exception
                        ("Please ensure that you enter a valid staff id");
                }

                int staffId = number;

                // Customer Id check
                result = Int32.TryParse(CustIdBox.Text, out number);
                if (!result)
                {
                    throw new Exception
                        ("Please ensure you enter a valid staff id");
                }

                if (number > 1000 || number < 1)
                {
                    throw new Exception
                        ("Please ensure that you enter a valid staff id");
                }

                int tempNum = Int32.Parse(BikeNumCombo.Text);

                Order order = new Order(number, staffId);

                // New bike order with the number of bikes selected from the main menu
                var bikeOrder = new AddBikeFeatures(tempNum, order);
                bikeOrder.Show();
                Close();
            }
            catch (Exception newBikeException)
            {
                MessageBox.Show(newBikeException.Message, "error");
            }

        }
    }
}
