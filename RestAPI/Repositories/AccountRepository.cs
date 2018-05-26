using RestAPI.Interface;

namespace RestAPI.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public string GetCategory(int id)
        {
            string strResult = string.Empty;
            FruitBytesEntities fruitBytesEntities = new FruitBytesEntities();
            var enumrableResult = fruitBytesEntities.uspGetCategory("FRUITS", id);
            foreach (var item in enumrableResult)
                strResult = item;
            return strResult;
        }
    }
}
