using System.ComponentModel;

namespace RestWPF
{
    public class FontProperties : INotifyPropertyChanged
    {
        #region Model Body Font Properties

        string modelBodyFontFamily;
        public string ModelBodyFontFamily
        {
            get
            {
                return modelBodyFontFamily;
            }
            set
            {
                modelBodyFontFamily = value;
                OnPropertyChanged("ModelBodyFontFamily");
            }
        }

        string modelBodyColor;
        public string ModelBodyColor
        {
            get
            {
                return modelBodyColor;
            }
            set
            {
                modelBodyColor = value;
                OnPropertyChanged("ModelBodyColor");
            }
        }

        double modelBodyFontSize;
        public double ModelBodyFontSize
        {
            get
            {
                return modelBodyFontSize;
            }
            set
            {
                modelBodyFontSize = value;
                OnPropertyChanged("ModelBodyFontSize");
            }
        }

        string modelBodyText = "Test Data";
        public string ModelBodyText
        {
            get
            {
                return modelBodyText;
            }
            set
            {
                modelBodyText = value;
                OnPropertyChanged("ModelBodyText");
            }
        }

        #endregion

        #region Model Body Font Properties Fall Back

        string fallbackmodelBodyFontFamily;
        public string FallbackModelBodyFontFamily
        {
            get
            {
                return fallbackmodelBodyFontFamily;
            }
            set
            {
                fallbackmodelBodyFontFamily = value;
                OnPropertyChanged("FallbackModelBodyFontFamily");
            }
        }
        #endregion


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
