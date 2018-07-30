using System.Collections.Generic;
using System.Windows.Input;

namespace RestWPF.ViewModel
{
    public class DynamicMenuViewModel 
    {
        public string Text { get; set; }

        public IList<DynamicMenuViewModel> MenuItems { get; private set; }

        public DynamicMenuViewModel()
        {
            MenuItems = new List<DynamicMenuViewModel>();

        }
    }
}
