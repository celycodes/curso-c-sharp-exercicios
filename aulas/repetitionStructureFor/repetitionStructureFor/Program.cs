using System;

namespace repetitionStructureFor {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos números inteiros você vai querer digitar ?");
            int num = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= num; i ++) {
                Console.Write($"{i}° Valor: ");
                int value = int.Parse(Console.ReadLine());
                soma += value;
            }
            Console.WriteLine("Soma = " + soma);
            // estrutura de repetição For (para)
        }
    }
}
