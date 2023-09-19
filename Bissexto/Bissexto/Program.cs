namespace Bissexto {
    internal class Program {
        static void Main(string[] args) {
            /* 7. Identificar se um ano lido é bissexto ou não. Pesquise o que deve ser observado
            para verificar se um ano é bissexto. 
            */

            Console.Write("Enter the year (ex: 2023): ");
            int year = int.Parse(Console.ReadLine());

            if(year % 4 == 0) {
                Console.WriteLine($"{year} is leap year ");
            } else {
                Console.WriteLine($"{year} is not leap year ");
            }






        }
    }
}