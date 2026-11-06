using System;
using System.Collections.Generic;
using System.Text;



namespace Ejercicio8
{
    //clase hija Perro que hereda de Animal
    public class Perro : Animal
    {
        //atributos propios del perro
        private int cantidadPatas;
        private string colorPelaje;

        //propiedades publicas
        public int CantidadPatas { get => cantidadPatas; set => cantidadPatas = value; }
        public string ColorPelaje { get => colorPelaje; set => colorPelaje = value; }

        //constructor del perro utilizando los datos del padre con base
        public Perro(string nombre, string especie, string raza,
            DateTime fechaNacimiento, string observaciones,
            int cantidadPatas, string colorPelaje)
            : base(nombre, especie, raza, fechaNacimiento, observaciones)
        {
            this.cantidadPatas = cantidadPatas;
            this.colorPelaje = colorPelaje;
        }

        //sobrescribimos el metodo abstracto del padre
        public override void cumpleanios()
        {
            calcularEdad();
            Console.WriteLine($"El perro {Nombre} cumple años el {FechaNacimiento:dd/MM}");
            Console.WriteLine($"Su edad es de {Edad} años");
        }

        //implementamos el metodo abstracto de alimentacion
        public override void alimentacion()
        {
            Console.WriteLine("Alimentacion: comida adecuada para perros");
        }

        //mostramos los datos heredados y los propios
        public override void mostrarDatos()
        {
            base.mostrarDatos();

            Console.WriteLine($"""
                Cantidad de patas: {cantidadPatas}
                Color de pelaje: {colorPelaje}
                Habitat: domestico
                """);
        }
    }
}
