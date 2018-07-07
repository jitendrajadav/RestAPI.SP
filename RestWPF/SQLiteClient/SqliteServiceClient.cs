using GalaSoft.MvvmLight.Ioc;
using RestWPF.Model;
using SQLite.Net.Async;
using System;
using System.Threading;

namespace RestWPF.SQLiteClient
{
    public class SqliteServiceClient : ISqliteServiceClient
    {
        private static readonly Lazy<SqliteServiceClient> Lazy =
          new Lazy<SqliteServiceClient>(() => new SqliteServiceClient());

        public static ISqliteServiceClient Instance => Lazy.Value;

        private SqliteServiceClient()
        {
        }

        private static SQLiteAsyncConnection _dbConnection;
        public static SQLiteAsyncConnection Db
        {
            get
            {
                if (_dbConnection == null)
                {
                    LazyInitializer.EnsureInitialized(ref _dbConnection, SimpleIoc.Default.GetInstance<ISQLite>().GetAsyncConnection);
                }

                return _dbConnection;
            }
        }

        public async void CreateDbIfNotExist()
        {
            await Db.CreateTableAsync<Address>();
        }
    }

}
