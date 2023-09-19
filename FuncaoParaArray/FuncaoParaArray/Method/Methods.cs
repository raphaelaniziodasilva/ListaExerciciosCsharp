
using System.Net;

namespace FuncaoParaArray.Method {
    internal class Methods {
        /* Fazer um programa com função para
           
            
            
            h. Procurar por determinado valor em arranjo e dizer onde se encontra esse
            valor, dada a posição inicial para iniciar a procura.
            i. Procurar por determinado valor em arranjo e dizer quantas vezes esse
            valor pode ser encontrado, dada a posição inicial para iniciar a procura
            j. Inverter a ordem dos dados armazenados em arranjo e retornar um novo
            arranjo com a ordem invertida.
            k. Comparar se dois arranjos são iguais
            */

        // a. Gerar um valor inteiro aleatoriamente dentro de um intervalo, cujos limites de início
        // e de fim serão passados como parâmetros
        public int GenerateRandonValue(int beginning, int end) {
            if (beginning > end) {
                int time = beginning;
                beginning = end;
                end = time;
            }

            Random rand = new Random();
            return rand.Next(beginning, end + 1);
        }

        // b. Procurar o maior valor em um arranjo
        public int HighestValue(int[] array) {
            int highestValue = array[0];

            for(int i = 0; i < array.Length; i++) {
                if (array[i] > highestValue) {
                    highestValue = array[i];
                }
            }

            return highestValue;
        }

        // c.Achar o maior e o menor dos valores um arranjo
        public Dictionary<string, int> HighestLowestValue(int[] array) {
            int highestValue = HighestValue(array);
            int lowestValue = highestValue;

            for (int i = 0; i < array.Length; i++) {
                if (array[i] < lowestValue) {
                    lowestValue = array[i];
                }
            }

            Dictionary<string, int> response = new Dictionary<string, int> {
                { "Highest value", highestValue },
                { "Lower value", lowestValue }
            };

            return response;
        }

        // d. Determinar a soma dos valores em um arranjo;
        public int SumOfValues(int[] array) {
            int sum = 0;
            foreach(int value in array) {
                sum += value;
            }

            return sum;
        }

        // e. Determinar a média dos valores em um arranjo, usando a função anterior
        public double AverageValues(int[] array) {
            int sum = SumOfValues(array);
            double average = (double)sum / array.Length;

            return average;
        }

        // f Receber como parâmetro um arranjo e dizer se está ordenado, ou não, em ordem crescente Obs: Não usar break!
        public void AscendingOrder(int[] array) {
            Array.Sort(array);
        }

        // g. Procurar por determinado valor em arranjo e dizer se esse valor pode ser nele encontrado,
        // dada a posição inicial para se iniciar a procura.
        public bool SearchValue() {

        }
    }
}
