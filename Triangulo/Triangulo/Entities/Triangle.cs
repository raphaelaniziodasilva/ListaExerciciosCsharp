namespace Triangulo.Entities {
    internal class Triangle {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c) {
            A = a;
            B = b;
            C = c;
        }

        public void CheckTriangle() {
            double side1 = A + B;
            double side2 = A + C;
            double side3 = B + C;

            if (side1 > C && side2 > B && side3 > A) {
                Console.WriteLine("The values reported form a triangle.");
            }
            else {
                Console.WriteLine("The values reported do not form a triangle.");
            }
        }

        public void EquilateralOrIsoscelesOrScalene() {
            if(A == B && B == C) {
                Console.WriteLine("Triangle is equilateral");
            } else if(A == B || A == C || B == C) {
                Console.WriteLine("Triangle is isosceles");
            } else {
                Console.WriteLine("Triangle is scalene");
            }
        }

        public override string ToString() {
            return $"Side A: {A}, Side B: {B} and Side C: {C}";
        }
    }
}
