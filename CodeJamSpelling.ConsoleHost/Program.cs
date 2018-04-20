namespace CodeJamSpelling.ConsoleHost
{
    /// <summary>
    /// Запускает генератор для генерации файла с результатами работы.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var runner = new OutputFileGenerator();
            runner.Generate();
        }
    }
}
