using CodeJamSpelling.Common;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace CodeJamSpelling.Tests.SpellingTests
{
    [TestFixture]
    public class SpellingTests
    {
        private const string InputFileName = "Spelling.in";

        private const string OutputFileName = "Spelling.out";

        /// <summary>
        /// Проверка результатов работы преобразователя с помощью сравнения с эталонными данными.
        /// </summary>
        [Test]
        public void RunSimpleT9TransformerTest()
        {
            // Arrange
            var inputFilePath = AppDomain.CurrentDomain.BaseDirectory + InputFileName;
            var outputFilePath = AppDomain.CurrentDomain.BaseDirectory + OutputFileName;
            var inputs = File.ReadLines(inputFilePath).ToList();
            var outputs = File.ReadLines(outputFilePath).ToList();
            var transformer = new SimpleT9Transformer();
            for (var i = 1; i < inputs.Count; i++)
            {
                // Act
                var result = transformer.GetResult(inputs[i]);
                var finalResult = $"Case #{i}: {result} ";

                // Assert
                Assert.IsTrue(finalResult == outputs[i - 1]);
            }
        }        
    }
}
