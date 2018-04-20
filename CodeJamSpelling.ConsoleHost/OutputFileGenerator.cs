using CodeJamSpelling.Common;
using System.IO;
using System.Linq;

namespace CodeJamSpelling.ConsoleHost
{
    /// <summary>
    /// Генерирует OutputFile на основании трансформации исходных данных из InputFile
    /// </summary>
    public class OutputFileGenerator
    {
        private const string InputFile = @"C:\\Users\\Admin\\Desktop\\Spelling.in";

        private const string OutputFile = @"C:\\Users\\Admin\\Desktop\\Spelling.out";

        public void Generate()
        {
            var transformer = new SimpleT9Transformer();
            var inputs = File.ReadLines(InputFile).ToList();

            if (File.Exists(OutputFile))
                File.Delete(OutputFile);

            for (var i = 1; i < inputs.Count; i++)
            {
                var result = transformer.GetResult(inputs[i]);
                File.AppendAllText(OutputFile, $"Case #{i}: {result} \n");
            }
        }
    }
}
