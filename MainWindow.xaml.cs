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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JuegoToqueFama
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()//inicia la pantalla
        {
            InitializeComponent();
        }

        private void btnSolo_Click(object sender, RoutedEventArgs e)//boton solo en la pantalla
        {
            Solo jugarFrm = new Solo();//crea un objeto de la clase solo
            jugarFrm.Show();//muestra el objeto
            this.Close();//se cierra la pantalla
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)//boton cerrar
        {
            App.Current.Shutdown();//cierra la aplicacion
        }

        public void move(object sender, MouseButtonEventArgs e)//metodo mover
        {
            DragMove();//permite mover la pantalla
        }

        private void btnMini_Click(object sender, RoutedEventArgs e)//boton minimizar
        {
            this.WindowState = WindowState.Minimized;//minimiza la pantalla
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)//boton multijugador en la pantalla
        {
            Multi muFrm = new Multi();//crea un objeto de la clase multi
            muFrm.Show();//muestra el objeto
            this.Close();//cierra la pantalla
        }

        private void Solo(object sender, RoutedEventArgs e)//solo en el menu
        {
            Solo jugarFrm = new Solo();//crea un objeto de la clase solo
            jugarFrm.Show();//muestra el objeto
            this.Close();//cierra la pantalla

        }

        private void Multi(object sender, RoutedEventArgs e)//multi en el menu
        {
            Multi muFrm = new Multi();//crea un objeto de la clase multi
            muFrm.Show();//muestra el objeto
            this.Close();//cierra la pantalla
        }

       private void Instr(object sender, RoutedEventArgs e)//instrucciones en el menu
        {
            Instrucciones insFrom = new Instrucciones();//crea un objeto de la clase instrucciones
            insFrom.Show();//muestra el objeto
        }

       private void MenuItem_Click(object sender, RoutedEventArgs e)//acerda de en el menu
       {
           MessageBox.Show(" Alumno:" + "\r" + "\n" + " - -------- " + "\r" + "\n" + " Sección --");//muestra un mensaje con los integrantes,\r\n saltos de linea
       }

    }
}
