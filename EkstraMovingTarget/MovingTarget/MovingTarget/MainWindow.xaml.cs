using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Effects;

namespace MovingTarget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int counter = 0;
        private DispatcherTimer _timer;
            
            public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 2);
            _timer.Start();
            _timer.Tick += new EventHandler(moveToRandomPos);

            
        }

        private void ms_Down(object sender, MouseButtonEventArgs e)
        {
            var window = (Window)sender;
            var oldBackground = window.Background;

            window.Background = Brushes.Red;
            MessageBox.Show($"Du har ramt {++counter} gange", "HIT! ", MessageBoxButton.OK, MessageBoxImage.Hand);
            //moveToRandomPos();
            window.Background = oldBackground;
        }

        private void moveToRandomPos(object myObj, EventArgs args)
        {
            Random rand = new Random();
            
            this.Left = rand.Next(0, (int)System.Windows.SystemParameters.PrimaryScreenWidth);
            this.Top = rand.Next(0, (int)System.Windows.SystemParameters.PrimaryScreenHeight); ;
        }
    }
}
