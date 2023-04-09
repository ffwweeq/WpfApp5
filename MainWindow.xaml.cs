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

namespace WpfApp5
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string strInput;
        double douOutput;
        private void txtc_Click(object sender, RoutedEventArgs e)
        {
            double h, w, bmi;

            w = Convert.ToDouble(txta.Text);

            h = Convert.ToDouble(txtb.Text) / 100.0;

            bmi = w / (h * h);

            txtd.Text = bmi.ToString("#0.00");
        }

        private void txta_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txta.Text;
            if (double.TryParse(strInput, out douOutput) == false)
            {
                txta.Text = "";
                txtd.Text = "請勿輸入文字";
            }
        }

        private void txtb_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtb.Text;
            if (double.TryParse(strInput, out douOutput) == false)
            {
                txtb.Text = "";
                txtd.Text = "請勿輸入文字";
            }
        }

        private void txtd_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtd.Text;
        }
    }
}
