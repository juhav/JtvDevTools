﻿using FastColoredTextBoxNS;
using JtvDevTools.Commands;
using JtvDevTools.Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.WinForms.Forms
{
    public partial class MainForm : Form
    {
        private readonly HttpService httpService = new HttpService();
        private Dictionary<int, TextProcessingCommandBase> commands = new Dictionary<int, TextProcessingCommandBase>();
        private SqlToolsForm sqlToolsForm;
        private DataTable editorDataTable;

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

            sqlToolsForm = new SqlToolsForm(this);
            commands = Utils.GetClassesOfType<TextProcessingCommandBase>().ToDictionary(x => x.Id);

            TextEditorEditToolStripDropDownButton.DropDownItems.Clear();

            foreach (var cmd in commands.Values)
            {
                var item = new ToolStripMenuItem()
                {
                    Name = "TextEditorEditButton" + cmd.Id,
                    Text = cmd.Name,
                    DisplayStyle = ToolStripItemDisplayStyle.Text,
                    Tag = cmd.Id
                };

                item.Click += CommandMenuItem_Click!;

                TextEditorEditToolStripDropDownButton.DropDownItems.Add(item);
            }
        }

        public void WriteLine(string text)
        {
            //txtLog.AppendText(text);
            //txtLog.AppendText("\r\n");
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F5)
            //{
            //    e.SuppressKeyPress = true;
            //    e.Handled = true;

            //    var lines = txtCommands.Lines.ToArray();

            //    foreach (var line in lines)
            //    {
            //        CommandHandler.ProcessCommand(line);
            //    }
            //}
        }

        private void CommandMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;

            if (menuItem is null) return;

            if (menuItem.Tag is int)
            {
                var lines = txtEditor.Lines.ToArray();
                Execute(commands[(int)menuItem.Tag]);
            }
        }

        private void Execute(TextProcessingCommandBase command)
        {
            if (command.Parameters != null)
            {
                using (var form = new ParametersForm())
                {
                    var result = form.Show(command.Parameters);

                    if (result != DialogResult.OK) return;
                }
            }

            var lines = txtEditor.Lines.ToArray();
            lines = command.Process(lines);
            txtEditor.Text = string.Join("\r\n", lines);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Text = "";
        }

        private void SQLToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlToolsForm.Show();
        }

        private void CreateTableEditor()
        {
            editorDataTable = new DataTable();

            for (int i = 0; i < 15; i++)
            {
                var c = new DataColumn()
                {
                    ColumnName = "C" + (i + 1).ToString(),
                    DataType = typeof(string),
                    DefaultValue = "",
                };

                editorDataTable.Columns.Add(c);
            }

            for (int i = 0; i < 20; i++)
            {
                var row = editorDataTable.NewRow();
                editorDataTable.Rows.Add(row);
            }

            dgvEditor.DataSource = editorDataTable;

            foreach (DataGridViewColumn column in dgvEditor.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void SetRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }

            dgvEditor.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateTableEditor();
            SetRowNumber(dgvEditor);

            Type dgvType = dgvEditor.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgvEditor, true, null);
        }

        private void DataGridEditor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowHeaderText = (e.RowIndex + 1).ToString();
            var dgv = sender as DataGridView;
            using (SolidBrush brush = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor))
            {
                var textFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Far,
                    LineAlignment = StringAlignment.Center
                };

                var bounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth - 1, e.RowBounds.Height);
                e.Graphics.DrawString(rowHeaderText, this.Font, brush, bounds, textFormat);
            }
        }

        private void DataGridEditor_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dgv = sender as DataGridView;

            dgv.ClearSelection();
            dgv.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgv.Columns[e.ColumnIndex].Selected = true;
        }

        private void DataGridEditor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dgv = sender as DataGridView;

            dgv.ClearSelection();
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Rows[e.RowIndex].Selected = true;

        }

        private void DataGridEditor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            var dgv = sender as DataGridView;

            dgv.ClearSelection();
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }

        private void TableEditorTrimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.TrimSelectedCells(dgvEditor);
        }

        private void TableEditorInsertGuidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.InsertNewGuidToSelectedCells(dgvEditor);
        }

        private void DataGridEditor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DataGridEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewHelper.ClearSelectedCells(dgvEditor);
            }
        }

        private void NewRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = editorDataTable.NewRow();
            editorDataTable.Rows.Add(row);
        }

        private void NewColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorDataTable.Columns.Add(new DataColumn()
            {
                AllowDBNull = false,
                ColumnName = "Column_" + Guid.NewGuid().ToString("N"),
                DataType = typeof(string),
                DefaultValue = ""
            });
        }

        private void DataGridEditor_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void TextEditorNewToolStripButton_Click(object sender, EventArgs e)
        {
            txtEditor.Text = "";
        }

        private void TableEditorDeleteColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dgvEditor.DataSource = null;
            //dgvEditor.Columns.Clear();
            //dgvEditor.Rows.Clear();
            //dgvEditor.Refresh();

            var dataColumns = new List<DataColumn>();
            foreach (DataGridViewColumn column in dgvEditor.SelectedColumns)
            {
                var dataColumn = editorDataTable.Columns[column.DataPropertyName];
                dataColumns.Add(dataColumn);
            }

            dataColumns.ForEach(c => editorDataTable.Columns.Remove(c));
            //dgvEditor.DataSource = editorDataTable;
        }

        private void TableEditorAddColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorDataTable.Columns.Add(new DataColumn()
            {
                AllowDBNull = false,
                ColumnName = "Column_" + Guid.NewGuid().ToString("N"),
                DataType = typeof(string),
                DefaultValue = ""
            });
        }

        private void dgvEditor_DataMemberChanged(object sender, EventArgs e)
        {
            DataGridViewHelper.SetColumnSortMode(sender as DataGridView);
        }

        private void HttpClientNewRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = new ApiRequest()
            {
                BaseUrl = "https://base-url",
                Method = Core.HttpMethod.GET,
                PrettyPrint = true
            };

            txtRequest.Text = r.ToString();
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

        private void HtpClientSelectClientCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new SelectCertificateForm())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        if (i >= txtRequest.Lines.Count) break;

                        if (txtRequest.Lines[i].StartsWith("ClientCertificate"))
                        {
                            txtRequest.Selection = new FastColoredTextBoxNS.Range(txtRequest, i);
                            txtRequest.InsertText("ClientCertificate = " + form.CertificateThumbprint);
                            break;
                        }
                    }

                }
            }
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

        private StringBuilder SendInternal(Dictionary<string, string> variables)
        {
            var parser = new Parser(variables);

            parser.Parse(txtRequest.Text);

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
                        var json = Core.Utils.PrettyJson(response.Content);

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
                        var xml = Core.Utils.PrettyXML(response.Content);

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

        private void HttpClientSendToolStripButton_Click(object sender, EventArgs e)
        {
            txtResponse.Text = "Loading...";
            BackgroundWorker.RunWorkerAsync(new Dictionary<string, string>());
        }
    }
}
