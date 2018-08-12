using System;
using System.Windows;
using System.Windows.Data;

namespace RestWPF.Views
{
    /// <summary>
    /// Interaction logic for FontStyleView.xaml
    /// </summary>
    public partial class FontStyleView : Window
    {
        public FontStyleView()
        {
            InitializeComponent();
            DataContext = Fontproerties;
        }

        FontProperties Fontproerties = new FontProperties();
        private void Arial_Click(object sender, RoutedEventArgs e)          // Assing Arial FontFamily
        {
            // Apply the font body colour to Black
            Fontproerties.ModelBodyColor = "Black";

            // Apply the fontfamily to Arial for Glyphs
            Fontproerties.ModelBodyFontFamily = @"C:\WINDOWS\Fonts\Arial.TTF";

            // Apply the fontfamily to Arial for Textblock
            Fontproerties.FallbackModelBodyFontFamily = "Arial";

            //Fallback Value : http://msdn.microsoft.com/en-us/library/system.windows.media.fontfamily.aspx
            Fontproerties.ModelBodyFontFamily = Fontproerties.ModelBodyFontFamily + "," + Fontproerties.FallbackModelBodyFontFamily;

            // Apply the font size to 30
            Fontproerties.ModelBodyFontSize = 30;

            // Set the display text 
            Fontproerties.ModelBodyText = "This is Arial Text";
        }

        private void Times_Click(object sender, RoutedEventArgs e)           // Assing TimesNewRoman FontFamily
        {
            Fontproerties.ModelBodyColor = "Black";
            Fontproerties.ModelBodyFontFamily = @"C:\WINDOWS\Fonts\Times.TTF";
            Fontproerties.FallbackModelBodyFontFamily = "Times New Roman";
            Fontproerties.ModelBodyFontFamily = Fontproerties.ModelBodyFontFamily + "," + Fontproerties.FallbackModelBodyFontFamily;
            Fontproerties.ModelBodyFontSize = 30;
            Fontproerties.ModelBodyText = "This is TimesNewRoman Text";
        }

        private void Verdana_Click(object sender, RoutedEventArgs e)          // Assing Verdana FontFamily
        {
            Fontproerties.ModelBodyColor = "Black";
            Fontproerties.ModelBodyFontFamily = @"C:\WINDOWS\Fonts\Verdana.TTF";
            Fontproerties.FallbackModelBodyFontFamily = "Verdana";
            Fontproerties.ModelBodyFontFamily = Fontproerties.ModelBodyFontFamily + "," + Fontproerties.FallbackModelBodyFontFamily;
            Fontproerties.ModelBodyFontSize = 30;
            Fontproerties.ModelBodyText = "This is Verdana Text";
        }
    }

    public class FontFamilyConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string result = String.Empty;

            if (parameter.ToString().Equals("Glyps") && value != null)
            {
                string[] words = value.ToString().Split(',');
                result = words[0];
                return result;
            }


            return @"C:\WINDOWS\Fonts\Times.TTF";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }

}
