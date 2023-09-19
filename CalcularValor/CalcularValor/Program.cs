using System.Globalization;

namespace CalcularValor {
    internal class Program {
        static void Main(string[] args) {
            /* 12. Calcular e escreve o valor de H, sendo H igual a: 
            H = 1/100 + 1/97 + 1/94 + 1/91 + ... 
            A precisão de H (o número de termos a serem considerados no somatório) deverá ser um valor lido.
            */

            Console.Write("Enter precision: ");
            int precision = int.Parse(Console.ReadLine());

            double h = 0;
            double d = 100;

            for(int i = 0; i < precision; i++) {
                h += 1.0 / d;
                d -= 3.0;
                Console.Write($"1/{d} + ");
            }

            Console.WriteLine();
            Console.WriteLine($"The value of H accurately {precision} is: {h.ToString("F4", CultureInfo.InvariantCulture)}");

            /* 13. Calcular e escrever os n primeiros termos da sequência abaixo, sendo n um valor lido:
            1/100, 97/2, 3/94, 91/4, 5/88, ...
            */

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            double number = 1;
            double denominator = 100;

            for (int i = 1; i < n; i++) {
                double term = number / denominator;
                Console.Write($"{i}/{denominator}, ");

                number += 2;
                denominator -= 3;
            }
        }
    }
}