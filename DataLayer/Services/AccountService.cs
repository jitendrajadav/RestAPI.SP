using System.Threading.Tasks;
using DataLayer.Common;
using DataLayer.Interface;

namespace DataLayer.Services
{
    public class AccountService : IAccountService
    {
        public async Task<string> GetCategoryAsync(int id)
        {
            string v = await Helper.ExecutePostCall<string, int>(id, Configuration.GetCategoryUrl);
            return v;
        }
    }
}
