using System;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace XamarinTestApp
{
    public sealed class SQLiteDBHelper
    {
        private static string dataBaseName = "SQLitedb.db3";
        private static string dataBasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), dataBaseName);

        private static readonly Lazy<SQLiteDBHelper> lazy =
            new Lazy<SQLiteDBHelper>(() => new SQLiteDBHelper());

        public static SQLiteDBHelper Instance { get { return lazy.Value; } }

        // singleton Instance and Creating Database
        private SQLiteDBHelper()
        {
            using (var dataBase = new SQLite.SQLiteConnection(dataBasePath))
            {
                dataBase.CreateTable<UserObject>();
            }
        }

        // Returns the all users 
        public List<UserObject> GetUserData()
        {
            List<UserObject> userList = new List<UserObject>();
            using (var SQLiteConnection = new SQLite.SQLiteConnection(dataBasePath))
            {
                userList = SQLiteConnection.Table<UserObject>().ToList();
            }
            return userList;
        }


        // Inserting new user
        public bool AddUserObject<T>(ref T data)
        {
            using (var dataBase = new SQLite.SQLiteConnection(dataBasePath))
            {
                if (dataBase.Insert(data) != 0)
                {
                    return true;
                }
                return false;
            }
        }

        // Deletes user data and returns success bool
        public static bool DeleteUserData()
        {
            using (var SQLiteConnection = new SQLite.SQLiteConnection(dataBasePath))
            {
                if (SQLiteConnection.DeleteAll<UserObject>() != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
