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
    /// Logica di interazione per Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_Invio_Click(object sender, RoutedEventArgs e)
        {
            if (tb_Nome == null || tb_Nome.Text == " " || tb_Razza == null || tb_Razza.Text == " " || tb_Sesso == null || tb_Sesso.Text == " " || tb_Descrizione == null || tb_Descrizione.Text == " " || tb_DataArrivo == null || tb_DataArrivo.Text == " ")
            {
                MessageBox.Show("Completa tutti i campi obbligatori prima di procedere");
            }
            else
            {
                Data dArrivo = new Data(tb_DataArrivo.Text);
                Data dNascita = new Data(tb_DataNascita.Text);
                Gatto.Genere genere = Gatto.Genere.maschio;
                Gatto g = new Gatto(tb_Nome.Text, tb_Razza.Text, genere, dArrivo, tb_Descrizione.Text, dNascita);
                Close();
            }
        }
    }
}
