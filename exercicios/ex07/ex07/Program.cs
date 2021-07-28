using System;
using System.Globalization;

namespace ex07 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("Área: " + area.ToString("f4", CultureInfo.InvariantCulture) + " m²");
        }
    }
}
