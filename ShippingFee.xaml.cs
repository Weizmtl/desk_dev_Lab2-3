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

namespace Lab2Q2
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
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double weight = double.Parse(txtWeight.Text);
            double distance = double.Parse(txtDistance.Text);
            double rate = 0;

            if (weight <= 2)
            {
                rate = 1.10;
            }
            else if (weight > 2 && weight <= 6)
            {
                rate = 2.20;
            }
            else if (weight > 6 && weight <= 10)
            {
                rate = 3.70;
            }
            else if (weight > 10 && weight <= 20)
            {
                rate = 4.80;
            }

            double totalCost = (distance / 500) * rate;

            txtTotalCost.Text = totalCost.ToString("C");
        }
    }
}
}
