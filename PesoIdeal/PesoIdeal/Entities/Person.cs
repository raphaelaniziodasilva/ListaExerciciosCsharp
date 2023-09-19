using System;
using System.Globalization;

namespace PesoIdeal.Entities {
    internal class Person {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Person(string name, int age, char gender, double height, double weight) {
            Name = name;
            Age = age;
            Gender = gender;
            Height = height;
            Weight = weight;
            
        }

        public override string ToString() {
            return $"Name: {Name}, Age: {Age}, Gender: {Gender}, Height: {Height.ToString("F2", CultureInfo.InvariantCulture)}" +
                $" Weight:  {Weight.ToString("F", CultureInfo.InvariantCulture)}";
        }

        public double CalculateIdealWeightForMen() {
            return (Weight * Height) - 58;
        }

        public double CalculateIdealWeightForWomen() {
            return (Weight * Height) - 44.7;
        }
    }
}
