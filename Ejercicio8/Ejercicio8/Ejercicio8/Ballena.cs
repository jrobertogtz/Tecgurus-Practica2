using System;
using System.Collections.Generic;
using System.Text;


namespace Ejercicio8
{
    //clase hija Ballena que hereda de Animal
    public class Ballena : Animal
    {
        //atributos propios de la ballena
        private int cantidadAletas;
        private string colorPiel;

        //propiedades publicas
        public int CantidadAletas { get => cantidadAletas; set => cantidadAletas = value; }
        public string ColorPiel { get => colorPiel; set => colorPiel = value; }

        //constructor de la ballena utilizando base
        public Ballena(string nombre, string especie, string raza,
            DateTime fechaNacimiento, string observaciones,
            int cantidadAletas, string colorPiel)
            : base(nombre, especie, raza, fechaNacimiento, observaciones)
        {
            this.cantidadAletas = cantidadAletas;
            this.colorPiel = colorPiel;
        }

        //sobrescribimos el metodo cumpleaños
        public override void cumpleanios()
        {
            calcularEdad();
            Console.WriteLine($"La ballena {Nombre} cumple años el {FechaNacimiento:dd/MM}");
            Console.WriteLine($"Su edad es de {Edad} años");
        }

        //implementamos el metodo abstracto alimentacion
        public override void alimentacion()
        {
            Console.WriteLine("Alimentacion: krill y pequeños organismos marinos");
        }

        //mostramos los datos generales y propios
        public override void mostrarDatos()
        {
            base.mostrarDatos();

            Console.WriteLine($"""
                Cantidad de aletas: {cantidadAletas}
                Color de piel: {colorPiel}
                Habitat: marino
                """);
        }
    }
}