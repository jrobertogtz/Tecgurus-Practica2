using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Cadenas
{
    public class Ejercicio5
    {
        public string EsPalindromo (string frase)
        {
            string invertida = "";

            //recoremos caracter por caracter
            for (int i = frase.Length - 1; i >= 0; i--)
            { 
                //armamos la inverson de caracteres
               invertida = invertida + frase[i];                 
            }

            //if para validar si son iguales
            if (frase == invertida)
            {
                return $"Si es palindromo la palabra {frase} ";
            }
            else
            {
                return $"no es palindromo";
            }
        }

     

    }
}
