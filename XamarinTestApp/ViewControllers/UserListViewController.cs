using Foundation;
using System;
using UIKit;

namespace XamarinTestApp
{
    public partial class UserListViewController : UITableViewController
    {
        public UserListTableViewDataSource DataSource
        {
            get { return TableView.DataSource as UserListTableViewDataSource; }
        }

        public UserListViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            TableView.RegisterClassForCellReuse(typeof(UserTableViewCell), "UserTableViewCell");
            TableView.DataSource = new UserListTableViewDataSource();
            TableView.ReloadData();
        }
    }
}