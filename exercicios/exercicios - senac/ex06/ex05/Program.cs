using System;
using System.Globalization;

namespace ex05 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a sua quantidade de dinheiro:");
            double dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o preço do item:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double itens =  dinheiro / preco;

            if (dinheiro > preco) {
                Console.WriteLine($"É possível comprar o item e {(int)itens} unidades podem ser adqueridas");
            }
            else {
                Console.WriteLine("Não é possível comprar o item");
            }
            // instruções disponiveis no arquivo atividade-csharp-senac 
        }
    }
}
