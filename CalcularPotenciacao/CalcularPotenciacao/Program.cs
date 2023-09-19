namespace CalcularPotenciacao {
    internal class Program {
        static void Main(string[] args) {
            /* 16. Calcular e escrever a potenciação. A base e o expoente deverão ser valores lidos
            Considere: base um valor real.
            Expoente: um número inteiro, positivo ou nulo(zero).
            Obs: Não usar a classe Math. 
            */

            Console.Write("Enter the base: ");
            double baseNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            double result = 1;

            for(int i = 0; i < exponent; i++) {
                result *= baseNumber;
            }

            Console.WriteLine($"The result of potentiation {result}");




        }
    }
}