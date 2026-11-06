namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 8 - HERENCIA ABSTRACTA");

            //--------- Inciso A ---------
            //creamos un objeto de cada clase hija
            //los constructores utilizan base para los datos heredados

            Perro perro = new Perro(
                "Max", "Canino", "Labrador",
                new DateTime(2020, 5, 15),
                "Animal domestico", 4, "Cafe");

            Ballena ballena = new Ballena(
                "Luna", "Cetaceo", "Ballena azul",
                new DateTime(2015, 8, 20),
                "Animal marino", 2, "Azul grisaceo");

            Pelicano pelicano = new Pelicano(
                "Paco", "Ave", "Pelicano pardo",
                new DateTime(2022, 3, 10),
                "Ave costera", "Amarillo", "Cafe");


            //--------- Incisos B, C, D y E ---------
            //mostramos los datos de cada animal
            //incluye fecha de nacimiento, edad y habitat

            Console.WriteLine("\nDATOS DEL PERRO");
            perro.mostrarDatos();
            perro.cumpleanios();
            perro.alimentacion();

            Console.WriteLine("\nDATOS DE LA BALLENA");
            ballena.mostrarDatos();
            ballena.cumpleanios();
            ballena.alimentacion();

            Console.WriteLine("\nDATOS DEL PELICANO");
            pelicano.mostrarDatos();
            pelicano.cumpleanios();
            pelicano.alimentacion();


            //--------- Inciso F ---------
            //comparamos las edades de los tres animales
            CompararEdades(perro, ballena, pelicano);

            Console.ReadKey();
        }


        //--------- Metodo para comparar edades ---------
        //recibimos los tres objetos utilizando la clase padre Animal
        //asi mantenemos el Main limpio

        static void CompararEdades(
            Perro perro, Ballena ballena, Pelicano pelicano)
        {
            //actualizamos las edades antes de comparar
            perro.calcularEdad();
            ballena.calcularEdad();
            pelicano.calcularEdad();

            //guardamos los animales en una lista
            List<Animal> animales = new List<Animal>()
            {
                perro, ballena, pelicano
            };

            //obtenemos la edad mayor y menor
            int edadMayor = animales.Max(a => a.Edad);
            int edadMenor = animales.Min(a => a.Edad);

            Console.WriteLine("\nCOMPARACION DE EDADES");

            //mostramos los animales con mayor edad
            Console.WriteLine("Animal o animales de mayor edad:");

            foreach (Animal animal in animales)
            {
                if (animal.Edad == edadMayor)
                {
                    Console.WriteLine($"{animal.Nombre}: {animal.Edad} años");
                }
            }

            //mostramos los animales con menor edad
            Console.WriteLine("Animal o animales de menor edad:");

            foreach (Animal animal in animales)
            {
                if (animal.Edad == edadMenor)
                {
                    Console.WriteLine($"{animal.Nombre}: {animal.Edad} años");
                }
            }

            //verificamos si existen animales con la misma edad
            Console.WriteLine("\nVerificacion de edades iguales:");

            bool hayIguales = false;

            for (int i = 0; i < animales.Count; i++)
            {
                for (int j = i + 1; j < animales.Count; j++)
                {
                    if (animales[i].Edad == animales[j].Edad)
                    {
                        Console.WriteLine(
                            $"{animales[i].Nombre} y {animales[j].Nombre} " +
                            $"tienen la misma edad: {animales[i].Edad} años");

                        hayIguales = true;
                    }
                }
            }

            if (!hayIguales)
            {
                Console.WriteLine("Ningun animal tiene la misma edad");
            }
        }
    }
}
