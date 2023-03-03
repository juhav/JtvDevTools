using JtvDevTools.RestClient.WinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestClient.WinForms.ViewModels;

public class AppViewModel
{
    public BindingList<Api> Apis { get; set; }
    public BindingList<HttpRequest> Requests { get; set; }
}
