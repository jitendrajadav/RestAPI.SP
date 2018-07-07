using CrystalDecisions.CrystalReports.Engine;
using System.Windows;
using System.Linq;
using RestWPF.SQLiteClient;
using RestWPF.Model;

namespace RestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch (System.Exception ex)
            {

                throw;
            }
            Loaded += MainWindow_LoadedAsync;
        }

        private async void MainWindow_LoadedAsync(object sender, RoutedEventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("../../CategoryReport.rpt");
            using (FruitBytesEntities db = new FruitBytesEntities())
            {
                var query = from t in db.CATEGORies select new { t.CAT_CODE, t.CAT_NAM };
                reportDocument.SetDataSource(from t in db.CATEGORies select new { t.CAT_NAM, t.CAT_CODE });
            }
            crViewer.ViewerCore.ReportSource = reportDocument;

            await SqliteServiceClient.Db.InsertAsync(new Address { Addreses= "Mira Road", FName="Jitnedra", LName="Jadav", Phone="9702655927", Pin="401107" });

            var InsertedData = await SqliteServiceClient.Db.Table<Address>().ToListAsync();

        }

    }
}
