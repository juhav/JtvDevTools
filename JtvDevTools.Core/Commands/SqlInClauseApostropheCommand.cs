using System.Text;

namespace JtvDevTools.Commands
{
    public class SqlInClauseApostropheCommand : TextProcessingCommandBase
    {
        public override int Id { get => Consts.Commands.SqlInClauseApostrophe; }
        
        public override string Name
        {
            get => "SQL in ('a', 'b', 'c')";
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
                        result.Append("'");
                        result.Append(input[i].Trim());
                        result.Append("'");
                        result.AppendLine(",");
                    }
                }

                result.Append("'");
                result.Append(input[input.Length - 1].Trim());
                result.AppendLine("'");
                result.AppendLine(")");

                return new string[] { result.ToString() };
            }

            return new string[] { "" };
        }
    }
}
