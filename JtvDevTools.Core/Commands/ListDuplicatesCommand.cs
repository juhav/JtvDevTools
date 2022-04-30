using System;
using System.Collections.Generic;
using System.Linq;

namespace JtvDevTools.Commands
{
    public class ListDuplicatesCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.ListDuplicates;
        }

        public override string[] Process(string[] input, TextProcessingCommandOptionsBase options)
        {
            if (input == null) return null;

            var unique = new HashSet<string>();
            var duplicate = new HashSet<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (string.IsNullOrEmpty(input[i])) continue;

                if (unique.Contains(input[i]))
                {
                    if (!duplicate.Contains(input[i]))
                    {
                        duplicate.Add(input[i]);
                    }
                }

                unique.Add(input[i]);
            }

            return duplicate.ToArray();
        }
    }
}
