using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoToqueFama
{
    public class toquefama
    {
        public int toques(Numero numUsu, Numero numRan)//metodo que cuenta los toques
        {
            int toques = 0;//almacena el numero de toques
            if (numUsu.Dig1 == numRan.Dig2)//compara los digitos y si son iguales suma 1 al contador
            {
                toques++;
            }
            if (numUsu.Dig1 == numRan.Dig3)
            {
                toques++;
            }
            if (numUsu.Dig1 == numRan.Dig4)
            {
                toques++;
            }
            if (numUsu.Dig2 == numRan.Dig1)
            {
                toques++;
            }
            if (numUsu.Dig2 == numRan.Dig3)
            {
                toques++;
            }
            if (numUsu.Dig2 == numRan.Dig4)
            {
                toques++;
            }
            if (numUsu.Dig3 == numRan.Dig1)
            {
                toques++;
            }
            if (numUsu.Dig3 == numRan.Dig2)
            {
                toques++;
            }
            if (numUsu.Dig3 == numRan.Dig4)
            {
                toques++;
            }
            if (numUsu.Dig4 == numRan.Dig1)
            {
                toques++;
            }
            if (numUsu.Dig4 == numRan.Dig2)
            {
                toques++;
            }
            if (numUsu.Dig4 == numRan.Dig3)
            {
                toques++;
            }
            return toques;//retorna el n°de toques
        }
        public int famas(Numero numUsu, Numero numRan)//metodo para contar las famas
        {
            int famas = 0;//almacena el numero de famas
            if (numUsu.Dig1 == numRan.Dig1)//compara los digitos y si son iguales suma 1 a las famas
            {
                famas++;
            }
            if (numUsu.Dig2 == numRan.Dig2)
            {
                famas++;
            }
            if (numUsu.Dig3 == numRan.Dig3)
            {
                famas++;
            }
            if (numUsu.Dig4 == numRan.Dig4)
            {
                famas++;
            }


            return famas;//retorna el n°de famas
        }

    }
}
