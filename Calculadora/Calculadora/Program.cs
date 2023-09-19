namespace Calculadora {
    internal class Program {
        static void Main(string[] args) {
            /* 9. Calculadora com as quatro operações aritméticas básicas. Oferecer um menu ao
            usuário com as operações. Ler os dois operandos. Calcular e escrever o resultado
            */

            Console.WriteLine("CALCULATOR");

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Subtraction");
            Console.WriteLine("3 Multiplication");
            Console.WriteLine("4 Division");
            Console.WriteLine("5 Exit the calculator");

            Console.WriteLine("-------------------------------");

            Console.Write("Digite o primeiro número: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double number2 = double.Parse(Console.ReadLine());

            double result = 0;

            Console.Write("Choose the number of the operation: ");
            int num = int.Parse(Console.ReadLine()); 

            switch (num) {
                case 1: 
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            Console.WriteLine($"Result of operation: {result} ");
        }
    }
}