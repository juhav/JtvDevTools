using System;
using System.Collections.Generic;
using System.IO;

namespace JtvDevTools.Core
{
    public class EvaluatorContext
    {
        private Random rng = new Random();

        public Dictionary<string, string> Variables = new Dictionary<string, string>();

        public EvaluatorContext()
        {
        }

        public string Input(string prompt)
        {
            Console.Write(prompt);
            Console.Write(" ");

            var input = Console.ReadLine();

            return input;
        }

        public string RandomInt(int min, int max)
        {
            var number = rng.Next(min, max + 1);

            return number.ToString();
        }

        public string FileToBase64(string fileName)
        {
            if (File.Exists(fileName))
            {
                return Utils.FileToBase64(fileName);
            }
            else
            {
                throw new ApplicationException($"File not found: {fileName}");
            }
        }

        public string NewGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public string NewGuid(string format)
        {
            return Guid.NewGuid().ToString(format);
        }

        public string Var(string name)
        {
            return Variables[name];
        }

        public string RandomLine(string fileName)
        {
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName);
                int i = rng.Next(0, lines.Length);

                return lines[i];
            }
            else
            {
                throw new ApplicationException($"File not found: {fileName}");
            }
        }
    }
}