namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido. LLenaras datos de dos profesionales. un Abogado y un Medico");
            Console.WriteLine("Empecemos por el Abogado:");
            //creamos objeto abogado
            Abogado abogado = new Abogado();
            Console.WriteLine("Indicame su nombre o nombres sin apellidos");
            abogado.Nombres = (Console.ReadLine());
            Console.WriteLine("Indicame su primer Apellido");
            abogado.PrimerApellido = (Console.ReadLine());
            Console.WriteLine("Indicame su segungo Apellido");
            abogado.SegundoApellido = (Console.ReadLine());
            Console.WriteLine("Indicame su Dirrecion ");
            abogado.Direccion = (Console.ReadLine());
            Console.WriteLine("Indicame su zona ");
            abogado.Zona = (Console.ReadLine());
            Console.WriteLine("Indicame cual es el nombre de su universidad ");
            abogado.Universidad = (Console.ReadLine());
            Console.WriteLine("Indicame su fecha de titulacion en el siguiete formato dd/mm/aaaa");
            abogado.FechaEgreso = Convert.ToDateTime((Console.ReadLine()));
            Console.WriteLine("Indicame su Numero de titulo academedico");
            abogado.NroTituloAcadamico = Convert.ToInt64((Console.ReadLine()));
            Console.WriteLine("Indicame su cedula de indentidad ");
            abogado.CedulaIdentidad = (Console.ReadLine());
            
            ///apartir de aqui empieza lo de la clase abogado
            Console.WriteLine("Indicame cual es el nombre de su juzgado ");
            abogado.NombreJuzgado = (Console.ReadLine());
            Console.WriteLine("Indicame cuantos juicios tiene en proceso");
            abogado.NroJuiciosProceso = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Indicame cuantos juicios tiene finalizados");
            abogado.NroJuicisFinalizado = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("");
            //empezamos ahora con el llenado de medico
            Medico medico = new Medico();
            Console.WriteLine("Ahora continuamos con el Medico");
            Console.WriteLine("Indicame su nombre o nombres sin apellidos");
            medico.Nombres = (Console.ReadLine());
            Console.WriteLine("Indicame su primer Apellido");
            medico.PrimerApellido = (Console.ReadLine());
            Console.WriteLine("Indicame su segungo Apellido");
            medico.SegundoApellido = (Console.ReadLine());
            Console.WriteLine("Indicame su Dirrecion ");
            medico.Direccion = (Console.ReadLine());
            Console.WriteLine("Indicame su zona ");
            medico.Zona = (Console.ReadLine());
            Console.WriteLine("Indicame cual es el nombre de su universidad ");
            medico.Universidad = (Console.ReadLine());
            Console.WriteLine("Indicame su fecha de titulacion en el siguiete formato dd/mm/aaaa");
            medico.FechaEgreso = Convert.ToDateTime((Console.ReadLine()));
            Console.WriteLine("Indicame su Numero de titulo academedico");
            medico.NroTituloAcadamico = Convert.ToInt64((Console.ReadLine()));
            Console.WriteLine("Indicame su cedula de indentidad ");
            medico.CedulaIdentidad = (Console.ReadLine());
            ///apartir de aqui empieza lo de la clase medico
            Console.WriteLine("Indicame en que unidad labora ");
            medico.UnidadTrabajo = (Console.ReadLine());
            Console.WriteLine("Indicame cuantas consultas medicas a tenido");
            medico.NroConsultasMedicas = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Indicame cuantas consultas medicas a domicilio tenido");
            medico.NroConsultasDomicilio = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Indicame cuantas cirugias a tenido");
            medico.NroCirugias = Convert.ToInt32((Console.ReadLine()));

            //--------- C ---------
            //mostramos todos los datos de los dos profesionales
            Console.WriteLine("Datos del abogado");
            abogado.mostrarDatos(abogado);
            Console.WriteLine("");
            Console.WriteLine("Datos del medico");
            medico.mostrarDatos(medico);

            //---------  B ---------
            //mandamos llamar el metodo para comparar los profesionales
            CompararProfesionales(medico, abogado);

            //---------  F ---------
            //mostramos cuantos juicios tiene en proceso el abogado

            Console.WriteLine("\nJuicios en proceso del abogado:");
            Console.WriteLine($"El abogado {abogado.Nombres} tiene {abogado.NroJuiciosProceso} juicios en proceso");

            //---------  D ---------
            //verificamos si los dos profesionales estudiaron en la misma universidad

            if (string.Equals(abogado.Universidad, medico.Universidad,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Los dos profesionales estudiaron en la misma universidad");
            }
            else
            {
                Console.WriteLine("Los profesionales estudiaron en diferentes universidades");
            }


            //--------- IE ---------
            //verificamos si los dos profesionales viven en la misma zona

            if (string.Equals(abogado.Zona, medico.Zona,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Los dos profesionales viven en la misma zona");
            }
            else
            {
                Console.WriteLine("Los profesionales viven en diferentes zonas");
            }

        }

        //--------- B comparativo ---------
        //comparamos cuantos años tienen los profesionales desde su egreso
        //recibimos los dos objetos que ya creamos en el Main

        static void CompararProfesionales(Medico medico, Abogado abogado)
        {
            Console.WriteLine("\nComparacion de años de los profesionales");

            //verificamos si el medico tiene mas años
            if (medico.AniosProfesional > abogado.AniosProfesional)
            {
                Console.WriteLine("El medico tiene mas años desde su egreso");

                //mostramos sus años y datos personales
                Console.WriteLine($"Años: {medico.AniosProfesional}");
                medico.mostrarDatos(medico);
            }
            //verificamos si el abogado tiene mas años
            else if (abogado.AniosProfesional > medico.AniosProfesional)
            {
                Console.WriteLine("El abogado tiene mas años desde su egreso");

                //mostramos sus datos personales y laborales
                abogado.mostrarDatos(abogado);
            }
            else
            {
                //si los dos tienen los mismos años mostramos ambos
                Console.WriteLine("Los dos profesionales tienen los mismos años");

                medico.mostrarDatos(medico);
                abogado.mostrarDatos(abogado);
            }
        }
    }

}
