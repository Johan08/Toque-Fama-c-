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
    /// Lógica de interacción para Multi.xaml
    /// </summary>
    public partial class Multi : Window
    {
        int cont;//contador para saber digitos ingresados y evitar que se repitan
        private Numero elnumero;//objeto numero para el numero ingrasado
        private Numero esconder;//objeto numero para esconder el numero mientras se ingresa

        public Multi()//inicia la pantalla
        {
            InitializeComponent();//inicia la pantalla
            cont = 0;//setea contador en 0
            elnumero = new Numero { Dig4 = "-", Dig3 = "-", Dig2 = "-", Dig1 = "-" };//valor inicial del numero
            esconder = new Numero { Dig4 = "-", Dig3 = "-", Dig2 = "-", Dig1 = "-" };//valor inicial del numero
            DataContext = esconder;//da la ruta de donde saca la info de la pantalla
        }

        public void move(object sender, MouseButtonEventArgs e)//metodo mover pantalla
        {
            DragMove();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)//boton inicio en el menu
        {
            MainWindow menuFrm = new MainWindow();//crea una pantalla de inicio
            menuFrm.Show();//muestra la pantalla inicio
            this.Close();//cierra la pantalla
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)//boton cerrar
        {
            this.Close();//cierra la pantalla
        }

        private void btnMini_Click(object sender, RoutedEventArgs e)//boton minimizar
        {
            this.WindowState = WindowState.Minimized;//minimiza
        }

        private void btn1_Click(object sender, RoutedEventArgs e)//boton 1
        {
            if (cont < 4)//revisa que falten digitos al numero
            {
                if (cont == 0)//revisa que digito falta desde el 1 al 4
                {
                    elnumero.Dig1 = "1";//setea el digito 1
                    if (elnumero.Dig1.Equals("1"))//revisa si el numero se guardo 
                    {
                        esconder.Dig1 = "♠";//cambia el digito en pantalla
                        cont++;//suma el contador de digito
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "1";
                    if (elnumero.Dig2.Equals("1"))
                    {
                        esconder.Dig2 = "♣";
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "1";
                    if (elnumero.Dig3.Equals("1"))
                    {
                        esconder.Dig3 = "♦";
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "1";
                    if (elnumero.Dig4.Equals("1"))
                    {
                        esconder.Dig4 = "♥";
                        cont++;
                    }
                }
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "2";
                    if (elnumero.Dig1.Equals("2"))
                    {
                        esconder.Dig1 = "♠";
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "2";
                    if (elnumero.Dig2.Equals("2"))
                    {
                        esconder.Dig2 = "♣";
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "2";
                    if (elnumero.Dig3.Equals("2"))
                    {
                        esconder.Dig3 = "♦";
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "2";
                    if (elnumero.Dig4.Equals("2"))
                    {
                        esconder.Dig4 = "♥";
                        cont++;
                    }
                }
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont < 4)
                {
                    if (cont == 0)
                    {
                        elnumero.Dig1 = "3";
                        if (elnumero.Dig1.Equals("3"))
                        {
                            esconder.Dig1 = "♠";
                            cont++;
                        }

                    }
                    else if (cont == 1)
                    {
                        elnumero.Dig2 = "3";
                        if (elnumero.Dig2.Equals("3"))
                        {
                            esconder.Dig2 = "♣";
                            cont++;
                        }
                    }
                    else if (cont == 2)
                    {
                        elnumero.Dig3 = "3";
                        if (elnumero.Dig3.Equals("3"))
                        {
                            esconder.Dig3 = "♦";
                            cont++;
                        }
                    }
                    else if (cont == 3)
                    {
                        elnumero.Dig4 = "3";
                        if (elnumero.Dig4.Equals("3"))
                        {
                            esconder.Dig4 = "♥";
                            cont++;
                        }
                    }
                }
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "4";
                    if (elnumero.Dig1.Equals("4"))
                    {
                        esconder.Dig1 = "♠";
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "4";
                    if (elnumero.Dig2.Equals("4"))
                    {
                        esconder.Dig2 = "♣";
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "4";
                    if (elnumero.Dig3.Equals("4"))
                    {
                        esconder.Dig3 = "♦";
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "4";
                    if (elnumero.Dig4.Equals("4"))
                    {
                        esconder.Dig4 = "♥";
                        cont++;
                    }
                }
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "5";
                    if (elnumero.Dig1.Equals("5"))
                    {
                        esconder.Dig1 = "♠";
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "5";
                    if (elnumero.Dig2.Equals("5"))
                    {
                        esconder.Dig2 = "♣";
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "5";
                    if (elnumero.Dig3.Equals("5"))
                    {
                        esconder.Dig3 = "♦";
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "5";
                    if (elnumero.Dig4.Equals("5"))
                    {
                        esconder.Dig4 = "♥";
                        cont++;
                    }
                }
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "6";
                    if (elnumero.Dig1.Equals("6"))
                    {
                        esconder.Dig1 = "♠";
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "6";
                    if (elnumero.Dig2.Equals("6"))
                    {
                        esconder.Dig2 = "♣";
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "6";
                    if (elnumero.Dig3.Equals("6"))
                    {
                        esconder.Dig3 = "♦";
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "6";
                    if (elnumero.Dig4.Equals("6"))
                    {
                        esconder.Dig4 = "♥";
                        cont++;
                    }
                }
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "7";
                    if (elnumero.Dig1.Equals("7"))
                    {
                        esconder.Dig1 = "♠";
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "7";
                    if (elnumero.Dig2.Equals("7"))
                    {
                        esconder.Dig2 = "♣";
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "7";
                    if (elnumero.Dig3.Equals("7"))
                    {
                        esconder.Dig3 = "♦";
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "7";
                    if (elnumero.Dig4.Equals("7"))
                    {
                        esconder.Dig4 = "♥";
                        cont++;
                    }
                }
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "8";
                    if (elnumero.Dig1.Equals("8"))
                    {
                        esconder.Dig1 = "♠";
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "8";
                    if (elnumero.Dig2.Equals("8"))
                    {
                        esconder.Dig2 = "♣";
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "8";
                    if (elnumero.Dig3.Equals("8"))
                    {
                        esconder.Dig3 = "♦";
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "8";
                    if (elnumero.Dig4.Equals("8"))
                    {
                        esconder.Dig4 = "♥";
                        cont++;
                    }
                }
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "9";
                    if (elnumero.Dig1.Equals("9"))
                    {
                        esconder.Dig1 = "♠";
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "9";
                    if (elnumero.Dig2.Equals("9"))
                    {
                        esconder.Dig2 = "♣";
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "9";
                    if (elnumero.Dig3.Equals("9"))
                    {
                        esconder.Dig3 = "♦";
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "9";
                    if (elnumero.Dig4.Equals("9"))
                    {
                        esconder.Dig4 = "♥";
                        cont++;
                    }
                }
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "0";
                    if (elnumero.Dig1.Equals("0"))
                    {
                        esconder.Dig1 = "♠";
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "0";
                    if (elnumero.Dig2.Equals("0"))
                    {
                        esconder.Dig2 = "♣";
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "0";
                    if (elnumero.Dig3.Equals("0"))
                    {
                        esconder.Dig3 = "♦";
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "0";
                    if (elnumero.Dig4.Equals("0"))
                    {
                        esconder.Dig4 = "♥";
                        cont++;
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)//boton enviar
        {
            if (cont == 4)//revisa que el numero tenga 4 digitos
            {
                Solo soloFrm = new Solo();//crea objeto clase solo/la del juego
                soloFrm.Show();//muestra el objeto
                soloFrm.NumUsu = elnumero;//da el numero a adivinar para el juego
                soloFrm.solo = false;//desactiva el campo solo
                this.Close();//cierra la pantalla
            }
            else
            {
                MessageBox.Show("El número debe tener 4 dígitos.");//avisa que faltan digitos al numero
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)//borrar digito
        {
            if (cont > 0)//revisa que haya algun digito a borrar
            {
                if (cont == 4)//ravisa que digito borra, del 4 al 1
                {
                    elnumero.Dig4 = "-";//cambia el valor del numero a "-"
                    esconder.Dig4 = "-";//cambia el valor en pantalla a "-"
                    cont--;
                }
                else if (cont == 3)
                {
                    elnumero.Dig3 = "-";
                    esconder.Dig3 = "-";
                    cont--;
                }
                else if (cont == 2)
                {
                    elnumero.Dig2 = "-";
                    esconder.Dig2 = "-";
                    cont--;
                }
                else if (cont == 1)
                {
                    elnumero.Dig1 = "-";
                    esconder.Dig1 = "-";
                    cont--;
                }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Alumno:" + "\r" + "\n" + " - -------- " + "\r" + "\n" + " Sección --");
        }


    }
}
