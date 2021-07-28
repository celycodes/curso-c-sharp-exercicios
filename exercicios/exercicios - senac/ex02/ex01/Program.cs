using System;

namespace ex01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite seu nome:");
            string jogador = Console.ReadLine();
            Console.WriteLine("Digite sua pontação:");
            int pontucao = int.Parse(Console.ReadLine());
            Console.WriteLine($"Parabéns {jogador}, sua pontuação foi {pontucao} pontos");

            // instruções disponiveis no arquivo atividade-csharp-senac 
        }
    }
}
