using System;
using System.Globalization;

namespace ex11 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite os valores de a, b e c (separando-os por espaço):");
            string[] values = Console.ReadLine().Split(" ");
            double a = double.Parse(values[0], CultureInfo.InvariantCulture);
            double b = double.Parse(values[1], CultureInfo.InvariantCulture);
            double c = double.Parse(values[2], CultureInfo.InvariantCulture);

            double triangle = (a * c) / 2; // área do triângulo de base a e altura c
            double circle = Math.PI * Math.Pow(c, 2); // área do círculo de raio c
            double trapeze = (a + b) * c / 2; // área do trapézio de lados a e b e altura c
            double square = Math.Pow(b, 2); // área do quadrado de lado b
            double rectangle = a * b; // área do retângulo de lados a e b

            Console.WriteLine("------ ÁREAS ------");
            Console.WriteLine("TRIÂNGULO: " + triangle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍCULO: " + circle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + trapeze.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + square.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + rectangle.ToString("F3", CultureInfo.InvariantCulture));
            // exercicio correspondente ao ex06 do material exercicios1-estrutura-sequencial.pdf
        }
    }
}
