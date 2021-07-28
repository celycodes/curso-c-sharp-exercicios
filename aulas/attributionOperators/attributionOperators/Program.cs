using System;

namespace attributionOperators {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            Console.WriteLine($" a = {a}");

            a += 2; // a = a + 2
            Console.WriteLine($" a = {a}");

            a *= 3; // a = a * 3
            Console.WriteLine($" a = {a}");

            a /= 3; // a = a/3
            Console.WriteLine($" a = {a}");

            a -= 2; // a = a - 2
            Console.WriteLine($" a = {a}");

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s); // += tambem funciona p/ variavel do tipo string

            int b = 10;
            b++; // b = b + 1
            Console.WriteLine($" b = {b}");

            b--;
            Console.WriteLine($" b = {b}");

            // Operadores de atribuição
        }
    }
}
