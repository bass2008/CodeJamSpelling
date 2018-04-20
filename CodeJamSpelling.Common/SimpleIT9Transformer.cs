using System;
using System.Text;

namespace CodeJamSpelling.Common
{
    /// <summary>
    /// Простой преобразователь слова в последовательность цифр, необходимых для нажатия на Т9.
    /// </summary>
    public class SimpleT9Transformer
    {
        /// <summary>
        /// Получить результат преобразования слова в цифры.
        /// </summary>
        /// <param name="source">Строка источник.</param>
        /// <returns>Результат преобразования.</returns>
        public string GetResult(string source)
        {
            var builder = new StringBuilder();
            foreach (var ch in source)
            {
                var result = TransformChar(ch);

                // Проверка на необходимость паузы
                if (builder.Length > 0 && builder[builder.Length - 1] == result[0])
                    builder.Append(" ");

                builder.Append(result);
            }

            return builder.ToString();
        }

        private string TransformChar(char ch)
        {
            var t = string.Empty;
            switch (ch)
            {
                case 'a': t = "2"; break;
                case 'b': t = "22"; break;
                case 'c': t = "222"; break;
                case 'd': t = "3"; break;
                case 'e': t = "33"; break;
                case 'f': t = "333"; break;
                case 'g': t = "4"; break;
                case 'h': t = "44"; break;
                case 'i': t = "444"; break;
                case 'j': t = "5"; break;
                case 'k': t = "55"; break;
                case 'l': t = "555"; break;
                case 'm': t = "6"; break;
                case 'n': t = "66"; break;
                case 'o': t = "666"; break;
                case 'p': t = "7"; break;
                case 'q': t = "77"; break;
                case 'r': t = "777"; break;
                case 's': t = "7777"; break;
                case 't': t = "8"; break;
                case 'u': t = "88"; break;
                case 'v': t = "888"; break;
                case 'w': t = "9"; break;
                case 'x': t = "99"; break;
                case 'y': t = "999"; break;
                case 'z': t = "9999"; break;
                case ' ': t = "0"; break;

                default: throw new NotImplementedException($"Символ {ch} не поддерживается");
            }

            return t;
        }
    }
}
