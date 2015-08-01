using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace JuegoToqueFama
{

    public class Numero : INotifyPropertyChanged
    {
        public string _dig1;//campo para guardar el 1° digito----son string para que no se borre el 0 si esta al principio
        public string Dig1 {//geter y seter del campo
            get { return _dig1; }//geter
            set {//seter
                _dig1 = value;
                NotifyChange("Dig1", "num");//avisa que el valor se cambio, para mostrarlo en pantalla
            } 
        }

        public string _dig2;
        public string Dig2
        {
            get { return _dig2; }
            set
            {
                if (value != Dig1)//revisa que el digito 2 sea distinto al 1 antes de setearlo
                {
                    _dig2 = value;
                    NotifyChange("Dig2", "num");
                }
            }
        }

        public string _dig3;
        public string Dig3
        {
            get { return _dig3; }
            set
            {
                if (value != Dig1 && value != Dig2)//revisa que el digito 3 sea distinto al 1y2 antes de setearlo
                {
                    _dig3 = value;
                    NotifyChange("Dig3", "num");
                }
            }
        }

        public string _dig4;
        public string Dig4
        {
            get { return _dig4; }
            set
            {
                if (value != Dig1 && value != Dig2 && value != Dig3)//revisa que el digito 4 sea distinto al 1,2y3 antes de setearlo
                {
                    _dig4 = value;
                    NotifyChange("Dig4", "num");
                }
            }
        }

        public string num//campo que muestra el numero como uno solo
        {
            get { return Dig1 + Dig2 + Dig3 + Dig4; }//junta los numeritos
        }

        void NotifyChange(params string[] ids)//metodo para avisar del cambio en el valor, como en el video del español
        {
            if (PropertyChanged != null)
            {
                foreach (var id in ids)//por cada campo avisa que este cambio
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(id));//avisa que cambio el campo
                }
            }
        }

        public string[] generacion() //Genera un numero random validándolo que no se repita el número
        {
            string[] num = new string[4];//arreglo de string para guardar los digitos
            Random ran = new Random();//random para el azar, usa int

            num[0] = ran.Next(0, 9).ToString();//setea el primer digito (del 0 al 9) y lo convierte a string para guardarlo
            do
            {
                num[1] = ran.Next(0, 9).ToString();
            } while (num[1] == num[0]);//setea el segundo hasta que sea distinto del primero
            do
            {
                num[2] = ran.Next(0, 9).ToString();
            } while (num[2] == num[0] || num[2] == num[1]);//setea el 3 hasta que sea distinto del 2 y 1
            do
            {
                num[3] = ran.Next(0, 9).ToString();
            } while (num[3] == num[0] || num[3] == num[1] || num[3] == num[2]);//setea el 4 hasta que sea distinto del 3,2y1

            return num;//devuelve el numero generado
        }

        public event PropertyChangedEventHandler PropertyChanged; //Avisa que hubo un cambio en la clase Numero
    }


}