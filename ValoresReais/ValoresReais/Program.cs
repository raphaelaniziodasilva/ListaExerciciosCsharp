using System;
using System.Globalization;
using System.Xml.Linq;

namespace ValoresReais {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of elements: ");
            int num = int.Parse(Console.ReadLine());

            double[] elements = new double[num];

            for(int i = 0; i < num; i++) {
                Console.Write("Enter the number double: ");
                double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                elements[i] = number;
            }

            foreach(double element in elements) {
                Console.WriteLine(element.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Identificar se o número é par ou não");
            foreach(double element in elements) {
                string pair = (element % 2 == 0) ? "Even" : "Odd";
                Console.WriteLine($"Number: {element.ToString("F1", CultureInfo.InvariantCulture)} is {pair}");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Separar e mostrar todos os valores em que ambos estiverem entre [-25 :55] , e o segundo maior que o primeiro.");
            for(int i = 0; i < elements.Length -1; i++) {
                double first = elements[i];
                double second = elements[i + 1];

                if(first >= -25 && first <= 55 && second >= -25 && second <= 55 && second > first) {
                    Console.WriteLine(second.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Informar a média dos valores lidos");
            double sum = 0;
            for (int i = 0; i < elements.Length; i++) {
                sum += elements[i];
            }
            double average = sum / elements.Length;
            Console.WriteLine(average.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("------------------------------");
            Console.WriteLine("Maior valor entre eles");
            double value = elements[0];
            foreach (double element in elements) {
                if (element > value) {
                    value = element;
                }
            }
            Console.WriteLine(value.ToString("F2", CultureInfo.InvariantCulture));
        }


    }
}
