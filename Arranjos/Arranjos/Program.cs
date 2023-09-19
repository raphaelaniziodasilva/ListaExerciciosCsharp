using Arranjos.Entities;

namespace Arranjos {
    internal class Program {
        static void Main(string[] args) {
            int[] A = { 6, 5, 4, 3, 2, 1 };
            int[] B = { 3, 1, 6, 4, 2, 5 };
            int[] C = new int[6];

            Methods methods = new Methods();

            methods.ReadArray(C);
            foreach (int i in C) {
                Console.WriteLine(i);
            }

            Console.WriteLine(methods);

            methods.DisplaceMaiorFinal(A);
            methods.DisplaceMaiorFinal(B);
            methods.DisplaceMaiorFinal(C);

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Array A:");
            foreach (int i in A) {
                Console.Write($"{i} - ");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Array B:");
            foreach (int i in B) {
                Console.Write($"{i} - ");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Array C:");
            foreach (int i in C) {
                Console.Write($"{i} - ");
            }



            methods.AscendingOrder(A);
            methods.AscendingOrder(B);
            methods.AscendingOrder(C);

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Ascending order A:");
            foreach (int i in A) {
                Console.Write($"{i} - ");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Ascending order B:");
            foreach (int i in B) {
                Console.Write($"{i} - ");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Ascending order C:");
            foreach (int i in C) {
                Console.Write($"{i} - ");
            }




        }
    }
}