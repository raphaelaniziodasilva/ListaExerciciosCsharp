using System.Text;

namespace MetodoCaracters.Methods {
    internal class Method {
        public string Characters { get; set; }

        public Method(string characters) {
            Characters = characters;
        }

        // a. Função inteira para contar as minúsculas de uma cadeia de caracteres.
        public int CountLowercaseLetters() {
            int count = 0;

            foreach(char c in Characters) {
                if (char.IsLower(c)) {
                    count++;
                }
            }
            return count;
        }

        // b. metodo para separar e devolver as letras minúsculas de uma cadeia de caracteres.
        public string LowercaseLetters() {
            StringBuilder lowercase = new StringBuilder();

            foreach(char c in Characters) {
                if(char.IsLower(c)) {
                    lowercase.Append(c);
                }
            }
            return lowercase.ToString();
        }

        // c. metodo inteiras para contar as maiúsculas e minúsculas de uma cadeia de caracteres
        public int[] CountUpperLowerCaseLetters() {
            int countLowercase = CountLowercaseLetters();
            int countUppercase = 0;

            foreach(char c in Characters) {
                if (char.IsUpper(c)) {
                    countUppercase++;
                }
            }
            int[] counts = { countLowercase, countUppercase };
            return counts;
        }

        // d. metodo para separar as maiúsculas e minúsculas de uma cadeia de caracteres
        public string[] SeparateUpperLowerCaseLetters() {
            string lowercase = LowercaseLetters();
            StringBuilder uppercase = new StringBuilder();

            foreach(char c in Characters) {
                if (char.IsUpper(c)) {
                    uppercase.Append(c);
                }
            }
            string[] letters = { lowercase, uppercase.ToString() };
            return letters;
        }

        // e. metodo inteira para contar apenas os dígitos pares de uma cadeia de caracteres
        public int CountDigits() {
            int count = 0;

            foreach(char c in Characters) {
                if (char.IsDigit(c) && (c - '0') % 2 == 0) {
                    count++;
                }
            }
            return count;
        }

        // f. metodo para separar os dígitos pares de uma cadeia de caracteres.
        public List<int> EvenDigits() {
            List<int> even = new List<int>();

            foreach (char c in Characters) {
                if (char.IsDigit(c) && (c - '0') % 2 == 0) {
                    even.Add(c - '0');
                }
            }
            return even;
        }

        // g. metodo para contar e separar os dígitos e as letras de uma cadeia de caracteres.
        public Dictionary<string, object> SeparateDigitsLetter() {
            int digits = 0;
            int letters = 0;

            StringBuilder digit = new StringBuilder();
            StringBuilder letter = new StringBuilder();

            foreach (char c in Characters) {
                if(char.IsDigit(c)) {
                    digits++;
                    digit.Append(c);

                } else if(char.IsLetter(c)) {
                    letters++;
                    letter.Append(c);
                }
            }
            Dictionary<string, object> response = new Dictionary<string, object> {
                { "Digits", digit.ToString() },
                { "Letters", letter.ToString() },
                { "Digits Count", digits },
                { "Letters Count", letters }
            };
            return response;
        }
    }
}
