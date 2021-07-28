using System;

namespace arithmeticOperators {
    class Program {
        static void Main(string[] args) {

            int n1 = 3 + 4 * 2;     // ordem de precedência
            Console.WriteLine(n1); // temos: * / % tem precedência maior que + -

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3; // usando o mod (%) - resto da divisão
            Console.WriteLine(n3);

            // operadores atitméticos
        }
    }
}
