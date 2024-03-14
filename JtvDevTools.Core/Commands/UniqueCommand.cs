using System;
using System.Collections.Generic;
using System.Linq;

namespace JtvDevTools.Commands
{
    public class UniqueCommand : TextProcessingCommandBase
    {
        public override int Id 
        { 
            get => Consts.Commands.Unique;  
        }

        public override string Name
        {
            get => "Unique Lines";
        }

        public UniqueCommand()
        {
            Parameters = new TextProcessingCommandParameters();

            Parameters.Add("Case sensitive", true);
        }

        public override string[] Process(string[] input)
        {
            if (input == null) return null;

            HashSet<string> hashset;

            bool isCaseSensitive = Parameters.Dictionary["Case sensitive"].Value.ToLowerInvariant() == "true";

            if (isCaseSensitive)  
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
