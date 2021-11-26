using System;

namespace ConsolaIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double IMC, altura_en_m, peso_en_kg;
            Console.Write("Ingresa el valor de altura en m: ");
            altura_en_m = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de peso en kg: ");
            peso_en_kg = double.Parse(Console.ReadLine());
            IMC = peso_en_kg / altura_en_m / altura_en_m;
            if (IMC < 16)
                Console.WriteLine("Delgadez severa");
            if (IMC >= 16 && IMC < 16.99)
                Console.WriteLine("Delgadez moderada");
            if (IMC >= 17 && IMC < 18.49)
                Console.WriteLine("Delgadez aceptable");
            if (IMC >= 18.5 && IMC < 24.99)
                Console.WriteLine("Peso normal.");
            if (IMC >= 25 && IMC < 25.99)
                Console.WriteLine("Sobrepeso.");
            if (IMC >= 30 && IMC < 34.99)
                Console.WriteLine("Obesidad tipo I.");
            if (IMC >= 35 && IMC < 39.99)
                Console.WriteLine("Obesidad tipo II.");
            if (IMC >= 40 && IMC < 49.99)
                Console.WriteLine("Obesidad tipo III o morbida.");
            if (IMC > 50)
                Console.WriteLine("Obesidad tipo IV o extrema.");
                
            Console.WriteLine("Valor de IMC: " + IMC);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
