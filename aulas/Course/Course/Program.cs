using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            bool completo = false; // valor lógico false/true
            char genero = 'F'; // caracter ou código unicode  
            byte n1 = 126;    // valores interios de -128 a 127
            int n2 = 2147483647;
            long n3 = 2147483648L; // use L no final p/ indicar o tipo long
            float n4 = 4.5f;  // use f no final p/ indicar o valor do tipo float
            double n6 = 4.5;
            string nome = "Celenny Cristhyne"; // cadeia de caracteres unicode IMUTÁVEL
            object obj1 = "oi"; // objeto genérico (toda classe em c# é uma subclasse de object)
            decimal n5 = decimal.MaxValue; //maior valor use Tipo da variavel + MaxValue
            int n7 = int.MinValue; // valor mininimo use Tipo da variavel + MinValue

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(n7);
            Console.WriteLine(n5);

            // Tipos básicos de dados em C#
        }
    }
}
