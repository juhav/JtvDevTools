using JtvDevTools.RestClient.WinForms.Core;
using JtvDevTools.RestClient.WinForms.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace JtvDevTools.RestClient.WinForms
{
    public partial class MainForm : Form
    {
        private readonly RestClientApp app;

        //private BindingList<ApiViewModel> apis = new BindingList<ApiViewModel>();
        //private BindingList<HttpRequestViewModel> requests = new BindingList<HttpRequestViewModel>();
        //private BindingList<HttpRequestViewModel> filteredRequests = new BindingList<HttpRequestViewModel>();
        //private BindingList<VariableViewModel> variables = new BindingList<VariableViewModel>();

        private BindingSource requestsSource;
        private BindingSource filteredRequestsSource;
        
        private ApiForm apiForm = new ApiForm();
        private VariableForm variableForm = new VariableForm();

        public MainForm()
        {
            InitializeComponent();

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var connectionString = Path.Combine(path, "jtv-restclient.db");
            app = new RestClientApp(new LiteDB(connectionString));
            app.LoadData();
            
            
            RequestsDataGridView.DataSource = new BindingSource(app.RequestsBindingList, null);
            dgvVariables.DataSource = new BindingSource(app.VariablesBindingList, null);

            //requestsSource = new BindingSource(requests, null);
            //filteredRequestsSource = new BindingSource(filteredRequests, null);

        }

        private void NewHTTPRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            using (var form = new HttpRequestForm())
            {
                var result = form.ShowDialog(ShowFormMode.New, null);

                if (result == DialogResult.OK)
                {
                    var viewModel = form.GetHttpRequestViewModel();
                    app.AddRequest(viewModel);
                }
            }
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (RequestsDataGridView.SelectedRows.Count < 1) return;

            var viewModel = RequestsDataGridView.SelectedRows[0].DataBoundItem as HttpRequestViewModel;

            if (viewModel == null) return;
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (RequestsDataGridView.SelectedRows.Count < 1) return;

            var viewModel = RequestsDataGridView.SelectedRows[0].DataBoundItem as HttpRequestViewModel;

            if (viewModel == null) return;
        }

        private void RequestsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (RequestsDataGridView.Columns[e.ColumnIndex].DataPropertyName == "ApiId")
            //{
            //    var apiId = (Guid)e.Value!;

            //    var api = apis.FirstOrDefault(api => api.Id == apiId);

            //    e.Value = api?.Name ?? "";
            //}
        }

        private void btnNewVariable_Click(object sender, EventArgs e)
        {
            var result = variableForm.ShowDialog();
        }

        private void btnDeleteVariable_Click(object sender, EventArgs e)
        {

        }


        //private void FilterTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(FilterTextBox.Text))
        //    {
        //        var bs = new BindingSource(requests, null);
        //        RequestsDataGridView.DataSource = requestsSource;
        //        return;
        //    }

        //    filteredRequests.Clear();
        //    foreach (var r in requests)
        //    {
        //        if (r.Name.Contains(FilterTextBox.Text)) filteredRequests.Add(r);
        //    }

        //    RequestsDataGridView.DataSource = filteredRequestsSource;
        //}
    }
}

