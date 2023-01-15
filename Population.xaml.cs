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

namespace Lab2Q4
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
        private void btnPredict_Click(object sender, RoutedEventArgs e)
        {
            int startingNumber, daysMultiply;
            double dailyIncrease;
            if (!int.TryParse(txtStartingNumber.Text, out startingNumber))
            {
                MessageBox.Show("Please enter a valid starting number of organisms.");
                return;
            }
            if (!double.TryParse(txtDailyIncrease.Text, out dailyIncrease))
            {
                MessageBox.Show("Please enter a valid daily increase percentage.");
                return;
            }
            if (!int.TryParse(txtDaysMultiply.Text, out daysMultiply))
            {
                MessageBox.Show("Please enter a valid number of days to multiply.");
                return;
            }

            txtOutput.Text = "Day\tPopulation Size\n";

            for (int i = 1; i <= daysMultiply; i++)
            {
                double population = startingNumber * Math.Pow(1 + (dailyIncrease / 100), i);
                txtOutput.Text += i + "\t" + population + "\n";
            }
        }
    }
}