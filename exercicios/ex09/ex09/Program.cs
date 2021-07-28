using System;

namespace ex09 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Número do funcionario:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhadas:");
            int workedhours = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor das horas:");
            float hoursvalue = float.Parse(Console.ReadLine());

            float salary = workedhours * hoursvalue;
            Console.WriteLine($"Number:{number}");
            Console.WriteLine("Salary: U$ " + salary.ToString("F2"));
            // exercicio correspondente ao ex04 do exercicios1-estrutura-sequencial.pdf
        }
    }
}
