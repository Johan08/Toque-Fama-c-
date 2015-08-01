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
using System.Dynamic;

namespace JuegoToqueFama
{
    /// <summary>
    /// Lógica de interacción para Solo.xaml
    /// </summary>
    public partial class Solo : Window
    {
        int cont = 0;//contador para saber n° de digitos ingresados y controlar cual borrar/agregar
        private Numero elnumero;//objeto de la clase numero para guardar el numero que se ingresa
        private Numero NumRan;//para guardar el numero generado al azar
        public Numero NumUsu;//para guardar el numero del usuario en multijigador
        int intentos, toques, famas;//para contar los n° de intentos, toques y famas
        private toquefama toqfam;//clase para contar los toques y famas
        string[] labels;//arreglo de string para guardar el encabezado de la tabla del grid(intentos/famas/toques/numero)
        string[] numazar;//arreglo para guardar el numero generado al azar antes de setearlos al objeto NumRan
        public bool solo = true;//bool para saber si es solo o multi--- true=solo / false=multi

        
        public Solo()
        {
            InitializeComponent();//inicia
            toqfam = new toquefama();//crea el objeto
            NumRan = new Numero();//crea el objeto
            NumUsu = new Numero();//crea el objeto
            numazar = NumRan.generacion();//guarda en el arreglo los numeros generados al azar
            NumRan.Dig1 = numazar[0];//setea los digitos al azar
            NumRan.Dig2 = numazar[1];
            NumRan.Dig3 = numazar[2];
            NumRan.Dig4 = numazar[3];
            intentos = 0;//inicia el contador de intentos
            elnumero = new Numero { Dig4 = "-", Dig3 = "-", Dig2 = "-", Dig1 = "-" };//setea valores del numero del usuario para mostrar en pantalla
            DataContext = elnumero;//da la ruta de donde sale la info de la pantalla / los numeros
            labels = new string[] { "N º de Intentos", "N º de Famas", "N º de Toques", "N º de Número" };//los encabezados de la tabla del grid

            
            foreach (string label in labels)//for por cada objeto del areglo labels
            {
                DataGridTextColumn column = new DataGridTextColumn();//crea objeto columna ↕
                column.Header = label;//asigna el string del arreglo para la columna
                column.Binding = new Binding(label.Replace(' ', '_'));

                info.Columns.Add(column);//crea la columna en la tabla
            }
        }

        public void move(object sender, MouseButtonEventArgs e)//metodo mover
        {
            DragMove();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)//boton 1
        {
            if (cont < 4)//revisa si falta algun digito
            {
                if (cont == 0)//revisa que digito falta del 1 al 4
                {
                    elnumero.Dig1 = "1";//setea el valor del digito a 1
                    if (elnumero.Dig1.Equals("1"))//revisa si cambio el numero
                    {
                        cont++;//suma al contador del digito
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "1";
                    if (elnumero.Dig2.Equals("1"))
                    {
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "1";
                    if (elnumero.Dig3.Equals("1"))
                    {
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "1";
                    if (elnumero.Dig4.Equals("1"))
                    {
                        cont++;
                    }
                }
            }
        }


        private void btn2_Click_1(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "2";
                    if (elnumero.Dig1.Equals("2"))
                    {
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "2";
                    if (elnumero.Dig2.Equals("2"))
                    {
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "2";
                    if (elnumero.Dig3.Equals("2"))
                    {
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "2";
                    if (elnumero.Dig4.Equals("2"))
                    {
                        cont++;
                    }
                }
            }
        }

        private void btn3_Click_1(object sender, RoutedEventArgs e)
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
                            cont++;
                        }

                    }
                    else if (cont == 1)
                    {
                        elnumero.Dig2 = "3";
                        if (elnumero.Dig2.Equals("3"))
                        {
                            cont++;
                        }
                    }
                    else if (cont == 2)
                    {
                        elnumero.Dig3 = "3";
                        if (elnumero.Dig3.Equals("3"))
                        {
                            cont++;
                        }
                    }
                    else if (cont == 3)
                    {
                        elnumero.Dig4 = "3";
                        if (elnumero.Dig4.Equals("3"))
                        {
                            cont++;
                        }
                    }
                }
            }
        }

        private void btn4_Click_1(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "4";
                    if (elnumero.Dig1.Equals("4"))
                    {
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "4";
                    if (elnumero.Dig2.Equals("4"))
                    {
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "4";
                    if (elnumero.Dig3.Equals("4"))
                    {
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "4";
                    if (elnumero.Dig4.Equals("4"))
                    {
                        cont++;
                    }
                }
            }
        }

        private void btn5_Click_1(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "5";
                    if (elnumero.Dig1.Equals("5"))
                    {
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "5";
                    if (elnumero.Dig2.Equals("5"))
                    {
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "5";
                    if (elnumero.Dig3.Equals("5"))
                    {
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "5";
                    if (elnumero.Dig4.Equals("5"))
                    {
                        cont++;
                    }
                }
            }
        }

        private void btn6_Click_1(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "6";
                    if (elnumero.Dig1.Equals("6"))
                    {
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "6";
                    if (elnumero.Dig2.Equals("6"))
                    {
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "6";
                    if (elnumero.Dig3.Equals("6"))
                    {
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "6";
                    if (elnumero.Dig4.Equals("6"))
                    {
                        cont++;
                    }
                }
            }
        }

        private void btn7_Click_1(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "7";
                    if (elnumero.Dig1.Equals("7"))
                    {
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "7";
                    if (elnumero.Dig2.Equals("7"))
                    {
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "7";
                    if (elnumero.Dig3.Equals("7"))
                    {
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "7";
                    if (elnumero.Dig4.Equals("7"))
                    {
                        cont++;
                    }
                }
            }
        }

        private void btn8_Click_1(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "8";
                    if (elnumero.Dig1.Equals("8"))
                    {
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "8";
                    if (elnumero.Dig2.Equals("8"))
                    {
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "8";
                    if (elnumero.Dig3.Equals("8"))
                    {
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "8";
                    if (elnumero.Dig4.Equals("8"))
                    {
                        cont++;
                    }
                }
            }
        }

        private void bttn9_Click_1(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "9";
                    if (elnumero.Dig1.Equals("9"))
                    {
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "9";
                    if (elnumero.Dig2.Equals("9"))
                    {
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "9";
                    if (elnumero.Dig3.Equals("9"))
                    {
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "9";
                    if (elnumero.Dig4.Equals("9"))
                    {
                        cont++;
                    }
                }
            }
        }

        private void btn0_Click_1(object sender, RoutedEventArgs e)
        {
            if (cont < 4)
            {
                if (cont == 0)
                {
                    elnumero.Dig1 = "0";
                    if (elnumero.Dig1.Equals("0"))
                    {
                        cont++;
                    }

                }
                else if (cont == 1)
                {
                    elnumero.Dig2 = "0";
                    if (elnumero.Dig2.Equals("0"))
                    {
                        cont++;
                    }
                }
                else if (cont == 2)
                {
                    elnumero.Dig3 = "0";
                    if (elnumero.Dig3.Equals("0"))
                    {
                        cont++;
                    }
                }
                else if (cont == 3)
                {
                    elnumero.Dig4 = "0";
                    if (elnumero.Dig4.Equals("0"))
                    {
                        cont++;
                    }
                }
            }
        }

        private void btnBorrar_Click_1(object sender, RoutedEventArgs e)//boton borrar
        {
            if (cont > 0)//revisa que haya algun digito que borrar
            {
                if (cont == 4)//revisa que digito borrar, del 4 al 1
                {
                    elnumero.Dig4 = "..";//setea el valor en "-" para mostrarlo en pantalla
                    cont--;//resta del contador de digito
                }
                else if (cont == 3)
                {
                    elnumero.Dig3 = "..";
                    cont--;
                }
                else if (cont == 2)
                {
                    elnumero.Dig2 = "..";
                    cont--;
                }
                else if (cont == 1)
                {
                    elnumero.Dig1 = "..";
                    cont--;
                }
            }
        }

        private void btnEnviar_Click_1(object sender, RoutedEventArgs e)//boton enviar
        {
            if (intentos < 15)//revisa el numero del intento
            {
                
                if (cont == 4)//revisa que sea un numero de 4 digitos
                {
                    if (solo)//revisa si es solo o multi
                    {
                        toques = toqfam.toques(elnumero, NumRan);//compara los toques
                        famas = toqfam.famas(elnumero, NumRan);//compara las famas
                    }
                    else
                    {
                        toques = toqfam.toques(elnumero, NumUsu);
                        famas = toqfam.famas(elnumero, NumUsu);
                    }
                    cont = 0;//setea el contador de digitos a 0
                    intentos++;//suma un intento al contador
                    string[] values = new string[] { intentos.ToString(), famas.ToString(), toques.ToString(), elnumero.num };//arreglo para guardar los datos de la tabla
                    dynamic row = new ExpandoObject();//crea un objeto para guardar los datos en las filas dela tabla del grid ↔

                    ((IDictionary<String, Object>)row)[labels[0].Replace(' ', '_')] = values[0];//setea el 1° valor de la fila ↔
                    ((IDictionary<String, Object>)row)[labels[1].Replace(' ', '_')] = values[1];//2 valor de la wea
                    ((IDictionary<String, Object>)row)[labels[2].Replace(' ', '_')] = values[2];//3
                    ((IDictionary<String, Object>)row)[labels[3].Replace(' ', '_')] = values[3];//4
                    info.Items.Add(row);//añande la fila a la tabla del grid ↔

                    //if (intentos == 1)
                    //{
                    //    if (solo)
                    //    {
                    //       MessageBox.Show(NumRan.num);
                    //    }
                    //}

                    if (famas == 4)
                    {
                        Ganador ganaFrm = new Ganador();//crea objeto de la clase ganador            
                        ganaFrm.Show();//muestra la pantalla ganador

                        if (solo)//muestra valor del numero al azar a adivinar, para probar el juego
                        {
                            this.Close();//cierra la pantalla
                            MessageBox.Show("Has adivinado el número: "+NumRan.num + "\n Felicidades");
                        }
                        else//lo mismo pero el numero multijigador
                        {
                            this.Close();//cierra la pantalla
                            MessageBox.Show("Has adivinado el número: " + NumUsu.num + "\n Felicidades");
                        }

                        
                    }
                    else
                    {

                        if (intentos == 15)//si el numero de intentos llega a 15 muestra pantalla perder
                        {
                            Perdedor perFrm = new Perdedor();//crea objeto de la clase perdedor
                            perFrm.Show();//muestra la pantalla de perdedor
                            if (solo)//muestra valor del numero al azar a adivinar, para probar el juego
                            {
                                this.Close();//cierra la pantalla
                                MessageBox.Show("Has perdido, el número era: "+NumRan.num);
                            }
                            else//lo mismo pero el numero multijigador
                            {
                                this.Close();//cierra la pantalla
                                MessageBox.Show("Has perdido, el número era: "+NumUsu.num);
                            }
                           
                        }

                       
                    }

                    elnumero.Dig4 = "-";//setea los valores a "-" para la pantalla
                    elnumero.Dig3 = "-";
                    elnumero.Dig2 = "-";
                    elnumero.Dig1 = "-";
                }
                else
                {
                    MessageBox.Show("ADVERTENCIA: El número debe tener 4 dígitos.");//mensaje que el numero tiene que tener 4 digitos
                }
            }
            else
            {
                MessageBox.Show("Juego Finalizado. D:");//mensaje no mas intentos
            }
        
        }

       
        private void btnCerrar_Click_1(object sender, RoutedEventArgs e)//boton cerrar
        {
            this.Close();//cierra la pantalla
        }

        private void btnMini_Click(object sender, RoutedEventArgs e)//boton minimizar
        {
            this.WindowState = WindowState.Minimized;//minimiza la pantalla
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)//boton inicio del menu
        {
            MainWindow menuFrm = new MainWindow();//crea objeto de la clase main            
            menuFrm.Show();//muestra la pantalla inicio
            this.Close();//cierra la pantalla
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Alumno:" + "\r" + "\n" + " - -------- " + "\r" + "\n" + " Sección --");
        }
        
    }    
}