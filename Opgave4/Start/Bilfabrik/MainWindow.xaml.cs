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

namespace Bilfabrik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { InitializeComponent(); }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        { this.Close(); }

        /// <summary>
        /// Validation for order when button is clicked, send order to lst-box-queue if valid, else prints errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            //Try parse wheels and seats, if unsuccesful add error to errorMessages
            var errorMessages = "";
            if (!int.TryParse(txtbSeats.Text, out var seats))
                { errorMessages += "Antal sæder er ikke et tal \n"; }
            if (!int.TryParse(txtbWheels.Text, out var wheels))
                { errorMessages += "Antal hjul er ikke et tal \n"; }

            //Check if errorMesages, if send them to Messagebox, else add order to lst-box-queue
            if (String.IsNullOrEmpty(errorMessages))
                { lstbQueue.Items.Add($"{txtbColour.Text} {txtbBrand.Text} {txtbType.Text} med {seats} sæder og {wheels} hjul"); }
            else
                { MessageBox.Show(errorMessages, "Fejlmeddelse"); }
        
        }
    }
}