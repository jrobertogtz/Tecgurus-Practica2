namespace Cadenas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Ejercicio 1------");
            Console.WriteLine("Escriba una frase y la devolvere con las palabras en acomodo de atras hacia adelante.");
            string?  mensaje = Console.ReadLine();
            
            //creamos el objeto 1

            Ejercio1 ejercicio1 = new Ejercio1();

            //a mensaje le asignamos  el metodo del ejercio 1 con el parametro que ya se le pidio al usuario
           mensaje = ejercicio1.InvertirPalabras(mensaje);
            //imprimimos en consola
            Console.WriteLine(mensaje);


            Console.WriteLine("------Ejercicio 2------");
            Console.WriteLine("Escriba una frase.");
            string? mensaje2 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Escriba que palabra quiere contar en su mensaje");
            string? busqueda = Console.ReadLine();


            //creamos el objeto 2 y la variable cantidad para almacenar el contador

            Ejercicio2 ejercicio2 = new Ejercicio2();
            int cantidad = ejercicio2.ContarPalabras(mensaje2, busqueda);

      
            //imprimimos en consola
            Console.WriteLine(cantidad);


            Console.WriteLine("------Ejercicio 5------");
            Console.WriteLine("Escriba una frase para ver si es palidromo.");
            string? frase = Console.ReadLine();

            //cremaos objeto del ejercicio 5
            Ejercicio5 ejercicio5 = new Ejercicio5();

            string mensaje5 = ejercicio5.EsPalindromo(frase);
            Console.WriteLine(mensaje5);



            Console.ReadKey();

           


        }
    }
}
