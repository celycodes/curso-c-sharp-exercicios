using System;

namespace ex14 {
    class Program {
        static void Main(string[] args) {
            int qtdJogadores, pontuacaoJogador, totalVencedores = 0, i;

            Console.WriteLine("Informe a quantidade de Jogadores:");
            qtdJogadores = int.Parse(Console.ReadLine());
            for (i = 0; i < qtdJogadores; i++) {
                Console.WriteLine($"Quantos pontos fez o jogador {i+1}?");
                pontuacaoJogador = int.Parse(Console.ReadLine());
                if (pontuacaoJogador >= 100) {
                    totalVencedores += 1;
                }
            }
            Console.WriteLine("O Total de Vencedores é " + totalVencedores);
        }
    }
}
