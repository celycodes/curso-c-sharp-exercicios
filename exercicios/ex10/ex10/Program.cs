using System;
using System.Globalization;

namespace ex10 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("1 - Código da peça | 2 - Número de peças | 3 - Valor unitário da peça");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Digite os dados do 1° produto (separando-os com espaço):");
            string[] value1 = Console.ReadLine().Split(' ');
            int code1 = int.Parse(value1[0]);
            int num1 = int.Parse(value1[1]);
            float preco1 = float.Parse(value1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do 2° produto (separando-os com espaço):");
            string[] value2 = Console.ReadLine().Split(' ');
            int code2 = int.Parse(value2[0]);
            int num2 = int.Parse(value2[1]);
            float preco2 = float.Parse(value2[2], CultureInfo.InvariantCulture);

            float valorAPagar = (num1 * preco1) + (num2 * preco2);
            Console.WriteLine("VALOR A PAGAR: R$ " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));
            // exercicio correspondente ao ex05 do matarial exercicios1-estrutura-sequencial.pdf
        }
    }
}
