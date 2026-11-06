using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cadenas
{
    public class Ejercio1
    {
        public string InvertirPalabras (string frase)
        {
            //creamos objeto de heramienta de cadenas de separar palabras para luego invertirlo

            HerramientasCadenas herramientasCadenas = new HerramientasCadenas();

            string[] palabras = herramientasCadenas.SepararPalabras (frase);

            string resultado = "";

            for(int i = palabras.Length -1; i >= 0; i--)
            {
                 resultado = resultado + " " + palabras[i];
    
            }

            return resultado;
        }

    }
}
