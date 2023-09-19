namespace ValoresLiterais {
    internal class Program {
        static void Main(string[] args) {
            /* 23. Fazer um programa capaz de lidar com dados com valores literais (char).
             Ler a quantidade, primeiro; e essa quantidade de caracteres, depois, um por vez;
             a. Separar as letras minúsculas.
             b. Separar as letras maiúsculas.
             c. Separar os algarismos
             d. Separar as letras.
             e. Separar os símbolos alfanuméricos (letras e algarismos)
            */

            Console.Write("Enter the number of characters you want: ");
            int characters = int.Parse(Console.ReadLine());

            List<object> list = new List<object>();

            for (int i = 0; i < characters; i++) {
                Console.WriteLine($"Characters {i}");
                Console.Write("Enter a charactere: ");
                char character = char.Parse(Console.ReadLine());

                list.Add(character);
            }

            int count = list.Count;
            Console.WriteLine($"Number of characters: {count}");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Separar as letras minúsculas.");

            foreach (char c in list) {
                if (char.IsLower(c)) {
                    Console.Write($"{c} - ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Separar as letras maiúsculas.");

            foreach (char c in list) {
                if (char.IsUpper(c)) {
                    Console.Write($"{c} - ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Separar os algarismos.");

            foreach (char c in list) {
                if (char.IsDigit(c)) {
                    Console.Write($"{c} - ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Separar as letras.");
            foreach (char c in list) {
                Console.Write($"{c} - ");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Separar os símbolos alfanuméricos (letras e algarismos)");
            foreach (char c in list) {
                if (char.IsLetterOrDigit(c)) {
                    Console.Write($"{c} - ");
                }
            }
        }
    }
}