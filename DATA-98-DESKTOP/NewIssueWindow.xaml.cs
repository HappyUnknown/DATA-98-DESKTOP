using DATA_98_DESKTOP.Class;
using DATA_98_DESKTOP.Context;
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

namespace DATA_98_DESKTOP
{
    /// <summary>
    /// Interaction logic for NewIssueWindow.xaml
    /// </summary>
    public partial class NewIssueWindow : Window
    {
        Master master = new Master();
        public NewIssueWindow(Master master)
        {
            InitializeComponent();

            this.master = master;
        }

        private void btnRedeemIssue_Click(object sender, RoutedEventArgs e)
        {
            OrderContext db = new OrderContext();
            Order order = new Order() { CustomerId = master.Id, OrderDesc = tbOrderDesc.Text };
            db.Orders.Add(order);
            db.SaveChanges();
            ProfileWindow profile = new ProfileWindow(master);
            Close();
            profile.ShowDialog();
        }
    }
}
