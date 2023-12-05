using System;
using System.Collections.Generic;
using System.Linq;

namespace JtvDevTools.Commands
{
    public class JoinCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.Join;
        }

        public override string Name
        {
            get => "Join Lines";
        }

        public override string[] Process(string[] input)
        {
            if (input == null) return null;

            var separator = ",";

            return new string[] { string.Join(separator, input) };
        }
    }
}
