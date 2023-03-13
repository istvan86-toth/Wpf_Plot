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
using WpfApp1;

namespace Wpf_Plot
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

        private void btn_RajztablaMegjelenit_Click(object sender, RoutedEventArgs e)
        {
            string szelesseg = txt_Rajztabla_Szelesseg.Text.ToString();
            string magassag = txt_Rajztabla_Magassaga.Text.ToString();
            string eszkoz_sz = txt_Rajztabla_Eszközszám.Text.ToString();
            
            int rajztabla_Szelesseg = Convert.ToInt32(szelesseg);
            int rajztabla_Magassag = Convert.ToInt32(magassag);
            int eszkozok_Szama = Convert.ToInt32(eszkoz_sz);
            Plotter rajztabla = new Plotter(rajztabla_Szelesseg, rajztabla_Magassag, eszkozok_Szama);
            rajztabla.Show();

        }
    }
}
