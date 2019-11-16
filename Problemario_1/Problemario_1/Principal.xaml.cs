using Problemario_1.Deportes;
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
using SQLite;

namespace Problemario_1
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        List<Deportistas> jugador;
        public Principal()
        {
            InitializeComponent();
            jugador = new List<Deportistas>();
            LeerBaseDatos();
        }
        void LeerBaseDatos()
        {
            using (SQLite.SQLiteConnection conn =
               new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Deportistas>();
                jugador = (conn.Table<Deportistas>().ToList()).
                    OrderBy(c => c.Nombre).ToList();
            }
            if (jugador != null)
            {
                lvJugadores.ItemsSource = jugador;
            }
        }
        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Problemario_1.MainWindow form = new Problemario_1.MainWindow();
            form.ShowDialog();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Problemario_1.Principal form = new Problemario_1.Principal();
            form.ShowDialog();
        }
    }
}
