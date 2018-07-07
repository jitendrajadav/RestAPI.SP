using CrystalDecisions.CrystalReports.Engine;
using System.Windows;
using System.Linq;

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
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("../../CategoryReport.rpt");
            using (FruitBytesEntities db = new FruitBytesEntities())
            {
                var query = from t in db.CATEGORies select new { t.CAT_CODE, t.CAT_NAM };
                reportDocument.SetDataSource(from t in db.CATEGORies select new { t.CAT_NAM, t.CAT_CODE });
            }
            crViewer.ViewerCore.ReportSource = reportDocument;

        }
    }
}
