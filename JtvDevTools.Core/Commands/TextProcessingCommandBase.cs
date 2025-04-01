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
            public const int Base64Encode = 11;
            public const int Base64Decode = 12;
        }
    }

    public enum TextProcessingCommandParameterType
    {
        String = 0,
        Int = 1,
        Bool = 2
    }

    public class TextProcessingCommandParameter
    {
        private string value = "";

        public string Name { get; set; }
        public TextProcessingCommandParameterType ParameterType { get; set; }
        
        public string? Value 
        { 
            get
            {
                return this.value;
            }
            set
            {
                if (ParameterType == TextProcessingCommandParameterType.Bool)
                {
                    value = (value ?? "").Trim().ToUpperInvariant();

                    this.value = "false";

                    if (value == "TRUE" || value == "YES" || value == "Y" || value == "1") { this.value = "true"; }

                }
                else
                {
                    this.value = value;
                }
            }
        }
    }

    public class TextProcessingCommandParameters
    {
        private Dictionary<string, TextProcessingCommandParameter> dictionary = new Dictionary<string, TextProcessingCommandParameter>(StringComparer.InvariantCultureIgnoreCase);

        public Dictionary<string, TextProcessingCommandParameter> Dictionary
        {
            get => dictionary;
        }

        public void Add(string key, string value)
        {
            dictionary.Add(key, new TextProcessingCommandParameter()
            {
                Name = key,
                ParameterType = TextProcessingCommandParameterType.String,
                Value = value
            });
        }

        internal void Add(string key, bool value)
        {
            dictionary.Add(key, new TextProcessingCommandParameter()
            {
                Name = key,
                ParameterType = TextProcessingCommandParameterType.Bool,
                Value = value.ToString().ToLowerInvariant()
            });
        }
    }

    public abstract class TextProcessingCommandBase
    {
        public abstract int Id { get; }

        public abstract string Name { get; }

        public abstract string[]? Process(string[] input);

        public TextProcessingCommandParameters? Parameters { get; protected set;  }

        protected string[]? RemoveEmptyLines(string[] input)
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
