using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace JtvDevTools.RestClient;

public class ActionTabItem : ObservableObject
{
    public ActionTabViewModel Parent;

    // This will be the text in the tab control
    public string Header { get; set; }
    // This will be the content of the tab control It is a UserControl whits you need to create manualy
    public UserControl Content { get; set; }

    public ICommand CloseTabCommand { get; private set; }

    public ActionTabItem()
    {
        CloseTabCommand = new RelayCommand(ExecuteCloseTabCommand);
    }

    private void ExecuteCloseTabCommand()
    {
        Parent.Tabs.Remove(this);
    }
}

public class ActionTabViewModel
{
    // These Are the tabs that will be bound to the TabControl 
    public ObservableCollection<ActionTabItem> Tabs { get; set; }

    public ActionTabViewModel()
    {
        Tabs = new ObservableCollection<ActionTabItem>();
    }

    public void Populate()
    {
        // Add A tab to TabControl With a specific header and Content(UserControl)
        Tabs.Add(new ActionTabItem { Parent = this, Header = "UserControl 1", Content = new TabItemUserControl() });
        // Add A tab to TabControl With a specific header and Content(UserControl)
        Tabs.Add(new ActionTabItem { Parent = this, Header = "UserControl 2", Content = new TabItemUserControl() });
    }
}