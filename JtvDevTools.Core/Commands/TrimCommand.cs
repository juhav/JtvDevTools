namespace JtvDevTools.Commands
{
    public class TrimCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.Trim;
        }

        public override string Name
        {
            get => "Trim Lines";
        }

        public TrimCommand()
        {
            Parameters = new TextProcessingCommandParameters();

            Parameters.Add("Trim Chars", "");
        }

        public override string[] Process(string[] input)
        {
            if (input == null) return null;

            var trimChars = Parameters.Parameters["Trim Chars"].Value;

            if (!string.IsNullOrEmpty(trimChars))
            {
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = input[i].Trim(trimChars.ToCharArray());
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = input[i].Trim();
                }
            }

            return input;
        }
    }
}
