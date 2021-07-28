using System;
using System.Collections.Generic;

namespace ex15 {
    class Program {
        static void Main(string[] args) {

            string resp;
            do {
                Console.WriteLine("  [1] PEDRA [2] PAPEL [3] TESOURA");
                Console.WriteLine();
                Console.Write(" Player: ");
                int player = int.Parse(Console.ReadLine());
                Random rand = new Random();
                int computer = rand.Next(1, 4);
                Console.WriteLine(" Computer: " + computer);
                
                if (computer == 1) {
                    if (player == 2) {
                        Console.WriteLine(" O vencedor é o Jogador !!");
                    }
                    else if (player == 3) {
                        Console.WriteLine(" O vencedor é o Computador !!");
                    }
                    else {
                        Console.WriteLine(" Empate !!!");
                    }
                }
                else if (computer == 2) {
                    if (player == 1) {
                        Console.WriteLine(" O vencedor é o Computador !!");
                    }
                    else if (player == 3) {
                        Console.WriteLine(" O vencedor é o Player !!");
                    }
                    else {
                        Console.WriteLine(" Empate !!!");
                    }
                }
                else if (computer == 3) {
                    if (player == 1) {
                        Console.WriteLine(" O vencedor é o Player !!");
                    }
                    else if (player == 2) {
                        Console.WriteLine(" O vencedor é o Computador !!");
                    }
                    else {
                        Console.WriteLine(" Empate !!!");
                    }
                }
                Console.Write(" Quer continuar ? [S/N] ");
                resp = Console.ReadLine().ToUpper();

            } while (resp != "N"); 
        }
    }
}
