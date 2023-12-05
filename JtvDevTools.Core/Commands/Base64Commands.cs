using System.Text;

namespace JtvDevTools.Commands
{
    public class Base64EncodeCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.Base64Encode;
        }

        public override string Name
        {
            get => "Text to Base64";
        }

        public override string[] Process(string[] input)
        {
            if (input == null) return new string[0];

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(string.Join("\r\n", input));
            return new string[] { Convert.ToBase64String(plainTextBytes) };
        }
    }

    public class Base64DecodeCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.Base64Decode;
        }

        public override string Name
        {
            get => "Base64 to Text";
        }

        public override string[] Process(string[] input)
        {
            if (input == null) return new string[0];

            var base64EncodedBytes = System.Convert.FromBase64String(input[0]);
            return new string[] { System.Text.Encoding.UTF8.GetString(base64EncodedBytes) };
        }
    }
}
