using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace XamarinTestApp
{
    public class Constants
    {
        public const string EmailRegex = "^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@"
            + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$";
        public const String passwordRegex = @"^(?=.*\d)[a-zA-Z0-9@]{5,12}$";
        public const String repeatCharactersRegex = @"^(?!.*(.+)\1\1)";


        public static class TextFieldConstants
        {
            public const int Max_Lenth = 12;
        }

        public static class ErrorMessages
        {
            public const string InvalidUser = "Invalid Username and Password";
            public const string NoUser = "User Doesn't exist in Our system, Please Create new account";
            public const string DuplicateUser = "This username already exist in our system, Please use different username";
            public const string SuccessfullyAdded = "User added successfully";
            public const string UnableToAddUser = "Sorry, Unable add new user";
            public const string ValidtityError = "Please enter valid Details";
            public const string InvalidLength = "Please enter Username and Password";
            public const string GenericInvalidLength = "Please enter";
            public const string GenericInvalidText = "Please enter valid";
            public const string SquenceValidataion = "Password should not contain sequence of characters";
        }
    }
}
