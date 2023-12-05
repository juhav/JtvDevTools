using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools
{
    //public class TextProcessor
    //{
    //    public static string FormatXML(string[] input)
    //    {
    //        if (input == null) return "";

    //        var xml = string.Join("\r\n", input);

    //        MemoryStream mStream = new MemoryStream();
    //        System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(mStream, Encoding.Unicode);
    //        System.Xml.XmlDocument document = new System.Xml.XmlDocument();

    //        // Load the XmlDocument with the XML.
    //        document.LoadXml(xml);

    //        writer.Formatting = System.Xml.Formatting.Indented;

    //        // Write the XML into a formatting XmlTextWriter
    //        document.WriteContentTo(writer);
    //        writer.Flush();
    //        mStream.Flush();

    //        // Have to rewind the MemoryStream in order to read
    //        // its contents.
    //        mStream.Position = 0;

    //        // Read MemoryStream contents into a StreamReader.
    //        StreamReader sReader = new StreamReader(mStream);

    //        // Extract the text from the StreamReader.
    //        string formattedXml = sReader.ReadToEnd();

    //        mStream.Close();
    //        writer.Close();

    //        return formattedXml;
    //    }

    //    public static string FormatJSON(string input)
    //    {
    //        dynamic parsedJson = JsonConvert.DeserializeObject(input);
    //        var formattedJson = JsonConvert.SerializeObject(parsedJson, Newtonsoft.Json.Formatting.Indented);

    //        return formattedJson;
    //    }

    //    public static void Trim(string[] input, string trimChars = null)
    //    {
    //        if (string.IsNullOrWhiteSpace(trimChars))
    //        {
    //            for (int i = 0; i < input.Length; i++)
    //            {
    //                input[i] = input[i].Trim();
    //            }
    //        }
    //        else
    //        {
    //            for (int i = 0; i < input.Length; i++)
    //            {
    //                input[i] = input[i].Trim(trimChars.ToCharArray());
    //            }
    //        }
    //    }

    //    public static string[] RemoveEmptyLines(string[] input)
    //    {
    //        var result = new List<string>();

    //        for (int i = 0; i < input.Length; i++)
    //        {
    //            if (!string.IsNullOrEmpty(input[i]))
    //            {
    //                result.Add(input[i]);
    //            }
    //        }

    //        return result.ToArray();
    //    }


    //    public static string Base64Encode(string input)
    //    {
    //        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(input);
    //        return Convert.ToBase64String(plainTextBytes);
    //    }

    //    public static string Base64Decode(string input)
    //    {
    //        var base64EncodedBytes = System.Convert.FromBase64String(input);
    //        return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
    //    }

    //    public static string SqlInClause(string[] input)
    //    {
    //        input = RemoveEmptyLines(input);

    //        if (input.Length == 0)
    //        {
    //            return "";
    //        }
    //        else if (input.Length == 1)
    //        {
    //            return $"in ({input[0]})";
    //        }
    //        else if (input.Length > 1)
    //        {
    //            var result = new StringBuilder();
                
    //            result.AppendLine("in (");

    //            for (int i = 0; i < input.Length - 1; i++)
    //            {
    //                if (!string.IsNullOrWhiteSpace(input[i]))
    //                {
    //                    result.Append(input[i].Trim());
    //                    result.AppendLine(",");
    //                }
    //            }

    //            result.AppendLine(input[input.Length - 1].Trim());
    //            result.AppendLine(")");
    //            return result.ToString();
    //        }

    //        return "";            
    //    }

    //    public static string SqlInClauseApostrophe(string[] input)
    //    {
    //        input = RemoveEmptyLines(input);

    //        if (input == null || input.Length == 0)
    //        {
    //            return "";
    //        }
    //        else if (input.Length == 1)
    //        {
    //            return $"in ({input[0]})";
    //        }
    //        else if (input.Length > 1)
    //        {
    //            var result = new StringBuilder();

    //            result.AppendLine("in (");

    //            for (int i = 0; i < input.Length - 1; i++)
    //            {
    //                if (!string.IsNullOrWhiteSpace(input[i]))
    //                {
    //                    result.Append("'");
    //                    result.Append(input[i].Trim());
    //                    result.AppendLine("',");
    //                }
    //            }

    //            result.Append("'");
    //            result.Append(input[input.Length - 1].Trim());
    //            result.AppendLine("'");
    //            result.AppendLine(")");
    //            return result.ToString();
    //        }

    //        return "";
    //    }


    //    public static string Append(string[] input, string text)
    //    {
    //        var result = new StringBuilder(4096);

    //        for (int i = 0; i < input.Length; i++)
    //        {
    //            result.Append(input[i]);
    //            result.AppendLine(text);
    //        }

    //        return result.ToString();
    //    }

    //    public static string Prepend(string[] input, string text)
    //    {
    //        var result = new StringBuilder(4096);

    //        for (int i = 0; i < input.Length; i++)
    //        {
    //            result.Append(text);
    //            result.AppendLine(input[i]);
    //        }

    //        return result.ToString();
    //    }

    //    public static string AppendPrepend(string[] input, string appendText, string prependText)
    //    {
    //        var result = new StringBuilder(4096);

    //        for (int i = 0; i < input.Length; i++)
    //        {
    //            result.Append(appendText);
    //            result.Append(input[i]);
    //            result.AppendLine(prependText);
    //        }

    //        return result.ToString();
    //    }

    //    public static string Unique(string[] input)
    //    {
    //        input = RemoveEmptyLines(input);

    //        var result = new HashSet<string>();

    //        for (int i=0; i<result.Count; i++)
    //        {
    //            result.Add(input[i]);
    //        }

    //        return string.Join("\r\n", result.ToArray());
    //    }

    //    public static string[] Join(string[] input, string separator)
    //    {
    //        return new string[] { string.Join(separator, input) };
    //    }

    //    public static string[] ListDuplicateLines(string[] input)
    //    {
    //        input = RemoveEmptyLines(input);

    //        var unique = new HashSet<string>();
    //        var duplicate = new HashSet<string>();

    //        for (int i = 0; i < input.Length; i++)
    //        {
    //            if (unique.Contains(input[i]))
    //            {
    //                if (!duplicate.Contains(input[i]))
    //                {
    //                    duplicate.Add(input[i]);
    //                }
    //            }

    //            unique.Add(input[i]);
    //        }

    //        return duplicate.ToArray();
    //    }
    //}


    
}
