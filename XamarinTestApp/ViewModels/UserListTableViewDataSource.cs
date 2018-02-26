using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace XamarinTestApp
{
    public class UserListTableViewDataSource: UITableViewDataSource
    {
        private List<UserObject> userObjects = new List<UserObject>();
       
        public UserListTableViewDataSource()
        {
            GetUserData();
        }

        private void GetUserData()
        {
            userObjects = SQLiteDBHelper.Instance.GetUserData();
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return userObjects.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            var cell = (UserTableViewCell)tableView.DequeueReusableCell("cell", indexPath);
            var user = userObjects[indexPath.Row] as UserObject;
            cell.updateCellData(user);
            return cell;
        }
    }
}
