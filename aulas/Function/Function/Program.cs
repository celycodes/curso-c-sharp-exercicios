using System;

namespace Function {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Bigger(n1, n2, n3);
            Console.WriteLine("Maior:" + resultado);
        }
        static int Bigger(int a, int b, int c) {
            int r;
            if (a > b && a > c) {
                r = a;
            }
            else if (b > c) {
                r = b;
            }
            else {
                r = c;
            }
            return r;
            // Funções (sintaxe)
        }
    }
}
