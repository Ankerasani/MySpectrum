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
    [Register ("SignUpViewController")]
    partial class SignUpViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField emailAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField passWord { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton showButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton signUpButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField userName { get; set; }

        [Action ("ShowButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ShowButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (emailAddress != null) {
                emailAddress.Dispose ();
                emailAddress = null;
            }

            if (passWord != null) {
                passWord.Dispose ();
                passWord = null;
            }

            if (showButton != null) {
                showButton.Dispose ();
                showButton = null;
            }

            if (signUpButton != null) {
                signUpButton.Dispose ();
                signUpButton = null;
            }

            if (userName != null) {
                userName.Dispose ();
                userName = null;
            }
        }
    }
}