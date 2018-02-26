using System;
using System.Text.RegularExpressions;
using UIKit;

namespace XamarinTestApp
{
    public class BaseClass
    {
        public static void showAlert(string message)
        {
            UIAlertView alert = new UIAlertView()
            {
                Title = "Alert",
                Message = message
            };
            alert.AddButton("OK");
            alert.Show();
        }

        //Password specialcharacters and length validation
        public static bool ValidateTextFieldsText(String text)
        {
            var regex = new Regex(Constants.passwordRegex);
            return regex.IsMatch(text);
        }

        //sequence of characters validation
        public static bool ValidtingSequence(String text)
        {
            var regex = new Regex(Constants.repeatCharactersRegex);
            return regex.IsMatch(text);
        }


        //Email validation regex
        public static bool ValidateEmailWithRegex(String text)
        {
            return Regex.IsMatch(text, Constants.EmailRegex, RegexOptions.IgnoreCase); ;
        }


        //Validate TextField Length

        public static bool ValidteTextFieldLength(UITextField textField, string name)
        {
            if (textField.Text.Length == 0)
            {
                BaseClass.ShowAlertWithGenericMessage(Constants.ErrorMessages.GenericInvalidLength, name);
                return false;
            }
            return true;
        }

        //Validate Email
        public static bool ValidateEmail(UITextField textField, string name)
        {

            if (!BaseClass.ValidateEmailWithRegex(textField.Text))
            {
                BaseClass.ShowAlertWithGenericMessage(Constants.ErrorMessages.GenericInvalidText, name);
                return false;
            }
            return true;
        }

        //Validate Password
        public static bool ValidatePassword(UITextField textField, string name)
        {

            if (!BaseClass.ValidateTextFieldsText(textField.Text))
            {
                BaseClass.ShowAlertWithGenericMessage(Constants.ErrorMessages.GenericInvalidText, name);
                return false;
            }

            //validate sequence
            if (!BaseClass.ValidtingSequence(textField.Text))
            {
                BaseClass.showAlert(Constants.ErrorMessages.SquenceValidataion);

                return false;
            }
            return true;
        }

        //ShowAlertWithGenericMessage
        public  static void ShowAlertWithGenericMessage(string genericText, string name)
        {
            var text = string.Format("{0} {1}", genericText, name);
            BaseClass.showAlert(text);
        }

    }
}
