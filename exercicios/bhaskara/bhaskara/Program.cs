using System;

namespace bhaskara {
    class Program {
        static void Main(string[] args) {
            // bhaskara
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"Delta= {delta}");
            Console.WriteLine($"x1 = {x1}");
        }
    }
}
