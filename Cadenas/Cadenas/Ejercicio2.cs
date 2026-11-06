using System;
using System.Collections.Generic;
using System.Text;

namespace Cadenas
{
    public class Ejercicio2
    {
        public int ContarPalabras(string frase, string busqueda)
        {
            int contador = 0;

            //creamos objeto para la llamar la clase de herramientas

            HerramientasCadenas herramientasCadenas = new HerramientasCadenas();

            //usamos el metodo de separa palabras de las herramientas
            string[] palabras = herramientasCadenas.SepararPalabras(frase);

            for (int i = 0; i < palabras.Length; i++)
            {
                if(palabras[i] == busqueda)
                    contador++;

            }

            return contador;
        }
    }
}
