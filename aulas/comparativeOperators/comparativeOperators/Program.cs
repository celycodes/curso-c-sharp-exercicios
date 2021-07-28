using System;

namespace comparativeOperators {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            bool c1 = a < 10; //  menor
            bool c2 = a > 5; // maior
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("---------------------------");
            bool c3 = a <= 10; // menor ou igual
            bool c4 = a >= 15; // maior ou igual
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("---------------------------");
            bool c5 = a == 10; // igual
            bool c6 = a != 10; // diferente
            Console.WriteLine(c5);
            Console.WriteLine(c6);

            // operadores comparativos
        }
    }
}
