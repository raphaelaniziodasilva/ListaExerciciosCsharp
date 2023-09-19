namespace Turma.Entities {
    internal class Student {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public Student(string name, int age, char gender) {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override string ToString() {
            return $"Name: {Name}, Age: {Age}, Gender: {Gender}";
        }
    }
}
