namespace Calcular {
    internal class Program {
        static void Main(string[] args) {
            // 4. Fazer um programa com função para calcular a soma dos 


            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");
            Console.WriteLine("Primeiros valores pares positivos começando em 2 e não múltiplos de 7.");
            double result = SumPositivePairs(number);
            Console.WriteLine(result);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Inversos (1/x) dos primeiros valores pares positivos começando em 2 e não múltiplos de 7");
            double[] inverses = InverseValues(number);

            foreach (double inverse in inverses) {
                Console.WriteLine(inverse);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Primeiros números naturais começando em 1");
            double naturalNumbers = FirstNaturalNumbers(number);
            Console.WriteLine(naturalNumbers);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Inversos dos primeiros números naturais começando em 1");
            double[] inverseList = InverseNaturalNumbers(number);

            foreach (double inverse in inverseList) {
                Console.WriteLine(inverse);
            }


            static double SumPositivePairs(int n) {
                int currentValue = 2;
                double sum = 0;
                int count = 0;

                while (count < n) {
                    if (currentValue % 2 == 0 && currentValue % 7 != 0) {
                        sum += currentValue;
                        count++;
                    }
                    currentValue++;
                }
                return sum;
            }

            static double[] InverseValues(int n) {
                int currentValue = 2;
                int count = 0;
                double[] inverses = new double[n];

                while (count < n) {
                    if (currentValue % 2 == 0 && currentValue % 7 != 0) {
                        inverses[count] = 1.0 / currentValue;
                        count++;
                    }
                    currentValue++;
                }
                return inverses;
            }

            static double FirstNaturalNumbers(int n) {
                double sum = 0;

                for (int i = 1; i <= n; i++) {
                    sum += i;
                }
                return sum;
            }

            static double[] InverseNaturalNumbers(int n) {
                double[] inverses = new double[n];

                for (int i = 1; i <= n; i++) {
                    inverses[i - 1] = 1.0 / i;
                }
                return inverses;
            }


        }
    }
}