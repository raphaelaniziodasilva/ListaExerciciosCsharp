using System.Globalization;
using System.Reflection;
using System.Xml.Linq;
using Turma.Entities;

namespace Turma {
    internal class Program {
        static void Main(string[] args) {
            /*  15. Construa um programa que permita identificar o perfil da turma:
            Domínio dos dados:
            */

            Console.Write("How many students will there be in the class? ");
            int num = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for(int i = 0; i < num; i++) {
                Console.WriteLine();
                Console.WriteLine("Enter student date");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Gender: ");
                char gender = char.Parse(Console.ReadLine());

                Student student = new Student(name, age, gender);

                students.Add(student);
            }

            Console.WriteLine("Students:");
            foreach (Student student in students) {
                Console.WriteLine(student);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Percentual de homens e de mulheres.");

            int men = students.Count(student => student.Gender == 'm');
            int woman = students.Count(student => student.Gender == 'f');
            int totalStudents = students.Count();

            double percentageMen = (double)men / totalStudents * 100;
            double percentageWoman = (double)woman / totalStudents * 100;

            Console.WriteLine($"Percentage of men: {percentageMen.ToString("F2", CultureInfo.InvariantCulture)}%");
            Console.WriteLine($"Percentage of women: {percentageWoman.ToString("F2", CultureInfo.InvariantCulture)}%");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Percentual de alunos maiores em idade.");
          
            int studentsOfLegalAge = students.Count(student => student.Age > 18);
            double percentageStudentsOfLegalAge = (double)studentsOfLegalAge / totalStudents * 100;

            Console.WriteLine($"Percentage of students of legal age: {percentageStudentsOfLegalAge.ToString("F2", CultureInfo.InvariantCulture)}%");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Idade da pessoa mais velha.");

            int olderStudent = 0;
            foreach (Student student in students) {
                if(student.Age > olderStudent) {
                    olderStudent = student.Age;
                }
            }
            Console.WriteLine(olderStudent);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Idade da pessoa mais nova.");

            int youngerStudent = olderStudent;
            foreach (Student student in students) {
                if (student.Age < youngerStudent) {
                    youngerStudent = student.Age;
                }
            }
            Console.WriteLine(youngerStudent);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Idade da pessoa mais nova.");

        }
    }
}