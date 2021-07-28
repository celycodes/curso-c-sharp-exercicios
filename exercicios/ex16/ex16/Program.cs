using System;

namespace ex16 {
    class Program {
        static void Main(string[] args) {
            
            int i;
            Console.Write("Digite a quantidade de Jogadores: ");
            int quant = int.Parse(Console.ReadLine());
            int maior = 0;
            string jogadorvencedor = null;
            int pontvencedora = 0;


            for (i = 0; i < quant; i++) {
                
                Console.WriteLine($"Digite o nome do {i + 1}º Jogador:");
                string nome = Console.ReadLine();
                Console.WriteLine($"Digite a pontuação do {i + 1}º Jogador:");
                int pont = int.Parse(Console.ReadLine());

                if (i == 0) {
                    maior = pont;
                    pontvencedora = pont;
                    jogadorvencedor = nome;

                }
                else {
                    if (pont > maior) {
                        maior = pont;
                        jogadorvencedor = nome;
                        pontvencedora = pont;
                    }
                }
            }
            Console.WriteLine("O jogador vencedor é " + jogadorvencedor + " com a pontuação " + pontvencedora);
        }
    }
}
