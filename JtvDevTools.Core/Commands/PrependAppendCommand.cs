using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.Commands
{
    public class PrependAppendCommandOptions : TextProcessingCommandOptionsBase
    {
        public string TextToPrepend { get; set; }

        public string TextToAppend { get; set; }
    }

    public class PrependAppendCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.PrependAppend;
        }

        public override string[] Process(string[] input, TextProcessingCommandOptionsBase options)
        {
            if (input == null) return null;

            var sb = new StringBuilder(1024);
            List<string> result = new List<string>();
            var myOptions = (options as PrependAppendCommandOptions) ?? new PrependAppendCommandOptions();

            for (int i = 0; i < input.Length; i++)
            {
                sb.Clear();
                sb.Append(myOptions.TextToPrepend);
                sb.Append(input[i]);
                sb.Append(myOptions.TextToAppend);

                result.Add(sb.ToString());    
            }

            return result.ToArray();
        }
    }
}
