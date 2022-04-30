using System.Collections.Generic;

namespace JtvDevTools.Commands
{
    public class RemoveEmptyLinesCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.RemoveEmptyLines;
        }

        public override string[] Process(string[] input, TextProcessingCommandOptionsBase options)
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
