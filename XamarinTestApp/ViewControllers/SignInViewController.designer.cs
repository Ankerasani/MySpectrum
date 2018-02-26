// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinTestApp
{
    [Register ("SignInViewController")]
    partial class SignInViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField passWordTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton showButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton signInButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField userNameTextField { get; set; }

        [Action ("didSelectSignInButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void didSelectSignInButton (UIKit.UIButton sender);

        [Action ("ShowButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ShowButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (passWordTextField != null) {
                passWordTextField.Dispose ();
                passWordTextField = null;
            }

            if (showButton != null) {
                showButton.Dispose ();
                showButton = null;
            }

            if (signInButton != null) {
                signInButton.Dispose ();
                signInButton = null;
            }

            if (userNameTextField != null) {
                userNameTextField.Dispose ();
                userNameTextField = null;
            }
        }
    }
}