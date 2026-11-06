using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    //creamos clase medico hija de profesional
    public class Medico : Profesional 
    {
        //variables unicas de abogado
        private string unidadTrabajo;
        private long nroConsultasMedicas;
        private long nroConsultasDomicilio;
        private long nroCirugias;

        //publicas sus variables
        public string UnidadTrabajo { get => unidadTrabajo; set => unidadTrabajo = value; }
        public long NroConsultasMedicas { get => nroConsultasMedicas; set => nroConsultasMedicas = value; }
        public long NroConsultasDomicilio { get => nroConsultasDomicilio; set => nroConsultasDomicilio = value; }
        public long NroCirugias { get => nroCirugias; set => nroCirugias = value; }

        //constructor de medico pero utilizando tambien las variables de la clase padre con base:
        public Medico(DateTime fechaEgreso, long nroTituloAcademico, string cedulaIdentidad, string nombres, string primerApellido, string segundoApellido, string direccion,string zona, string universidad,string unidadTrabajo, long nroConsultasMedicas, long nroConsultasDomicilio, long nroCirugias):base(fechaEgreso, nroTituloAcademico, cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, zona, universidad)
        {
            this.unidadTrabajo = unidadTrabajo;
            this.nroConsultasDomicilio = nroConsultasDomicilio;
            this.nroConsultasMedicas = nroConsultasMedicas;
            this.nroCirugias = nroCirugias;
        }

        //se declara  constructor vacio para su llenado
        public Medico()
        {
        }
        //utilizamos metodo de clase padre con override y cambiamos texto para mostrar lo que deseamos
        public override void cumpleanios()
        {
            base.cumpleanios();

            Console.WriteLine($"El medico tiene {aniosProfesional} desde su egreso ");
        }

        public override void mostrarDatos(Profesional profesional)
        {
            base.mostrarDatos(profesional);

            Console.WriteLine($""""""
                Unidad de trabajo : {unidadTrabajo}
                Total de consultas medicas: {nroConsultasMedicas}
                Total de consultas medicas a domicilio: {nroConsultasDomicilio}
                Total de cirugias: {nroCirugias}
                """""");
        }
    }
}
