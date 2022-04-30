namespace JtvDevTools.Commands
{
    public class TrimCommandOptions : TextProcessingCommandOptionsBase
    {
        public string TrimChars { get; set; }
    }

    public class TrimCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.Trim;
        }

        public override string[] Process(string[] input, TextProcessingCommandOptionsBase options)
        {
            if (input == null) return null;

            var myOptions = options as TrimCommandOptions;

            if (myOptions != null)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = input[i].Trim(myOptions.TrimChars.ToCharArray());
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
