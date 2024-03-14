using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.Commands
{
    public class PrependAppendCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.PrependAppend;
        }

        public override string Name
        {
            get => "Prepend and Append to Lines";
        }

        public PrependAppendCommand()
        {
            Parameters = new TextProcessingCommandParameters();

            Parameters.Add("String to Prepend", "");
            Parameters.Add("String to Append", "");
        }

        public override string[] Process(string[] input)
        {
            if (input == null) return null;

            var sb = new StringBuilder(1024);
            List<string> result = new List<string>();

            var textToPrepend = Parameters.Dictionary["String to Prepend"].Value;
            var textToAppend = Parameters.Dictionary["String to Append"].Value;

            for (int i = 0; i < input.Length; i++)
            {
                sb.Clear();
                sb.Append(textToPrepend);
                sb.Append(input[i]);
                sb.Append(textToAppend);

                result.Add(sb.ToString());    
            }

            return result.ToArray();
        }
    }
}
