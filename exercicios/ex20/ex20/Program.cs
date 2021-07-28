using System;
using System.Collections.Generic;

namespace ex20 {
    class Program {
        static void Main(string[] args) {
            int sair = 0;
            int posicao = 0;
            string opcao = null;
            string novaArma = null;

            List<string> listaArmas = new List<string>();
            listaArmas.Add("Faca");
            listaArmas.Add("Pistola Laser");

            do {
                Console.WriteLine("=====================================");
                Console.WriteLine("A - Adicionar nova arma a lista");
                Console.WriteLine("S - SAIR DO PROGRAMA");
                Console.WriteLine("=====================================");

                Console.Write("Informe sua opção: ");
                opcao = Console.ReadLine().ToUpper();
                
                switch(opcao) {
                    case "A":
                        Console.Write("Digite o nome da nova arma: ");
                        novaArma = Console.ReadLine();
                        listaArmas.Add(novaArma);
                        for (int i = 0; i < listaArmas.Count; i++) {
                            Console.WriteLine($"[{i}] {listaArmas[i]}");
                        }
                        break;
                    case "S":
                        Console.WriteLine("Encerrando o programa ...");
                        sair = 1;
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Informe um numero para Mostrar a arma: ");
                posicao = int.Parse(Console.ReadLine());
                Console.WriteLine("Usando " + listaArmas[posicao]);

            } while (sair != 1);
            // atividade 3 (ex03) - Aluna: Celenny Cristhyne do Nascimento Sousa
        }
    }
}
