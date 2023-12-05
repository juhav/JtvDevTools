using System;
using System.IO;
using System.Text;

namespace JtvDevTools.Commands
{
    public class FormatXmlCommand : TextProcessingCommandBase
    {
        public override int Id
        {
            get => Consts.Commands.FormatXml;
        }

        public override string Name
        {
            get => "Format XML";
        }

        public override string[] Process(string[] input)
        {
            if (input == null) return null;

            try
            {
                var xml = string.Join("\r\n", input);

                MemoryStream mStream = new MemoryStream();
                System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(mStream, Encoding.Unicode);
                System.Xml.XmlDocument document = new System.Xml.XmlDocument();

                // Load the XmlDocument with the XML.
                document.LoadXml(xml);

                writer.Formatting = System.Xml.Formatting.Indented;

                // Write the XML into a formatting XmlTextWriter
                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();

                // Have to rewind the MemoryStream in order to read
                // its contents.
                mStream.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                StreamReader sReader = new StreamReader(mStream);

                // Extract the text from the StreamReader.
                string formattedXml = sReader.ReadToEnd();

                mStream.Close();
                writer.Close();

                return formattedXml.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            }
            catch (Exception ex)
            {
                return new string[] { ex.Message };
            }
        }
    }
}
