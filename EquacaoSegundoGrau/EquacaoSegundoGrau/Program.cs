namespace EquacaoSegundoGrau {
    internal class Program {
        static void Main(string[] args) {
            // 17. Calcular uma equação do segundo grau. Planeje os operandos e o algoritmo requerido para o cálculo.

            Console.Write("Enter the value of A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter the value of C: ");
            double c = double.Parse(Console.ReadLine());

            double descriminant = b * b - 4 * a * c;

            double x1 = (-b + Math.Sqrt(descriminant)) / (2 * a);
            double x2 = (-b + Math.Sqrt(descriminant)) / (2 * a);

            Console.WriteLine("Different square roots of x1 and x2:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);

        }
    }
}