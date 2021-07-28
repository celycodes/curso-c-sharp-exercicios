using System;
using System.Globalization;

namespace dataOutput {
    class Program {
        static void Main(string[] args) {
            string name = "Celenny Cristhyne";
            int age = 19;
            char gender = '\u0046'; // código unicode para F
            double balance = 10.35784;

            Console.WriteLine("Nome: " + name);
            Console.WriteLine("Gênero: " + gender);
            Console.WriteLine("Idade: " + age); // concatenação    
            Console.WriteLine("Saldo: R$" + balance.ToString("F2"));// formatar com 2 casas decimais 
            Console.WriteLine("Saldo: R$" + balance.ToString("F2", CultureInfo.InvariantCulture));
            //usando o system.globalization p/ configurar a formatação no lugar da vírgula usar ponto 
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reias", name, age, balance); // placeholders
            Console.WriteLine($"{name} tem {age} anos e tem saldo igual a {balance:F2} reias"); // interpolação
        
           // Saída de dados em c#
        }
    }
}
