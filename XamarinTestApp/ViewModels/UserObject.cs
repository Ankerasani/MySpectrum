using System;
using SQLite;

namespace XamarinTestApp
{
    public class UserObject
    {   
        [PrimaryKey, AutoIncrement]
        public int userID { get; set; }
        public string userName { get; set; } = "";
        public string passWord { get; set; } = "";
        public string userEmailAddress { get; set; } = "";

        public UserObject() { }

        public UserObject(string userName, string passWord, string userEmailAddress)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.userEmailAddress = userEmailAddress;
        }
    }
}
