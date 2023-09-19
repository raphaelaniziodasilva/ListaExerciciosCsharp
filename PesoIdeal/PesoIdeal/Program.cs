using PesoIdeal.Entities;
using System.Globalization;
using System.Reflection;
using System.Xml.Linq;

namespace PesoIdeal {
    internal class Program {
        static void Main(string[] args) {
            /* Construa uma versão que reúna em um só programa o cálculo do peso ideal de
            pessoas do gênero masculino e feminino. O gênero (‘m’ masculino ou ‘f’
            feminino) deverá ser um valor lido.
            • Peso ideal de uma pessoa do gênero masculino: (72,7 x altura) – 58
            • Peso ideal de uma pessoa do gênero feminino: (62,1 x altura) – 44,7 
            */

            Console.WriteLine("Enter the person's datails");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Gender (M/F): ");
            char gender = char.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Weight: ");
            double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Person person = new Person(name ,age, gender, height, weight);

            Console.WriteLine(person);

            if (person.Gender == 'M' || person.Gender == 'm') {
                double idealWeight = person.CalculateIdealWeightForMen();
                Console.WriteLine($"Men's ideal weight is {idealWeight.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            else if (person.Gender == 'F' || person.Gender == 'f') {
                double idealWeight = person.CalculateIdealWeightForWomen();
                Console.WriteLine($"Women's ideal weight is {idealWeight.ToString("F2", CultureInfo.InvariantCulture)}");

            }

        }
    }
}