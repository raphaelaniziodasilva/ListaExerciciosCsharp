using System.Globalization;
using Triangulo.Entities;

namespace Triangulo {
    internal class Program {
        static void Main(string[] args) {

            // 5.Ler os lados de um triângulo. Verificar e informar se os valores lidos consistem, de fato, em um
            // triângulo. Caso seja um triângulo válido, calcular e informar se é ele equilátero, isóscele ou escaleno.

            Console.WriteLine("Enter triangle data");

            Console.Write("Enter side A: ");
            double sideA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter side B: ");
            double sideB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter side C: ");
            double sideC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Console.WriteLine(triangle);

            triangle.CheckTriangle();
            triangle.EquilateralOrIsoscelesOrScalene();


        }
    }
}