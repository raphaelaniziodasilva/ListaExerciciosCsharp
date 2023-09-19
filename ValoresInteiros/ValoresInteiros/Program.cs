namespace ValoresInteiros {
    internal class Program {
        static void Main(string[] args) {
            // 1. Fazer um programa capaz de lidar com valores inteiros (int).
            // Ler a quantidade, primeiro; e depois, outros valores, um por vez

            Console.Write("Enter how many elements of the integer type you want: ");
            int quantities = int.Parse(Console.ReadLine());

            int[] integers = new int[quantities];

            for(int i = 0; i < quantities; i++) {
                Console.Write("Enter the number integer: ");
                int number = int.Parse(Console.ReadLine());
                integers[i] = number;
            }

            foreach(int i in integers) {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Identificar se um inteiro lido é par ou não");
            foreach(int i in integers) {
                string pair = (i % 2 == 0) ? "Even" : "Odd";
                Console.WriteLine($"Number: {i} is {pair}");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Mostrar apenas os valores entre -25 e 55, excluindo esses");
            foreach(int i in integers) {
                if (i > -25 && i < 55) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Mostrar apenas os valores que não estão entre -25 e 55, excluindo esses");
            foreach(int i in integers) {
                if (i < -25 || i > 55) {
                    Console.WriteLine(i);
                }
            }
   
            Console.WriteLine("------------------------------");
            Console.WriteLine("Mostrar os valores apenas se o primeiro for maior que zero e menor que o segundo");

            Console.Write("First value: ");
            int firstValue = int.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            int secondValue = int.Parse(Console.ReadLine());

            foreach(int i in integers) {
                if(i > firstValue && i < secondValue) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Mostrar apenas os valores em que ambos estiverem entre [-25 :55] e forem pares");
            foreach(int i in integers) {
                if(i >= -25 && i <= 55 && i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Mostrar apenas os valores em que ambos estiverem entre [-25 :55] e forem ímpares");
            foreach(int i in integers) {
                if (i >= -25 && i <= 55 && i % 2 == 1) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Separar e mostrar todos os valores em que ambos não estiverem entre [-25 : 55] , não forem ímpares e também não forem negativos.");
            foreach (int i in integers) {
                if((i < -25 || i > 55) && i % 2 == 0 && i > 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Informar a média dos valores lidos,");
            double sum = 0;
            for(int i = 0; i < integers.Length; i++) {
                sum += integers[i];
            }
            double average = sum / integers.Length;
            Console.WriteLine(average);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Maior valor entre eles");
            int value = integers[0];
            foreach(int i in integers) {
                if(i > value) {
                    value = i;
                }
            }
            Console.WriteLine(value);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Separar os pares menores que 100");
            foreach(int i in integers) {
                if (i % 2 == 0 && i < 100) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Separar os pares e positivos entre 15 e 225");
            foreach (int i in integers) {
                if (i % 2 == 0 && i >= 15 && i <= 225 && i > 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Separar os positivos, menores que 100, mas mostrar somente a parte inteira.");
            foreach (int i in integers) {
                if (i > 0 && i <= 100 && i % 1 == 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Separar os positivos, menores que 100, mas mostrar a parte fracionária, primeiro, separada da parte inteira");
            foreach (int i in integers) {
                if (i > 0 && i < 100) {
                    int fractional = i % 1;
                    int IntPart = i / 1;
                    Console.WriteLine($"Number: {i}, Fractional: {fractional}, Int: {IntPart}");
                }
            }
        }
    }
}