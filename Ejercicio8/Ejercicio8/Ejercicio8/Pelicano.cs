using System;
using System.Collections.Generic;
using System.Text;


namespace Ejercicio8
{
    //clase hija Pelicano que hereda de Animal
    public class Pelicano : Animal
    {
        //atributos propios del pelicano
        private string colorPico;
        private string colorPlumas;

        //propiedades publicas
        public string ColorPico { get => colorPico; set => colorPico = value; }
        public string ColorPlumas { get => colorPlumas; set => colorPlumas = value; }

        //constructor del pelicano utilizando base
        public Pelicano(string nombre, string especie, string raza,
            DateTime fechaNacimiento, string observaciones,
            string colorPico, string colorPlumas)
            : base(nombre, especie, raza, fechaNacimiento, observaciones)
        {
            this.colorPico = colorPico;
            this.colorPlumas = colorPlumas;
        }

        //sobrescribimos el metodo cumpleaños
        public override void cumpleanios()
        {
            calcularEdad();
            Console.WriteLine($"El pelicano {Nombre} cumple años el {FechaNacimiento:dd/MM}");
            Console.WriteLine($"Su edad es de {Edad} años");
        }

        //implementamos el metodo abstracto alimentacion
        public override void alimentacion()
        {
            Console.WriteLine("Alimentacion: principalmente peces");
        }

        //mostramos datos generales y propios
        public override void mostrarDatos()
        {
            base.mostrarDatos();

            Console.WriteLine($"""
                Color del pico: {colorPico}
                Color de plumas: {colorPlumas}
                Habitat: zonas costeras y humedales
                """);
        }
    }
}