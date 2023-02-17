using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace JtvDevTools.RestClient;

public class MainViewModel : ObservableObject
{
    public ActionTabViewModel ActionTabViewModel { get; set; }
    public ICommand NewTabCommand { get; private set; }

    public MainViewModel()
    {
        NewTabCommand = new RelayCommand(ExecuteNewTabCommand);
    }

    private void ExecuteNewTabCommand()
    {
        ActionTabViewModel.Tabs.Add(new ActionTabItem() { Parent = ActionTabViewModel, Header = "New", Content = new TabItemUserControl() });
    }
}