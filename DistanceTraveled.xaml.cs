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

namespace Lab2Q3
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
            try
            {
                int speed = int.Parse(txtSpeed.Text);
                int hours = int.Parse(txtHours.Text);

                dgDistance.Items.Clear();

                for (int i = 1; i <= hours; i++)
                {
                    int distance = speed * i;
                    dgDistance.Items.Add(new { Hour = i, Distance = distance });
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for speed and hours.");
            }
        }
    }
}
