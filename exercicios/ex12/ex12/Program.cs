using System;

namespace ex12 {
    class Program {
        static void Main(string[] args) {

            string resp = "S";
            do {
                int computer;
                Console.WriteLine("  [1] PEDRA [2] PAPEL [3] TESOURA");
                Console.WriteLine();
                Console.Write(" Player: ");
                int player = int.Parse(Console.ReadLine());
                Random rand = new Random();
                Console.Write(" Computer: ");
                computer = rand.Next(1, 4);
                Console.Write(computer);
                Console.WriteLine();
                
                if (computer == 1) {
                    if (player == 2) {
                        Console.WriteLine(" O vencedor é o Player !!");
                    }
                    else if (player == 3) {
                        Console.WriteLine(" O vencedor é o Computer !!");
                    }
                    else {
                        Console.WriteLine(" Empate !!!");
                    }
                }
                else if (computer == 2) {
                    if (player == 1) {
                        Console.WriteLine(" O vencedor é o Computer !!");
                    }
                    else if (player == 3) {
                        Console.WriteLine(" O vencedor é o Player !!");
                    }
                    else {
                        Console.WriteLine(" Empate !!!");
                    }
                }
                else {
                    if (player == 1) {
                        Console.WriteLine(" O vencedor é o Player !!");
                    }
                    else if (player == 2) {
                        Console.WriteLine(" O vencedor é o Computer !!");
                    }
                    else {
                        Console.WriteLine(" Empate !!!");
                    }
                }
                Console.Write(" Quer continuar ? [S/N] ");
                resp = Console.ReadLine().ToUpper();
            }
            while (resp != "N");
            // ex 01 atividade 2
        }
    }
}
