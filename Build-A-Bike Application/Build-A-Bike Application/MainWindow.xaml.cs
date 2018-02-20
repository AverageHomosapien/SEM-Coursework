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
                if (BikeNumber.Text == "")
                {
                    throw new Exception
                        ("Please ensure that you add a number of bikes to enter.");
                }

                // Temporary number - later stored as global bike num

                bool result = Int32.TryParse(BikeNumber.Text, out var tempNum);

                if (!result)
                {
                    throw new Exception
                        ("Please ensure that you enter a valid number of bikes to be added.");
                }

                var bikeOrder = new AddBikeFeatures(tempNum);
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
