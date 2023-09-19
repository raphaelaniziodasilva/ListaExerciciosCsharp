namespace ProcedimentoCaracteres {
    internal class Program {
        static void Main(string[] args) {
            /* 25. Fazer um programa com procedimento para
            a. Mostrar apenas as minúsculas de uma cadeia de caracteres.
            b. Contar as minúsculas de uma cadeia de caracteres, e mostrar o resultado.
            c. Mostrar apenas os dígitos de uma cadeia de caracteres
            */

            Console.Write("Enter a string of characters: ");
            string characters = Console.ReadLine();

            Console.WriteLine(characters);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Mostrar apenas as letras minúsculas de uma cadeia de caracteres.");
            foreach(char c in characters) {
                if(char.IsLower(c)) {
                    Console.Write($"{c} - ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Contar as minúsculas de uma cadeia de caracteres, e mostrar o resultado.");

            int countLowercase = 0;
            foreach (char c in characters) {
                if (char.IsLower(c)) {
                    countLowercase ++;
                }
            }
            Console.WriteLine($"In the characters string has {countLowercase} lowercase letters");

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Mostrar apenas os dígitos de uma cadeia de caracteres.");
            foreach (char c in characters) {
                if (char.IsDigit(c)) {
                    Console.Write($"{c} - ");
                }
            }
        }
    }
}