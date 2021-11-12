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

namespace progBiblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca _biblioteca;
        public MainWindow()
        {
            InitializeComponent();

            _biblioteca = new Biblioteca("Malatestiana", "Rossi, 461", new DateTime(2021, 1, 1, 8, 0, 0), new DateTime(2021, 1, 1, 18, 30, 0));
            AggiornaInterfaccia();
        }

        private void AggiornaInterfaccia()
        {
            lbl_InfoBiblioteca.Content = _biblioteca + "";
            lstiLibri.ItemsSource = null;
            lstiLibri.ItemsSource = _biblioteca.Libri;
        }

        private void btnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _biblioteca.AggiungiLibro(new Libro(txtAutore.Text, txtTitolo.Text, new DateTime(int.Parse(txtAnnoPubblicazione.Text), 1, 1), txtEditore.Text, int.Parse(txtNumeroPagine.Text)));
                AggiornaInterfaccia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
