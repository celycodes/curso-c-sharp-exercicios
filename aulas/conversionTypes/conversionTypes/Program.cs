using System;

namespace conversionTypes {
    class Program {
        static void Main(string[] args) {
             float x = 4.5f; // conversão implícita 
            double y = x;   
            Console.WriteLine(y);
            // Ao declarar esse tipo de conversão, o compilador identifica que ambos são de 
            // tipos compatíveis, sendo assim nenhuma intervenção na hora do build é feita e 
            // há a garantia que nenhuma informação seja perdida durante a conversão.
            Console.WriteLine("-----------------------------");
            double a = 5.1;
            float b = (float) a; // conversão explícita ou casting
            // Não é possivel converter implicitamente de double (8 bytes) para float (4 bytes)
        }
    }
}
