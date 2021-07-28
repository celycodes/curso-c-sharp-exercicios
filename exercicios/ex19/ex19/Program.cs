using System;
using System.Linq;

namespace ex19 {
    class Program {
        static void Main(string[] args) {
            string sair = null;
            do {
                int qtdJogadores = 10;
                string nomeAux;
                string[] nomeJogadores = new string[qtdJogadores];

                for (int i = 0; i < qtdJogadores; i++) {
                    Console.Write($"Digite o nome do {i + 1}º jogador: ");
                    nomeAux = Console.ReadLine();
                    if (!nomeJogadores.Contains(nomeAux)) {
                        nomeJogadores[i] = nomeAux;
                        Console.WriteLine("Nome cadastrado com sucesso ...");
                    }
                    else {
                        Console.WriteLine("Error! O nome digitado já está cadastrado...");
                    }
                }
                Console.Write("Deseja Cadastrar novamente ?[S/N]");
                sair = Console.ReadLine().ToUpper();
            } while (sair != "N");
            // atividade 3 (ex02) - Aluna: Celenny Cristhyne do Nascimento Sousa
        }
    }
}
