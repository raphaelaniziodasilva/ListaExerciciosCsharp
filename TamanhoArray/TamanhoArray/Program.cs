namespace TamanhoArray {
    internal class Program {
        static void Main(string[] args) {
            /* 4. Fazer um programa com função para ler o tamanho de um arranjo para inteiros
            do teclado, bem como todos os seus elementos.
            Para testar, ler dados e mostrá-los na tela por outro método.
            */

            int[] A = { 3, 1, 6, 4, 2, 5 };

            Console.WriteLine("Ler o tamanho de um arranjo");
            int size = ReadArraySize(A);
            Console.WriteLine(size);

            Console.WriteLine("ler dados e mostrá-los na tela por outro método.");
            ReadArray(A);




            static int ReadArraySize(int[] array) {
                int size = array.Length;
                return size;
            }

            static void ReadArray(int[] array) {
                foreach (int i in array) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}