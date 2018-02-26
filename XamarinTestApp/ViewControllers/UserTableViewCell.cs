using Foundation;
using System;
using UIKit;

namespace XamarinTestApp
{
    public partial class UserTableViewCell : UITableViewCell
    {
        public UserTableViewCell(IntPtr handle) : base(handle) { }
        internal void updateCellData(UserObject user)
        {
            UserNameLabel.Text = user.userName;
            EmailAddressLabel.Text = user.userEmailAddress;
        }
    }
}