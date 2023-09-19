using System.Globalization;
using TurmaAlunos.Entities;

namespace TurmaAlunos {
    internal class Program {
        static void Main(string[] args) {
            // 8. Calcular e escrever a idade média de uma turma de n alunos, sendo n um valor lido. 
            Console.Write("How many students will be added to the class?  ");
            int num = int.Parse(Console.ReadLine());
            
            List<Students> classs = new List<Students>();


            for(int i = 0; i < num; i++) {
                Console.WriteLine("Enter student data");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);

                Students student = new Students(name, age);
                classs.Add(student);
            }

            Console.WriteLine("--------------------------------");

            foreach(Students student in classs) {
                Console.WriteLine(student);
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Average age of the class");
            double sum = 0;
            foreach (Students student in classs) {
                sum += student.Age;
            }

            double average = sum / classs.Count;
            Console.WriteLine($"Average Age is {average.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}