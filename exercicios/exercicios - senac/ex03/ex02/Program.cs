using System;

namespace ex02 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a duração da música:");
            int minutos = int.Parse(Console.ReadLine());
            int wav = minutos * 10;
            float mp3 = minutos * 1.5f;
            float wavminutos = wav / 1.5f;
            Console.WriteLine($"WAV {wav}MB, MP3 {mp3}MB, {wav}MB equivale a {wavminutos:f1} minutos no formato MP3");
            // instruções disponiveis no arquivo atividade-csharp-senac 
        }
    }
}
