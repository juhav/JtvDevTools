using System;
using System.Collections.Generic;
using System.Linq;

namespace JtvDevTools.Commands
{
    public class JoinCommandOptions : TextProcessingCommandOptionsBase
    {
        public string Separator { get; set; }

        public JoinCommandOptions()
        {
            Separator = "";
        }
    }

    public class JoinCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.Join;
        }

        public override string[] Process(string[] input, TextProcessingCommandOptionsBase options)
        {
            if (input == null) return null;

            var myOptions = (options as JoinCommandOptions) ?? new JoinCommandOptions();

            return new string[] { string.Join(myOptions.Separator, input) };
        }
    }
}
