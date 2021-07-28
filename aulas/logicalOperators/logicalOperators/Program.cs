using System;

namespace logicalOperators {
    class Program {
        static void Main(string[] args) {
            bool c1 = 2 > 3 && 4 != 5; // E
            Console.WriteLine(c1);
            
            bool c2 = 2 > 3 || 4 != 5; // OU
            Console.WriteLine(c2); 

            bool c3 = !(2 > 3) && 4 != 5; // Não (!) 
            Console.WriteLine(c3); 

            Console.WriteLine("------------------");
            // ordem de precendência: ! > && > ||  
            bool c5 = c1 || c2 && c3;
            Console.WriteLine(c5);

            // operadores lógicos
        }
    }
}
