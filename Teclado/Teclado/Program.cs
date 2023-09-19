namespace Teclado {
    internal class Program {
        static void Main(string[] args) {
            // 2. Fazer um programa para ler uma quantidade inteira do teclado e, mediante o uso de um método, mostrar essa quantidade em
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Valores múltiplos de 7 em ordem crescente");
            Multiples7AscendingOrder(numero);

            Console.WriteLine("-----------------");

            Console.WriteLine("Valores pares múltiplos de 7 em ordem crescente");
            Multiples7AscendingOrderEven(numero);

            Console.WriteLine("-----------------");

            Console.WriteLine("Valores crescentes nos denominadores (sequência dos inversos) múltiplos de 7: 1 1/7 1/14 1/21 1/28 1/35 ...");
            SequenceInverses(numero);

            Console.WriteLine("Valores crescentes nos denominadores da sequência: 1 1 / x 1 / x 2 1 / x 3...");
            SequenceDenominators(5, numero);


            static void Multiples7AscendingOrder(int n) {
                for(int i = 7; i < n; i += 7) {
                    Console.WriteLine(i);
                }
            }

            static void Multiples7AscendingOrderEven(int n) {
                for(int i = 7; i < n; i += 7) {
                    if(i % 2 == 0) {
                        Console.WriteLine(i);
                    }
                }
            }

            static void SequenceInverses(int n) {
                for(int i = 7; i < n; i += 7) {
                    Console.WriteLine($"1/{i}");
                }
            }

            static void SequenceDenominators(double x, int n) {
                for (int i = 0; i < n; i++) {
                    double value = 1.0 / Math.Pow(x, i);
                    Console.WriteLine($"1/{x}^{i} = {value}");
                }
            }


        }
    }
}