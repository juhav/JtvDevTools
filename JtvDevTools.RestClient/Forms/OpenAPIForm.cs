using Microsoft.OpenApi.Readers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.RestClient.Forms
{
    public partial class OpenAPIForm : Form
    {
        public OpenAPIForm()
        {
            InitializeComponent();
        }

        private async void GetSpecificationButton_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://raw.githubusercontent.com/"),
            };

            var stream = await httpClient.GetStreamAsync("OAI/OpenAPI-Specification/master/examples/v3.0/petstore.json").ConfigureAwait(true);
            var streamReader = new StreamReader(stream, Encoding.UTF8);

            var spec = streamReader.ReadToEnd();

            var openApiDocument = new OpenApiStringReader().Read(spec, out OpenApiDiagnostic diagnostic);

            textBox2.Text = spec;
        }
    }
}
