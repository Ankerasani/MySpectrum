using Foundation;
using System;
using UIKit;
using System.Text.RegularExpressions;

namespace XamarinTestApp
{
    public partial class SignUpViewController : UITableViewController
    {
        bool passWordBool = true;
        public SignUpViewController(IntPtr handle) : base(handle) { }

        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            if (segueIdentifier != "ListViewController")
                return true;
            
            return ValidateTextFields() && CheckUserNameAvailability() &&  AddNewUser();
        }


        private bool AddNewUser()
        {
            UserObject user = new UserObject(userName.Text, passWord.Text, emailAddress.Text);
            if (SQLiteDBHelper.Instance.AddUserObject(ref user))
            {
                BaseClass.showAlert(Constants.ErrorMessages.SuccessfullyAdded);
                return true;
            }
            else
            {
                BaseClass.showAlert(Constants.ErrorMessages.UnableToAddUser);
                return false;
            }
        }


        private bool CheckUserNameAvailability()
        {
            var userData = SQLiteDBHelper.Instance.GetUserData();
            foreach (UserObject user in userData)
            {
                //checking user already exists in DB 
                if (user.userName == userName.Text)
                {
                    BaseClass.showAlert(Constants.ErrorMessages.DuplicateUser);
                    return false;
                }
            } 
            return true;
        }


        partial void ShowButton_TouchUpInside(UIButton sender)
        {
            passWordBool = !passWordBool;
            string titleText = passWordBool ? "Show" : "Hide";
            showButton.SetTitle(titleText, UIControlState.Normal);
            passWord.SecureTextEntry = passWordBool;
        }


        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.SetTextFields();
        }

        private void SetTextFields()
        {
            userName.Text = "";
            passWord.Text = "";
            emailAddress.Text = "";
            passWord.ShouldChangeCharacters = (textField, range, replacementString) =>
            {
                var newLength = textField.Text.Length + replacementString.Length - range.Length;
                return newLength <= 12;
            };
        }

        private bool ValidateTextFields()
        {
            return ((BaseClass.ValidteTextFieldLength(userName, "UserName")) &&
                    (BaseClass.ValidteTextFieldLength(passWord, "Password")) &&
                    (BaseClass.ValidteTextFieldLength(emailAddress, "Email Address")) &&
                    (BaseClass.ValidatePassword(passWord, "password")) &&
                    (BaseClass.ValidateEmail(emailAddress, "Email Address")));
        }

    }
}