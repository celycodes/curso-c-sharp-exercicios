using System;

namespace ex04 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe a coordenada do jogador:");
            int jogador = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a coordenada do inimigo:");
            int inimigo = int.Parse(Console.ReadLine());
            int distancia = jogador - inimigo;

            if (distancia < 0) {
               distancia *= -1; 
            }

            if (distancia <= 5) {
                Console.WriteLine("Ataca");
            }
            else {
                Console.WriteLine("Não Ataca");
            }
            // instruções disponiveis no arquivo atividade-csharp-senac 
        }
    }
}
