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
using System.Windows.Shapes;

namespace ApplicazioneGattile
{
    /// <summary>
    /// Logica di interazione per Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        Gattile gattile = new Gattile();
        public Window2()
        {
            InitializeComponent();
            lb_Gatti.Items.Add(gattile.Gatti);
        }

        private void btn_AggiungiAdozione_Click(object sender, RoutedEventArgs e)
        {
            gattile.AggiungiAdozioni((Gatto)lb_Gatti.SelectedItems);
        }
    }
}
