using System.Collections.ObjectModel;
using System.Windows;

namespace RestWPF.Views
{
    /// <summary>
    /// Interaction logic for DynamicMenu.xaml
    /// </summary>
    public partial class DynamicMenuView : Window
    {
        public DynamicMenuView()
        {
            InitializeComponent();
            DataContext = new MyThemesViewModel();
        }

        public class MyThemesViewModel
        {
            public ObservableCollection<MyData> Themes { get; set; } = new ObservableCollection<MyData>();

            public MyThemesViewModel()
            {
                Themes.Add(new MyData("a"));
                Themes.Add(new MyData("b"));
                Themes.Add(new MyData("c"));
                Themes.Add(new MyData("d"));
            }
        }
    }

    public class MyData
    {
        public ObservableCollection<MyData2> More { get; } = new ObservableCollection<MyData2>() { new MyData2("h") };

        public MyData(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
    public class MyData2
    {
        public MyData2(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}

