using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    //creamos clase abogado hija de profesional
    public class Abogado : Profesional
    {
        //variables unicas de abogado
        private string nombreJuzgado;
        private int nroJuiciosProceso;
        private int nroJuicisFinalizado;
        //publicas sus variables
        public string NombreJuzgado { get => nombreJuzgado; set => nombreJuzgado = value; }
        public int NroJuiciosProceso { get => nroJuiciosProceso; set => nroJuiciosProceso = value; }
        public int NroJuicisFinalizado { get => nroJuicisFinalizado; set => nroJuicisFinalizado = value; }

        
        //constructor de abogado pero utilizando tambien las variables de la clase padre con base:
        public Abogado(DateTime fechaEgreso, long nroTituloAcademico, string cedulaIdentidad, string nombres, string primerApellido, string segundoApellido, string direccion,string zona, string universidad, string nombreJuzgado, int nroJuiciosProceso,  int nroJuicisFinalizado) : base(fechaEgreso, nroTituloAcademico, cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, zona, universidad)
        {
            this.nombreJuzgado = nombreJuzgado;
            this.nroJuiciosProceso = nroJuiciosProceso;
            this.nroJuicisFinalizado = nroJuicisFinalizado;

        }

        //se declara  constructor vacio para su llenado
        public Abogado() 
        {
        }
        //utilizamos metodo de clase padre y cambiamos texto para mostrar lo que deseamos

        public override void mostrarDatos(Profesional profesional)
        {
            base.mostrarDatos(profesional);

            Console.WriteLine($""""""
                Nombre Juzgado: {nombreJuzgado}
                Total de juicios en proceso: {nroJuiciosProceso}
                Total de juicios finalizados: {nroJuicisFinalizado}
                """""");
        }
        public override void cumpleanios()
        {
            base.cumpleanios();

            Console.WriteLine($"El abogado tiene {aniosProfesional} desde su egreso ");
        }
    }
}
