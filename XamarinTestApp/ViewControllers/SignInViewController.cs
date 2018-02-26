using Foundation;
using System;
using UIKit;
using System.Text.RegularExpressions;

namespace XamarinTestApp
{
    public partial class SignInViewController : UITableViewController
    {
        bool passWordBool = true;
        public SignInViewController(IntPtr handle) : base(handle) { }

        partial void ShowButton_TouchUpInside(UIButton sender)
        {
            passWordBool = !passWordBool;
            string titleText = passWordBool ? "Show" : "Hide";
            showButton.SetTitle(titleText, UIControlState.Normal);
            passWordTextField.SecureTextEntry = passWordBool;
        }

        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            if (segueIdentifier != "ListScreenSeague")
                return true;

            if (ValidateTextFields())
            {
                var userData = SQLiteDBHelper.Instance.GetUserData();
                foreach (UserObject user in userData)
                {
                    if (user.userName == userNameTextField.Text && user.passWord == passWordTextField.Text)
                    {
                        return true;
                    }
                }
                BaseClass.showAlert(Constants.ErrorMessages.NoUser);
            }
            return false;
        }

        //Validate textfields and show alert
        private bool ValidateTextFields()
        {
            return ((BaseClass.ValidteTextFieldLength(userNameTextField, "UserName")) &&
                    (BaseClass.ValidteTextFieldLength(passWordTextField, "Password")));

        }

    }
}