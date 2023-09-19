namespace CadeiaCaracteresString {
    internal class Program {
        static void Main(string[] args) {
            /* 24. Fazer um programa com um método capaz de lidar com dados com cadeia de
            caracteres (String).
            a. Ler uma cadeia de caracteres do teclado
            i. Separar e mostrar separadamente os símbolos alfanuméricos (letras e algarismos).
            b. Ler a quantidade, primeiro; e essa quantidade de cadeias de caracteres, depois, uma a uma;
            i. Separar os símbolos alfanuméricos (letras e/ou algarismos) em cada cadeia
            */

            Console.Write("Enter a string of characters: ");
            string characters = Console.ReadLine();

            Console.WriteLine($"Ler uma cadeia de caracteres do teclado: {characters}");


            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Separar e mostrar separadamente os símbolos alfanuméricos (letras e algarismos).");

            foreach (char c in characters) {
                if(char.IsLetterOrDigit(c)) {
                    Console.Write($"{c}, ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ler a quantidade, primeiro; e essa quantidade de cadeias de caracteres, depois, uma a uma;");
            
            int quantity = characters.Length;
            Console.WriteLine(quantity);
            Console.WriteLine("You entered the fallowing string of characters:");
            foreach (char c in characters) {
                Console.Write($"{c}, ");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Separar os símbolos alfanuméricos (letras e/ou algarismos) em cada cadeia");

            foreach (char c in characters) {
                if (char.IsLetterOrDigit(c)) {
                    Console.Write($"{c}, ");
                }
            }


        }
    }
}