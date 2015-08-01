using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JuegoToqueFama
{
    /// <summary>
    /// Lógica de interacción para Ganador.xaml
    /// </summary>
    public partial class Ganador : Window
    {
        public Ganador()
        {
            InitializeComponent();
        }
    public void move(object sender, MouseButtonEventArgs e)//metodo mover
        {
            DragMove();
        }

    private void btnBack_Click(object sender, RoutedEventArgs e)
    {
        MainWindow menuFrm = new MainWindow();//crea objeto de la clase main            
        menuFrm.Show();//muestra la pantalla inicio
        this.Close();//cierra la pantalla
    }

    private void btnCerrar_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    }
}
