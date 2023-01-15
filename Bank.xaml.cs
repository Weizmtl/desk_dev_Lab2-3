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

namespace Lab2
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
            double monthlyFee = 10.00;
            double checkFee = 0.00;
            int numberOfChecks = 0;

            if (!int.TryParse(txtNumberOfChecks.Text, out numberOfChecks))
            {
                MessageBox.Show("Please enter a valid number of checks.");
                return;
            }

            if (numberOfChecks < 20)
            {
                checkFee = numberOfChecks * 0.10;
            }
            else if (numberOfChecks >= 20 && numberOfChecks <= 39)
            {
                checkFee = numberOfChecks * 0.08;
            }
            else if (numberOfChecks >= 40 && numberOfChecks <= 59)
            {
                checkFee = numberOfChecks * 0.06;
            }
            else if (numberOfChecks >= 60)
            {
                checkFee = numberOfChecks * 0.04;
            }

            double totalFee = monthlyFee + checkFee;

            txtTotalFee.Text = totalFee.ToString();
        }
    }
}

