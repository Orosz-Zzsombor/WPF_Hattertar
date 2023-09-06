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

namespace Szamitas
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

        private void btnSzamol_Click(object sender, RoutedEventArgs e)
        {
            var KapNagysag = cbNagysag.SelectedIndex;
            double kapapcitas = Convert.ToDouble(txtKapacitas.Text);
            var SebNagysag = cbSebesseg.SelectedIndex;
            double sebesseg = Convert.ToDouble(sliSebesség.Value);
            for (int i = 0; i < KapNagysag; i++)
            {
                kapapcitas *= 1000;
            }
            for (int i = 0; i < SebNagysag; i++)
            {
                sebesseg *= 1000;
            }
            double ido = kapapcitas / sebesseg;
            TimeSpan t = TimeSpan.FromSeconds(ido);
            string valasz = string.Format("{0:D2}óra:{1:D2}perc:{2:D2}másodperc:{3:D3}ms", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
            lbEredmeny.Content = valasz;


            

        }

        private void sliSebesség_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbErtek.Content = sliSebesség.Value;
        }
    }
}
