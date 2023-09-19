namespace ElementosNegativos {
    internal class Program {
        static void Main(string[] args) {
            /* 3. Construa um método que conte o número de elementos negativos em um arranjo de reais */

            int[] elements = { 5, 2, -2, 7, 9, -1, -1, 0, -5, 5, -6, -3 };

            int negative = NegativeElements(elements);

            Console.WriteLine($"We have {negative} negative elements");

            static int NegativeElements(int[] array) {
                int countNegative = 0;

                foreach(int element in array) {
                    if(element < 0) {
                        countNegative++;
                    }
                }
                return countNegative;
            }
        }
    }
}