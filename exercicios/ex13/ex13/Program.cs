using System;

namespace ex13 {
    class Program {
        static void Main(string[] args) {
            int pontoX, pontoY, superiorX, superiorY, inferiorX, inferiorY;
            Console.WriteLine("Informe o ponto Superior Esquerdo:");
            superiorX = int.Parse(Console.ReadLine());
            superiorY = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ponto Inferior Direito:");
            inferiorX = int.Parse(Console.ReadLine());
            inferiorY = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ponto a ser testado:");
            pontoX = int.Parse(Console.ReadLine());
            pontoY = int.Parse(Console.ReadLine());

            if (pontoX >= superiorX && pontoX <= inferiorX) {
                if (pontoY <= superiorY && pontoY >= inferiorY) {
                    Console.WriteLine("O ponto está DENTRO do retângulo!");
                }
                else {
                    Console.WriteLine("O ponto está FORA do retângulo!");
                }
            }
            else {
                Console.WriteLine("O ponto está FORA do retângulo!");
            }
        }
    }
}
