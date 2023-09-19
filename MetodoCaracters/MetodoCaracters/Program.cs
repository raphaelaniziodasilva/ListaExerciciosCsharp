using MetodoCaracters.Methods;

namespace MetodoCaracters {
    internal class Program {
        static void Main(string[] args) {
            /* 26. Fazer um programa com método usando
            a. Função inteira para contar as minúsculas de uma cadeia de caracteres.
            b. Função para separar e devolver as minúsculas de uma cadeia de caracteres.
            c. Funções inteiras para contar as maiúsculas e minúsculas de uma cadeia de caracteres
            d. Funções para separar as maiúsculas e minúsculas de uma cadeia de caracteres
            e. Função inteira para contar apenas os dígitos pares de uma cadeia de caracteres
            f. Função para separar os dígitos pares de uma cadeia de caracteres.
            g. Funções para contar e separar os dígitos e as letras de uma cadeia de caracteres.
            */

            Console.Write("Enter a string of characters: ");
            string descriotion = Console.ReadLine();

            Method characters = new Method(descriotion);

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Função inteira para contar as letras minúsculas de uma cadeia de caracteres");

            int countLowercase = characters.CountLowercaseLetters();
            Console.WriteLine($"The description has {countLowercase} lowercase letters");

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Função para separar e devolver as minúsculas de uma cadeia de caracteres.");

            string lowercase = characters.LowercaseLetters();
            Console.Write(lowercase);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Funções inteiras para contar as maiúsculas e minúsculas de uma cadeia de caracteres.");
            
            int[] countLowercaseCountUppercase = characters.CountUpperLowerCaseLetters();
            Console.WriteLine($"Contains lowercase letters {countLowercaseCountUppercase[0]}");
            Console.WriteLine($"Contains uppercase letters {countLowercaseCountUppercase[1]}");

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Funções para separar as maiúsculas e minúsculas de uma cadeia de caracteres");

            string[] lowercaseUppercase = characters.SeparateUpperLowerCaseLetters();
            Console.WriteLine($"Lowercase letters {lowercaseUppercase[0]}");
            Console.WriteLine($"Uppercase letters {lowercaseUppercase[1]}");

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Função inteira para contar apenas os dígitos pares de uma cadeia de caracteres");

            int digits = characters.CountDigits();
            Console.WriteLine($"Has {digits} digits");

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Função para separar os dígitos pares de uma cadeia de caracteres.");

            List<int> evenDigits = characters.EvenDigits();
            foreach (int i in evenDigits) {
                Console.WriteLine($"Even digits: {i}");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Funções para contar e separar os dígitos e as letras de uma cadeia de caracteres.");

            Dictionary<string, object> separate = characters.SeparateDigitsLetter();
            foreach(var i in separate) {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        }
    }
}