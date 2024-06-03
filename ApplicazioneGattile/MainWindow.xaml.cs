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

namespace ApplicazioneGattile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gattile gattile = new Gattile();
            tb_TotGattiPresenti.Text = gattile.Gatti.Count.ToString();
        }

        private void btn_AggiungiGatto_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
        }

        private void btn_AggiungiAdozione_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
        }
    }
}
