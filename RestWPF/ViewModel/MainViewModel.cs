using System;

namespace RestWPF.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : BaseViewModel
    {

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            InitializeDataAsync();
        }

        private async void InitializeDataAsync()
        {
            try
            {
                var category = await _accountService.GetCategoryAsync(1);
            }
            catch (Exception ex)
            {

            }
        }
    }
}