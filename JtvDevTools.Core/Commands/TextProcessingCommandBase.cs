using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.Commands
{
    public partial class Consts
    {
        public class Commands
        {
            public const int Trim = 1;
            public const int Unique = 2;
            public const int RemoveEmptyLines = 3;
            public const int ListDuplicates = 4;
            public const int FormatXml = 5;
            public const int FormatJson = 6;
            public const int PrependAppend = 7;
            public const int Join = 8;
            public const int SqlInClause = 9;
            public const int SqlInClauseApostrophe = 10;
        }
    }

    public class TextProcessingCommandOptionsBase
    {
    }

    public abstract class TextProcessingCommandBase
    {
        public abstract int Id { get; }

        public abstract string[] Process(string[] input, TextProcessingCommandOptionsBase options);

        protected string[] RemoveEmptyLines(string[] input)
        {
            if (input == null) return null;

            var output = new List<string>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();

                if (input[i].Length == 0) continue;

                output.Add(input[i]);
            }

            return output.ToArray();
        }
    }
    
}
