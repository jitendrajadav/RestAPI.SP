using RestAPI.Interface;
using System.Web.Http;

namespace RestAPI.Controllers
{
    public class AccountController : ApiController
    {
        #region Properties

        IAccountRepository _account;

        #endregion

        #region Constructor

        public AccountController(IAccountRepository account) => _account = account;

        #endregion

        #region Methods

        [HttpPost]
        public string GetCategory(int id) => _account.GetCategory(id);

        #endregion
    }
}