using DataLayer.Interface;
using DataLayer.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace RestWPF.ViewModel
{
    public abstract class BaseViewModel : ViewModelBase
    {
        #region Properties

        public IAccountService _accountService { get; set; }

        #endregion

        #region Constructor

        public BaseViewModel()
        {
            if (!SimpleIoc.Default.IsRegistered<IAccountService>())
                SimpleIoc.Default.Register<IAccountService, AccountService>();
            _accountService = SimpleIoc.Default.GetInstance<IAccountService>();
        }

        #endregion
    }

}
