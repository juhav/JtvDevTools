using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JtvDevTools.RestClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var vm = new MainViewModel();
            DataContext = vm;
            var vmd = new ActionTabViewModel();
            vm.ActionTabViewModel = vmd;
            // Bind the xaml TabControl to view model tabs
            //tabControl.ItemsSource = vmd.Tabs;
            // Populate the view model tabs
            var items = new ObservableCollection<TabItemViewModel>();

            items.Add(new TabItemViewModel());
            items.Add(new TabItemViewModel());
            items.Add(new TabItemViewModel());
            items.Add(new TabItemViewModel());
            items.Add(new TabItemViewModel());
            items.Add(new TabItemViewModel());
            items.Add(new TabItemViewModel());

            TabItemsControl.ItemsSource = items;
            vmd.Populate();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TabItemsScroller.LineLeft();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TabItemsScroller.LineRight();

        }
    }
}
