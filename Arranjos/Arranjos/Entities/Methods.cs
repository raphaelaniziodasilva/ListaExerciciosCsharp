namespace Arranjos.Entities {
    internal class Methods {

        public void ReadArray(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.Write($"Enter value of the element {i + 1}: ");
                int value = int.Parse(Console.ReadLine());

               array[i] = value;
            }
        }

        public void DisplaceMaiorFinal(int[] array) {
                int maxIndex = 0;

            for (int i = 1; i < array.Length; i++) {
                if (array[i] > array[maxIndex]) {
                    maxIndex = i;
                }
            }

            int final = array[maxIndex];
            array[maxIndex] = array[array.Length - 1];
            array[array.Length - 1] = final;
        }

        public void AscendingOrder(int[] array) {
            Array.Sort(array);
        }
    }
}

