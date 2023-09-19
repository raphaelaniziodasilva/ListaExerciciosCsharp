using System.Globalization;

namespace TurmaAlunos.Entities {
    internal class Students {
        public string Name { get; set; }
        public int Age { get; set; }

        public Students(string name, int age) {
            Name = name;
            Age = age;
        }

        public override string ToString() {
            return $"{Name}, Age: {Age.ToString("F2", CultureInfo.InvariantCulture)} years";
        }
    }
}
