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
    [Register ("UserTableViewCell")]
    partial class UserTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel EmailAddressLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel UserNameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (EmailAddressLabel != null) {
                EmailAddressLabel.Dispose ();
                EmailAddressLabel = null;
            }

            if (UserNameLabel != null) {
                UserNameLabel.Dispose ();
                UserNameLabel = null;
            }
        }
    }
}