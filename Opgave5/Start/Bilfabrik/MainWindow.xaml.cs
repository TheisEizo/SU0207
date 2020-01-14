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
        List<string> orderLst = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            cbType.Items.Clear();
            foreach (CarType carType in Enum.GetValues(typeof(CarType)))
            {
                cbType.Items.Add(carType);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            string brand = tbCarBrand.Text;
            string numberOfSeats = tbNumberOfSeats.Text;
            string numberOfWheels = tbNumberOfWheels.Text;
            ColourType color = ColourType.Black;
            CarType type = CarType.Personal;
            


            // Variable til Antal sæder og hjul, som tal
            int numberOfSeatsInt = 0;
            int numberOfWheelsInt = 0;

            // Check at det indtastede er korrekt
            var errorMessages = "";

            if (brand == "")
                errorMessages += "Mærke skal udfyldes!\n";

            if (thisIsANumber(numberOfSeats))
                numberOfSeatsInt = getNumber(numberOfSeats);
            else
                errorMessages += "Antal sæder skal være et tal\n";

            if (thisIsANumber(numberOfWheels))
                numberOfWheelsInt = getNumber(numberOfWheels);
            else
                errorMessages += "Antal hjul skal være et tal\n";

            if (cbColor.SelectedIndex >= 0)
                if (Enum.TryParse(cbColor.Text, out color))
                { }
                else
                { throw new Exception("Fejl i XAML"); }

                else
                    errorMessages += "Farve skal vælges";

            if (cbType.SelectedIndex >= 0)
                type = (CarType)cbType.SelectedItem;
            else
                errorMessages += "Type skal vælges";

            // Alt er kontrolleret - er der sket nogle fejl?
            if (errorMessages == "")
            {
                // Ingen fejl - før ordren til de tidligere bestillinger
                // var ordre = string.Format("{0} {1} {2}, med {3} sæder og {4} hjul.", color, brand, type, numberOfSeatsInt, numberOfWheelsInt);
                // C#6 kan skrive det på en lidt mere overskuelig måde:
                var ordreCs6 = $"{color} {brand} {type}, med {numberOfSeatsInt} sæder og {numberOfWheelsInt} hjul.";

                var numberOfSimilarOrders = 0;
                foreach (var item in lstOrders.Items)
                {
                    if (ordreCs6 == (string)item)
                        numberOfSimilarOrders++;
                }

                orderLst.Add(ordreCs6);
                lstOrders.Items.Add(ordreCs6);
                MessageBox.Show($"Der er {numberOfSimilarOrders} ens ordre ud af {orderLst.Count}", "Succes");

            }
            else
            {
                // En eller flere havde fejl
                MessageBox.Show(errorMessages, "Der er fejl i det indtastede", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            
        }

        /// <summary>
        /// Hjælpemetode til at afgøre om en tekst indeholder et heltal
        /// </summary>
        /// <param name="textToTest">Den tekst, der skal udnersøges</param>
        /// <returns>true, hvis teksten indeholder et tal</returns>
        private bool thisIsANumber(string textToTest)
        {
            var isANumber = false;
            try
            {
                int.Parse(textToTest);
                isANumber=true;
            }
            catch (Exception)
            {
                isANumber = false;
            }
            return isANumber;
        }

        /// <summary>
        /// Hjælpemetode til at konvertere en tekst til tal
        /// </summary>
        /// <param name="textWithNumber">Tekst, der skal konverteres</param>
        /// <returns>Den konverterede værdi, 0 hvis tekst indeholder andet end tal</returns>
        private int getNumber(string textWithNumber)
        {
            var numberToReturn = 0;
            try
            {
                numberToReturn = int.Parse(textWithNumber);
            }
            catch (Exception)
            {
                // Vi skal kun fange fejl - ikke gøre noget
            }

            return numberToReturn;
        }
    }
}
