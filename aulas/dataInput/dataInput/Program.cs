using System;
using System.Globalization;

namespace dataInput {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite seus dados (separando-os com espaço):");
            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("nome:" + nome);
            Console.WriteLine("sexo:" + sexo);
            Console.WriteLine("idade:" + idade);
            Console.WriteLine("altura:" + altura.ToString("F2", CultureInfo.InvariantCulture);
            // entrada de dados
        }
    }
}
