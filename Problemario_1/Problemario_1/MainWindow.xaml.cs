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
using Problemario_1.Deportes;
using SQLite;

namespace Problemario_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Deportistas jugador = new Deportistas()
            {
                Nombre = txtBNombre.Text,
                Deporte = txtBDeporte.Text,
                Sexo = txtBSexo.Text,
                Horario = txtBHorario.Text
            };
            using (SQLiteConnection conexion = new SQLiteConnection(App.databasePath))
            {
                conexion.CreateTable<Deportistas>();
                conexion.Insert(jugador);
            }
            Close();
        }
    }
}
