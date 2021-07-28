using System;

namespace ex18 {
    class Program {
        static void Main(string[] args) {
            int qtdJogadores, totalVencedores = 0;

            Console.WriteLine("Informe a quantidade de Jogadores:");
            qtdJogadores = int.Parse(Console.ReadLine());
            string[] nomeJogadores = new string[qtdJogadores];
            int[] pontuacaoJogadores = new int[qtdJogadores];

            for (int i = 0; i < nomeJogadores.Length; i++) {
                Console.WriteLine("Informe o nome do " + (i + 1) + "ª jogador:");
                nomeJogadores[i] = Console.ReadLine();
                Console.WriteLine($"Digite a pontuação do " + (i + 1) + "ª jogador:");
                pontuacaoJogadores[i] = int.Parse(Console.ReadLine());
                if (pontuacaoJogadores[i] >= 100) {
                    totalVencedores += 1;
                }
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"No Total temos {totalVencedores} Jogadores vencedores.");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("Jogadores Vencedores: ");
            for (int i = 0; i < qtdJogadores; i++) {
                if (pontuacaoJogadores[i] >= 100) {
                    Console.WriteLine(nomeJogadores[i]);
                }
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            // atividade 3 (ex01) - Aluna: Celenny Cristhyne do Nascimento Sousa
        }
    }
}
