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

namespace PercentCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            int periods = int.Parse(txbPercent.Text);
            double startcount = int.Parse(txbStartSumm.Text);
            int years = int.Parse(txbYears.Text);
            int total = int.Parse(txbResult.Text);
            int rate = int.Parse(cmbProcess.ToString());

           
            if (cmbProcess.SelectedIndex == 0)
            {
                double dayRate = rate / 365;
                periods = years * 365;
                startcount = startcount * Math.Pow((1 + dayRate), periods);
                total = Convert.ToInt32(Math.Round(startcount, 2));
            }
            else if (cmbProcess.SelectedIndex == 1)
                {
                    double mounthRate = rate / 365;
                    periods = years * 365;
                    startcount = startcount * Math.Pow((1 + mounthRate), periods);
                    total = Convert.ToInt32(Math.Round(startcount, 2));
                }
            else if (cmbProcess.SelectedIndex == 2)
            {
                double yearRate = rate / 365;
                periods = years * 365;
                startcount = startcount * Math.Pow((1 + yearRate), periods);
                total = Convert.ToInt32(Math.Round(startcount, 2));
            }
        }
      
    }
}
