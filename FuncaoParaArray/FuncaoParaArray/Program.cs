using FuncaoParaArray.Method;
using System.Runtime.Intrinsics.Arm;

namespace FuncaoParaArray {
    internal class Program {
        static void Main(string[] args) {
            /* Fazer um programa com função para
            a. Gerar um valor inteiro aleatoriamente dentro de um intervalo, cujos
            limites de início e de fim serão passados como parâmetros
            b. Procurar o maior valor em um arranjo
            c. Achar o maior e o menor dos valores um arranjo
            d. Determinar a soma dos valores em um arranjo;
            e. Determinar a média dos valores em um arranjo, usando a função anterior
            f. Receber como parâmetro um arranjo e dizer se está ordenado, ou não,
            em ordem crescente
            Obs: Não usar break!
            g. Procurar por determinado valor em arranjo e dizer se esse valor pode ser
            nele encontrado, dada a posição inicial para se iniciar a procura.
            h. Procurar por determinado valor em arranjo e dizer onde se encontra esse
            valor, dada a posição inicial para iniciar a procura.
            i. Procurar por determinado valor em arranjo e dizer quantas vezes esse
            valor pode ser encontrado, dada a posição inicial para iniciar a procura
            j. Inverter a ordem dos dados armazenados em arranjo e retornar um novo
            arranjo com a ordem invertida.
            k. Comparar se dois arranjos são iguais
            */

            Methods method = new Methods();

            Console.WriteLine("Gerar um valor inteiro aleatoriamente dentro de um intervalo, cujos limites de início e de fim serão passados como parâmetros");
            Console.Write("Enter the starting value of the integer type: ");
            int beginning = int.Parse(Console.ReadLine());

            Console.Write("Enter the end value of the integer type: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine($"The randon value of the generated integer type is: {method.GenerateRandonValue(beginning, end)}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Procurar o maior valor em um arranjo");
            int[] A = { 9, 7, 5, 8, 6, 3, 1, 2, 11, 10 };
            Console.WriteLine($"The largest value in the array is: {method.HighestValue(A)}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Achar o maior e o menor dos valores um arranjo");
            Dictionary<string, int> response = method.HighestLowestValue(A);
            foreach (var i in response) {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Determinar a soma dos valores em um arranjo");
            Console.WriteLine($"The sum of all elements in the array is {method.SumOfValues(A)}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Determinar a média dos valores em um arranjo, usando a função anterior");
            Console.WriteLine($"The average of the array values is {method.AverageValues(A)}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Receber como parâmetro um arranjo e dizer se está ordenado, ou não, em ordem crescente");
            Console.WriteLine("Original Array:");
            foreach (int i in A) {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            method.AscendingOrder(A);
            Console.WriteLine("New ordered array:");
            foreach (int i in A) {
                Console.Write($"{i} ");
            }
        }
    }
}