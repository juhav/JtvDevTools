using System;
using System.Collections.Generic;
using System.Linq;

namespace JtvDevTools.Commands
{
    public class UniqueCommandOptions : TextProcessingCommandOptionsBase
    {
        public bool IsCaseSensitive { get; set; }

        public UniqueCommandOptions()
        {
            IsCaseSensitive = true;
        }
    }

    public class UniqueCommand : TextProcessingCommandBase
    {
        public override int Id 
        { 
            get => Consts.Commands.Unique;  
        } 

        public override string[] Process(string[] input, TextProcessingCommandOptionsBase options)
        {
            if (input == null) return null;

            HashSet<string> hashset;
            var myOptions = (options as UniqueCommandOptions) ?? new UniqueCommandOptions();

            if (myOptions.IsCaseSensitive)  
            {
                hashset = new HashSet<string>(StringComparer.CurrentCulture);
            }
            else
            {
                hashset = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase);
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(input[i])) continue;
                
                hashset.Add(input[i]);
            }

            return hashset.ToArray();
        }
    }
}
