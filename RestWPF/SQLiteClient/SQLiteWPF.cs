﻿using SQLite.Net;
using SQLite.Net.Async;
using SQLite.Net.Platform.Win32;
using System;
using System.IO;

namespace RestWPF.SQLiteClient
{
    public class SQLiteWPF : ISQLite
    {
        private SQLiteConnectionWithLock _conn;

        public SQLiteWPF()
        {

        }

        private static string GetDatabasePath()
        {
            const string sqliteFilename = "RestSQLDb.db3";
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, sqliteFilename);
            return path;
        }

        public SQLiteConnection GetConnection()
        {
            var dbPath = GetDatabasePath();

            // Return the synchronous database connection 
            return new SQLiteConnection(new SQLitePlatformWin32(), dbPath);
        }

        public SQLiteAsyncConnection GetAsyncConnection()
        {
            var dbPath = GetDatabasePath();

            var platForm = new SQLitePlatformWin32();

            var connectionFactory = new Func<SQLiteConnectionWithLock>(
                () =>
                {
                    if (_conn == null)
                    {
                        _conn =
                            new SQLiteConnectionWithLock(platForm,
                                new SQLiteConnectionString(dbPath, storeDateTimeAsTicks: true));
                    }
                    return _conn;
                });
            var asyncConnection = new SQLiteAsyncConnection(connectionFactory);

            return asyncConnection;
        }

        public void DeleteDatabase()
        {
            try
            {
                var path = GetDatabasePath();

                try
                {
                    if (_conn != null)
                    {
                        _conn.Close();
                    }
                }
                catch
                {
                    // Best effort close. No need to worry if throws an exception
                }

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                _conn = null;
            }
            catch
            {
                throw;
            }
        }

        public void CloseConnection()
        {
            if (_conn != null)
            {
                _conn.Close();
                _conn.Dispose();
                _conn = null;

                // Must be called as the disposal of the connection is not released until the GC runs.
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

    }

}
