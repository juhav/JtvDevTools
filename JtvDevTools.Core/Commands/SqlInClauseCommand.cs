using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.Commands
{
    public class SqlInClauseCommand : TextProcessingCommandBase
    {
        public override int Id { get => Consts.Commands.SqlInClause; }

        public override string Name
        {
            get => "SQL in (1, 2, 3)";
        }

        public override string[] Process(string[] input)
        {
            input = RemoveEmptyLines(input);

            if (input.Length == 0)
            {
                return new string[] { "" };
            }
            else if (input.Length == 1)
            {
                return new string[] { $"in ({input[0]})" };
            }
            else if (input.Length > 1)
            {
                var result = new StringBuilder(4096);

                result.AppendLine("in (");

                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (!string.IsNullOrWhiteSpace(input[i]))
                    {
                        result.Append(input[i].Trim());
                        result.AppendLine(",");
                    }
                }

                result.AppendLine(input[input.Length - 1].Trim());
                result.AppendLine(")");

                return new string[] { result.ToString() };
            }

            return new string[] { "" };
        }
    }
}
