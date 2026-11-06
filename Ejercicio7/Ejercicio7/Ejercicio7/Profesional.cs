using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ejercicio7
{

    //creamos clase profesional
    public class Profesional
    {
        //variables privadas de caca tipo de dato
        private DateTime fechaEgreso;
        private long nroTituloAcademico;
        private string cedulaIdentidad;
        private string nombres;
        private string primerApellido;
        private string segundoApellido;
        private string direccion;

        //variables adicionales para comparaciones de ejercicio
        private string universidad;
        private string zona;


        //creamos accesos a las variables
        public DateTime FechaEgreso { get => fechaEgreso; set => fechaEgreso = value; }
        public long NroTituloAcadamico { get => nroTituloAcademico; set => nroTituloAcademico = value; }
        public string CedulaIdentidad { get => cedulaIdentidad; set => cedulaIdentidad = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Zona { get => zona; set => zona = value; }
        public string Universidad { get => universidad; set => universidad = value; }

        //constructor de llenado de profesional
        public Profesional (DateTime fechaEgreso, long nroTituloAcademico, string cedulaIdentidad, string nombres, string primerApellido, string segundoApellido, string direccion, string zona, string universidad)
        {
            this.fechaEgreso = fechaEgreso;
            this.nroTituloAcademico = nroTituloAcademico;
            this.cedulaIdentidad = cedulaIdentidad;
            this.nombres = nombres;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.direccion = direccion;
            this.zona = zona;
            this.universidad = universidad;
        }

        public Profesional()
        {
        }

        //variable proctected para que lo puedan usar en el override
        protected int aniosProfesional 
        {
            // en get metemos lo que necesitamos que haga
            get { 
                //declaramos variable años ejerciodo y restamos
                    int aniosEjerciendo = DateTime.Now.Year - fechaEgreso.Year;
                // hacenis una validacion combinada para saber exactamente el año
                if (DateTime.Now.Month < fechaEgreso.Month ||
                    (DateTime.Now.Month == fechaEgreso.Month &&
                        DateTime.Now.Day < fechaEgreso.Day))
                {
                    //al ver que el mes actual es menor que el mes de la fecha de egreso y el diia lo mismo restamos un año por que aun no se cumple
                    aniosEjerciendo--;
                }
                //regresamos años ejerciendo ya con el menor
                return aniosEjerciendo;
            }


        }

        //permitimos consultar los años desde otras clases
        //pero el calculo sigue realizandose en la clase padre
        public int AniosProfesional
        {
            get => aniosProfesional;
        }
        



        //metodo virtual que podran usar las hijas y esta si se necesita

        public virtual void mostrarDatos(Profesional profesional)
        {

            Console.WriteLine($""""
                Los datos son
                Nombre completo : {profesional.nombres} {profesional.primerApellido} {profesional.segundoApellido}
                Direccion: {profesional.direccion}
                Fecha de titulacion: {profesional.fechaEgreso}
                Numero de titulo academico: {profesional.nroTituloAcademico}
                Numero de cedula de identidad: {profesional.cedulaIdentidad}
                Años desde du egreso{aniosProfesional}
                """");
        }
        public virtual void cumpleanios()
        {
            Console.WriteLine("Años desde el egreso: {0}",aniosProfesional);

        }

        
    }
}
