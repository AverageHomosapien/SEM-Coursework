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

namespace Build_A_Bike_Application
{
    /// <summary>
    /// Interaction logic for AddBikeFeatures.xaml
    /// </summary>
    public partial class AddBikeFeatures : Window
    {
        private IList<int> _bikeNumberRange = new List<int>();
        public int StartingIndex = -1;
        private int BikeNum { get; set; }

        // Setting Bike Number Range
        public IList<int> BikeNumberRange
        {
            get => _bikeNumberRange;
            set { _bikeNumberRange = value; }
        }

        public AddBikeFeatures(int bikeNumber)
        {
            InitializeComponent();
            MessageBox.Show("BikeNumber =" + bikeNumber);
            BikeNum = bikeNumber;

            UpdateBikeNumbers();

            //COMBOBOX.items.add("NUMBERHERE");

            //DataContext = new DataObject();
            
        }

        /// <summary>
        /// Adds the total number of selected bikes to the combo box and displays
        /// </summary>
        public void UpdateBikeNumbers()
        {
            // Adding bike number to the combobox
            for (int i = 0; i < BikeNum; i++)
            {
                BikeNumberRange.Add(i + 1);
            }

            DataContext = this;
            this.BikeNumCombo.ItemsSource = BikeNumberRange;
        }

        
    }
}
