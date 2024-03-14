using FastColoredTextBoxNS;
using JtvDevTools.Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient
{
    public partial class MainForm : Form
    {
        private readonly HttpService httpService = new HttpService();
        private readonly string appDataFolder;
        private readonly Dictionary<string, string> variables = new Dictionary<string, string>();
        private Style BlueStyle;
        private Style GreenStyle;
        private Style GrayStyle;

        public MainForm()
        {
            InitializeComponent();

            var blueBrush = new SolidBrush(Color.FromArgb(86, 156, 214));
            BlueStyle = new TextStyle(blueBrush, null, FontStyle.Bold);

            var greenBrush = new SolidBrush(Color.FromArgb(87, 166, 74));
            GreenStyle = new TextStyle(greenBrush, null, FontStyle.Bold);

            var grayBrush = new SolidBrush(Color.FromArgb(127, 127, 127));
            GrayStyle = new TextStyle(grayBrush, null, FontStyle.Bold);

            txtRequest.Text = "[Request]";

            appDataFolder = WindowsFormsHelper.GetAppDataFolder();
            var variablesFile = Path.Combine(appDataFolder, "variables.txt");
            if (File.Exists(variablesFile))
            {
                var text = File.ReadAllText(variablesFile, Encoding.UTF8);
                variables = Utils.GetKeyValuePairs(text);
            }
        }

        private void NewRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = new ApiRequest()
            {
                BaseUrl = "dev",
                Resource = "fact",
                Method = HttpMethod.GET,
                PrettyPrint = true
            };

            r.BaseUrls.Add("dev", "https://catfact.ninja");
            r.BaseUrls.Add("test", "https://catfact.ninja");
            r.BaseUrls.Add("prod", "");

            txtRequest.Text = r.ToString();
            txtRequestBody.Text = "";
        }

        private void txtRequest_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle(BlueStyle);
            e.ChangedRange.ClearStyle(GreenStyle);
            e.ChangedRange.ClearStyle(GrayStyle);

            e.ChangedRange.SetStyle(BlueStyle, @"\[[A-Za-z]+\]", System.Text.RegularExpressions.RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"\<\=.+?\>", System.Text.RegularExpressions.RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GrayStyle, @"^\#.*$", System.Text.RegularExpressions.RegexOptions.Singleline);
        }

        private void insertGuidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var source = GetContectMenuSourceTextBox(sender);

            InsertTextToFastColoredTextBox(source, Guid.NewGuid().ToString());
        }

        private void insertFileToBase64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileName = WindowsFormsHelper.PickFile();

            if (string.IsNullOrEmpty(fileName)) return;

            InsertTextToFastColoredTextBox(RequestContextMenuStrip.SourceControl as FastColoredTextBox, "{! FileToBase64(\"" + fileName.Replace('\\', '/') + "\") !}");
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = SendInternal(e.Argument as Dictionary<string, string>);
            }
            catch (Exception ex)
            {
                e.Result = new StringBuilder(ex.Message);
            }
        }

        private StringBuilder SendInternal(Dictionary<string, string> dictionary)
        {
            var parser = new Parser(variables);

            parser.Parse(txtRequest.Text, txtRequestBody.Text);

            var request = parser.ApiRequest;
            var sw = Stopwatch.StartNew();
            var response = httpService.Send(request);
            sw.Stop();

            return PrintResponse(request, response, sw.ElapsedMilliseconds);
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var sb = e.Result as StringBuilder;

            txtResponse.Text = sb.ToString();
        }

        private StringBuilder PrintResponse(ApiRequest operation, RestSharp.RestResponse response, long elapsedMilliseconds)
        {
            var sb = new StringBuilder(4096);

            if (operation == null)
            {
                sb.AppendLine("API operation is null.");
                return sb;
            }

            if (response == null)
            {
                sb.AppendLine("Response is null.");
                return sb;
            }

            var contentType = (response.ContentType ?? "");
            var contentLength = response.Content != null ? response.Content.Length : 0;

            if (operation.OutputMode == RequestOutputMode.All || operation.OutputMode == RequestOutputMode.StatusCode)
            {
                sb.Append("[");

                if (response.IsSuccessStatusCode)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                sb.Append((int)response.StatusCode);
                sb.Append(" - ");
                sb.Append(response.StatusCode.ToString());
                sb.Append("] ");

                sb.Append($"{elapsedMilliseconds} ms");
                //sb.AppendLine($"Content Type: {contentType}");
                sb.AppendLine($", {contentLength} bytes");
                sb.AppendLine();
            }

            //if (operation.OutputMode == RequestOutputMode.All)
            //{
            //    Console.ForegroundColor = fgColor;
            //    sb.AppendLine($"Elapsed Time: {elapsedMilliseconds} ms");
            //    sb.AppendLine($"Content Type: {contentType}");
            //    sb.AppendLine($"Content Length: {contentLength} bytes");
            //    sb.AppendLine();
            //}

            PrintHeaders(sb, operation, response);

            if (!response.IsSuccessful)
            {
                sb.AppendLine(response?.ErrorMessage);
                return sb;
            }

            bool isOutputFile = !string.IsNullOrWhiteSpace(operation.SaveResponseBodyToFile);
            bool isOutputModeWithBody = operation.OutputMode == RequestOutputMode.All || operation.OutputMode == RequestOutputMode.Body;

            if (isOutputFile || isOutputModeWithBody)
            {
                if (operation.PrettyPrint)
                {
                    if (contentType.Contains("application/json") || contentType.Contains("application/problem+json"))
                    {
                        var json = Utils.PrettyJson(response.Content);

                        if (isOutputModeWithBody)
                        {
                            sb.AppendLine(json);
                        }

                        if (isOutputFile)
                        {
                            System.IO.File.WriteAllText(operation.SaveResponseBodyToFile, json, Encoding.UTF8);
                        }
                    }
                    else if (contentType.Contains("text/xml") || contentType.Contains("application/xml"))
                    {
                        var xml = Utils.PrettyXML(response.Content);

                        if (isOutputModeWithBody)
                        {
                            sb.AppendLine(xml);
                        }

                        if (isOutputFile)
                        {
                            System.IO.File.WriteAllText(operation.SaveResponseBodyToFile, xml, Encoding.UTF8);
                        }
                    }
                    else
                    {
                        sb.AppendLine(response.Content);
                    }
                }
                else
                {
                    sb.AppendLine(response.Content);
                }
            }

            return sb;
        }

        private static void PrintHeaders(StringBuilder sb, ApiRequest operation, RestResponse response)
        {
            if (response.Headers == null) return;

            foreach (var header in response.Headers)
            {
                sb.Append(header.Name);
                sb.Append(": ");
                sb.AppendLine(header.Value?.ToString());
            }

            sb.AppendLine();
        }

        private void SendRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtResponse.Text = "Loading...";
            BackgroundWorker.RunWorkerAsync(new Dictionary<string, string>());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new SelectCertificateForm())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < txtRequest.Lines.Count; i++)
                    {
                        if (txtRequest.Lines[i].StartsWith("ClientCertificate"))
                        {
                            txtRequest.Selection = new Range(txtRequest, i);
                            txtRequest.InsertText("ClientCertificate = " + form.CertificateThumbprint);
                            break;
                        }
                    }

                }
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            txtResponse.Text = "Loading...";
            BackgroundWorker.RunWorkerAsync(new Dictionary<string, string>());
        }

        private FastColoredTextBox GetContectMenuSourceTextBox(object sender)
        {
            try
            {
                return (((sender as ToolStripMenuItem)?.Owner as ContextMenuStrip)?.SourceControl as FastColoredTextBox);
            }
            catch
            {
                return null;
            }
        }

        private void InsertTextToFastColoredTextBox(FastColoredTextBox target, string text)
        {
            if (target == null || string.IsNullOrEmpty(text)) return;
         
            try
            {
                target.InsertText(text);
            }
            catch
            {
            }
        }
    }
}
