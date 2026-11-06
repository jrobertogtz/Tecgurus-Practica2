using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    //clase padre abstracta de los animales
    //no podemos crear directamente un objeto Animal

    public abstract class Animal
    {
        //atributos de la clase padre
        private string nombre;
        private string especie;
        private string raza;
        private int edad;
        private DateTime fechaNacimiento;
        private string observaciones;

        //propiedades publicas
        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raza { get => raza; set => raza = value; }
        public int Edad { get => edad; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }

        //constructor de la clase padre
        public Animal(string nombre, string especie, string raza,
            DateTime fechaNacimiento, string observaciones)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.raza = raza;
            this.fechaNacimiento = fechaNacimiento;
            this.observaciones = observaciones;

            //calculamos la edad inicial
            calcularEdad();
        }

        //metodo para calcular los años completos
        public void calcularEdad()
        {
            edad = DateTime.Today.Year - fechaNacimiento.Year;

            //verificamos si ya paso su cumpleaños este año
            if (DateTime.Today.Month < fechaNacimiento.Month ||
                (DateTime.Today.Month == fechaNacimiento.Month &&
                 DateTime.Today.Day < fechaNacimiento.Day))
            {
                edad--;
            }
        }

        //metodo abstracto que deberan implementar las clases hijas
        public abstract void cumpleanios();

        //metodo abstracto para mostrar su alimentacion
        public abstract void alimentacion();

        //metodo virtual para mostrar los datos generales
        public virtual void mostrarDatos()
        {
            calcularEdad();

            Console.WriteLine($"""
                Nombre: {nombre}
                Especie: {especie}
                Raza: {raza}
                Edad: {edad}
                Fecha de nacimiento: {fechaNacimiento:dd/MM/yyyy}
                Observaciones: {observaciones}
                """);
        }
    }
}

