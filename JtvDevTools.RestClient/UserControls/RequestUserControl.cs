using FastColoredTextBoxNS;
using JtvDevTools.Core;
using JtvDevTools.RestClient.Forms;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient.UserControls
{
    public partial class RequestUserControl : UserControl
    {
        private readonly MyAppContext myAppContext;
        private readonly HttpService httpService = new HttpService();
        private SelectVariableForm selectVariableForm;
        private Style BlueStyle;
        private Style GreenStyle;
        private Style GrayStyle;
        
        public ApiRequest Request { get; set; }

        public RequestUserControl(MyAppContext myAppContext, ApiRequest request)
        {
            InitializeComponent();

            this.myAppContext = myAppContext;
            this.Request = request;

            var blueBrush = new SolidBrush(Color.FromArgb(86, 156, 214));
            BlueStyle = new TextStyle(blueBrush, null, FontStyle.Bold);

            var greenBrush = new SolidBrush(Color.FromArgb(87, 166, 74));
            GreenStyle = new TextStyle(greenBrush, null, FontStyle.Bold);

            var grayBrush = new SolidBrush(Color.FromArgb(127, 127, 127));
            GrayStyle = new TextStyle(grayBrush, null, FontStyle.Bold);

            if (request != null)
            {
                txtRequest.Text = Request.ToString();
                txtRequestBody.Text = Request.Body;
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            txtResponse.Text = "Loading...";
            BackgroundWorker.RunWorkerAsync(new Dictionary<string, string>());
        }

        private void NewRequest_Click(object sender, EventArgs e)
        {
            Request = new ApiRequest()
            {
                BaseUrl = "https://catfact.ninja",
                Resource = "fact",
                Method = HttpMethod.GET,
                PrettyPrint = true
            };

            txtRequest.Text = Request.ToString();
            txtRequestBody.Text = "";
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
            var parser = new Parser(myAppContext.Variables);

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

        private StringBuilder PrintResponse(ApiRequest operation, RestResponse response, long elapsedMilliseconds)
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

        private void txtRequest_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle(BlueStyle);
            e.ChangedRange.ClearStyle(GreenStyle);
            e.ChangedRange.ClearStyle(GrayStyle);

            e.ChangedRange.SetStyle(BlueStyle, @"\[[A-Za-z]+\]", System.Text.RegularExpressions.RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GreenStyle, @"\%.+?\%", System.Text.RegularExpressions.RegexOptions.Singleline);
            e.ChangedRange.SetStyle(GrayStyle, @"^\#.*$", System.Text.RegularExpressions.RegexOptions.Singleline);
        }

        private void insertGuidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var source = WindowsFormsHelper.GetContextMenuSourceTextBox(sender);

            WindowsFormsHelper.InsertTextToFastColoredTextBox(source, Guid.NewGuid().ToString());
        }

        private void insertFileToBase64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileName = WindowsFormsHelper.PickFile();

            if (string.IsNullOrEmpty(fileName)) return;

            WindowsFormsHelper.InsertTextToFastColoredTextBox(RequestContextMenuStrip.SourceControl as FastColoredTextBox, "% FileToBase64(\"" + fileName.Replace('\\', '/') + "\") %");
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            var tabPage = this.Parent as TabPage;
            var tabControl = tabPage.Parent as TabControl;

            tabPage.Controls.Clear();

            tabControl.TabPages.Remove(tabPage);
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            var parser = new Parser(myAppContext.Variables);

            parser.Parse(txtRequest.Text, txtRequestBody.Text);

            var request = parser.ApiRequest;

            myAppContext.Database.SaveRequest(request);
        }

        private void InsertVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectVariableForm == null) selectVariableForm = new SelectVariableForm(myAppContext);

            selectVariableForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            selectVariableForm.StartPosition = FormStartPosition.CenterParent;
            selectVariableForm.SetGridDataSource();
            selectVariableForm.ShowDialog(this.ParentForm);

            if (string.IsNullOrWhiteSpace(selectVariableForm.SelectedVariable)) return;

            WindowsFormsHelper.InsertTextToFastColoredTextBox(RequestContextMenuStrip.SourceControl as FastColoredTextBox, "% Var(\"" + selectVariableForm.SelectedVariable + "\") %");

        }
    }
}
