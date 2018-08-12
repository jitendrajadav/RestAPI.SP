using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace RestWPF.Views
{
    /// <summary>
    /// Interaction logic for DynamicMenu.xaml
    /// </summary>
    public partial class DynamicMenuView : Window
    {
        public ObservableCollection<MyData> Themes { get; set; } = new ObservableCollection<MyData>();
        MenuItem menuItem = null;

        public DynamicMenuView()
        {
            InitializeComponent();
            loadMenuItem();
        }

        private void loadMenuItem()
        {
            Themes.Add(new MyData("a"));
            Themes.Add(new MyData("b"));
            Themes.Add(new MyData("c"));
            Themes.Add(new MyData("d"));

            for (int i = 0; i < 5; i++)
            {
                menuItem = new MenuItem
                {
                    Header = "Menu" + i,
                    ItemsSource = Themes,
                    ItemContainerStyle = (Style)TryFindResource("ThemeMenuItemStyle")
                };
                myMenu.Items.Add(menuItem);
                menuItem.Click += MenuItem_Click;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
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

