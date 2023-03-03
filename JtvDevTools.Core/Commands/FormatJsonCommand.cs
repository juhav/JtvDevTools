using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace JtvDevTools.Commands
{
    public class FormatJsonCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.FormatJson;
        }

        public override string[]? Process(string[] input, TextProcessingCommandOptionsBase options)
        {
            if (input == null) return null;

            var json = string.Join("\r\n", input);

            dynamic parsedJson = JsonConvert.DeserializeObject(json)!;
            string formattedJson = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);

            return formattedJson.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries); 
        }
    }
}
