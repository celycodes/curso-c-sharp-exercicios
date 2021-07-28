using System;

namespace ex08 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite quatro valores inteiro:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;
            Console.WriteLine($"Resultado:{diferenca}");
        }
    }
}
