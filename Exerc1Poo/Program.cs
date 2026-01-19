using System;
using System.Globalization; 

namespace Exerc1Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            retangulo1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(retangulo1);
            Console.WriteLine();

            Retangulo retangulo2 = new Retangulo(); 
            Console.WriteLine("Entre outra largura e altura do retângulo:");
            retangulo2.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo2.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(retangulo2);

            Retangulo retangulo3 = new Retangulo();
            retangulo3 = retangulo2;
            Console.WriteLine(retangulo3);

        }
    }
}
