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
                Console.WriteLine("Criterio de ingreso en hospital.");
            if (IMC >= 16 && IMC < 17)
                Console.WriteLine("Infrapeso.");
            if (IMC >= 17 && IMC < 18)
                Console.WriteLine("Bajo peso.");
            if (IMC >= 18 && IMC < 25)
                Console.WriteLine("Peso normal (saludable).");
            if (IMC >= 25 && IMC < 30)
                Console.WriteLine("Sobrepeso (obesidad de grado I).");
            if (IMC >= 30 && IMC < 35)
                Console.WriteLine("Sobrepeso cronico (obesidad de grado II).");
            if (IMC >= 35 && IMC < 40)
                Console.WriteLine("Obesidad premorbida (obesidad de grado III).");
            if (IMC >= 40)
                Console.WriteLine("Obesidad morbida (obesidad de grado IV).");
                
            Console.WriteLine("Valor de IMC: " + IMC);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
