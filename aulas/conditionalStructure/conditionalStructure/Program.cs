using System;

namespace conditionalStructure {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o horário:");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12) {
                Console.WriteLine("Bom Dia!");
            }
            else if (12 >= hora && hora < 18) {
                Console.WriteLine("Boa Tarde!");
            }
            else {
                Console.WriteLine("Boa Noite!");
            }
        }
    }
}
