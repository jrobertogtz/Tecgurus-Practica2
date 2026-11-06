using System;
using System.Collections.Generic;
using System.Text;

namespace Cadenas
{

    // creo clase con herramientas que puedo usar en todos los ejercicios
    public class HerramientasCadenas
    {
        // se crea un metodo de areglo que recibe una frase
        public string[] SepararPalabras(string frase)
        {
            // creo areglo de los divisores de las posibles palabras
            char[] divisores = { ',', '.', ' ' };

            //uso metodo de cadena split para separar las palabras
            string[] palabras = frase.Split(divisores);

            return palabras;
        }

    }
}
