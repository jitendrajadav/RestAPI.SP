using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IAccountService
    {
        Task<string> GetCategoryAsync(int id);

    }

}
