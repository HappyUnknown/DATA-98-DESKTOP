using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DATA_98_DESKTOP_MK2.FormGUI.Users
{
    /// <summary>
    /// Interaction logic for NewIssueWindow.xaml
    /// </summary>
    public partial class NewIssueWindow : Window
    {
        User user = null;
        public NewIssueWindow(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void btnRedeemIssue_Click(object sender, RoutedEventArgs e)
        {
            OrderContext db = new OrderContext();
            Order order = new Order() { CustomerId = user.ID, OrderDesc = tbOrderDesc.Text };
            db.Orders.Add(order);
            db.SaveChanges();
            db.Dispose();

            ProfileWindow profile = new ProfileWindow(user);
            Close();
            profile.ShowDialog();
        }

        private void btnCancelRedeem_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profile = new ProfileWindow(user);
            Close();
            profile.ShowDialog();
        }
    }
}
