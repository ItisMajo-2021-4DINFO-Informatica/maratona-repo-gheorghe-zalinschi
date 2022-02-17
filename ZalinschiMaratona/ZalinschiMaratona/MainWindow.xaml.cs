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
using System.IO;

namespace ZalinschiMaratona
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Maratona maratoni;
        public MainWindow()
        {
            InitializeComponent();
            maratoni = new Maratona();
            DgElencoMaratona.ItemsSource = maratoni.elencoMaratona;
        }

        private void BtnLeggi_Click(object sender, RoutedEventArgs e)
        {
            maratoni.LeggiDati();
            DgElencoMaratona.Items.Refresh();

        }

        private void BtnCercaCitta_Click(object sender, RoutedEventArgs e)
        {
            string titolo = TxtAtleta.Text;
            string citta = TxtCita.Text;
            string artistaTrovato = maratoni.CercaTempo(titolo, citta);
            LblCitta.Content = artistaTrovato;
          
        }
    }
}
