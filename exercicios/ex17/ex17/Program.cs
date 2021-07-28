using System;

namespace ex17 {
    class Program {
        static void Main(string[] args) {

            string classe = null;
            int sair = 0;

            do {
                Console.WriteLine("================================");
                Console.WriteLine(" MAGO     ARQUEIRO    GUERREIRO ");
                Console.WriteLine("================================");

                Console.Write("Digite a classe de seu personagem: ");
                classe = Console.ReadLine().ToUpper();
                Console.WriteLine();

                switch(classe) {
                    case "MAGO":
                        Console.WriteLine("A Classe escolhida foi MAGO");
                        sair = 1;
                        break;
                    case "ARQUEIRO":
                        Console.WriteLine("A Classe escolhida foi ARQUEIRO");
                        sair = 1;
                        break;
                    case "GUERREIRO":
                        Console.WriteLine("A Classe escolhida foi GUERREIRO");
                        sair = 1;
                        break;
                    default:
                        Console.WriteLine("<< ERROR! Digite a classe do personagem corretamente >>");
                        Console.WriteLine();
                        break;
                }
            } while(sair != 1);
        }
    }
}
