using System;
using System.Globalization;

namespace repetitionStructureWhile {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número:");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double raiz;

            while (num >= 0.0) {
                raiz = Math.Sqrt(num);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número:");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo");
            // estrutura de repetição While
        }
    }
}
