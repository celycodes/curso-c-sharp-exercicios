using System;

namespace ex03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o valor do raio:");
            double raio = float.Parse(Console.ReadLine());
            double area =  Math.Pow(raio, 2) * 3.14;
            Console.WriteLine($"Área: {area:f1} m²");

            // instruções disponiveis no arquivo atividade-csharp-senac 
        }
    }
}
