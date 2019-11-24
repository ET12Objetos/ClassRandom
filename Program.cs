using System;

namespace EjemploRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double numero;

            Random numeroAleatorio = new Random();

            //Limpio la pantalla
            Console.Clear();
            
            //Next
            num = numeroAleatorio.Next();
            Console.WriteLine("Numero Aleatorio Entero Cualquiera: {0}", num);

            //Next(int)
            num = numeroAleatorio.Next(100);
            Console.WriteLine("Numero Aleatorio Entero Entre 0 y 100: {0}", num);

            //Next(int, int)
            num = numeroAleatorio.Next(1000, 2000);
            Console.WriteLine("Numero Aleatorio Entero Entre 1000 y 2000: {0}", num);

            //NextDouble()
            numero = numeroAleatorio.NextDouble();
            Console.WriteLine("Numero Aleatorio Real Entre 0 y 1: {0}", numero);
        }
    }
}
