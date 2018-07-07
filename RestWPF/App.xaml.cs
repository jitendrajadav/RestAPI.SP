using GalaSoft.MvvmLight.Ioc;
using RestWPF.SQLiteClient;
using System.Windows;

namespace RestWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            SimpleIoc.Default.Register<ISQLite, SQLiteWPF>();
            SqliteServiceClient.Instance.CreateDbIfNotExist();
        }
    }
}
