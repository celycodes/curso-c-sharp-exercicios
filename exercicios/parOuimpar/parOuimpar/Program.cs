using System;

namespace parOuimpar {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número interio:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) { 
                Console.WriteLine($"Você digitou o número {num} que é PAR!");
            }
            else { 
                Console.WriteLine($"Você digitou o número {num} que é ÍMPAR!");
                // Par ou ímpar
            }
        }
    }
}
