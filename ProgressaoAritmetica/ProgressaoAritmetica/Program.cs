using System;

namespace ProgressaoAritmetica {
    internal class Program {
        static void Main(string[] args) {
            // 10. Escrever na tela os n primeiros termos de uma Progressão Aritmética.
            // Planeje os valores que deverão ser lidos

            Console.Write("Enter the first term: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Enter the reason: ");
            double reason = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of terms: ");
            int numbers = int.Parse(Console.ReadLine());

            Console.WriteLine($"The first {numbers} terms in PA are");

            for (int i = 0; i < numbers; i++) {
                double currentTerm = first + i * reason;
                Console.WriteLine($"Term {i + 1}: {currentTerm}");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");

            /* 11. Sobre uma Progressão Aritmética (P.A.), deseja-se saber o número de termos divisíveis por x,
             * sendo x um valor lido. O número de termos, o primeiro termo e a razão também deverão ser lidos.
            */


            Console.Write("Enter the first term: ");
            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the difference r: ");
            int r = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of x: ");
            int x = int.Parse(Console.ReadLine());

            int numTerms = NumTermsDivisibleByX(a1, r, x);

            Console.WriteLine($"The number of terms divisible by {x} is {numTerms}.");

            static int NumTermsDivisibleByX(int a1, int r, int x) {
                if (r == 0) {
                    return 0;
                }

                double n = ((double)(x - a1) / r) + 1;
                return (int)n == n ? (int)n : 0;
            }
        }
    }
}
