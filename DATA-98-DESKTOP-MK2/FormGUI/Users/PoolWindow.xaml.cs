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
    /// Interaction logic for PoolWindow.xaml
    /// </summary>
    public partial class PoolWindow : Window
    {
        User user = null;
        public PoolWindow(User user = null)
        {
            InitializeComponent();
            try
            {
                RefreshPool();
                this.user = user;
            }
            catch (Exception ex) { MessageBox.Show($"E-39 => {ex.Message}"); }
        }

        private void btnGoToProfile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProfileWindow window = new ProfileWindow(user);
                Close();
                window.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show($"E-40 => {ex.Message}"); }
        }

        void RefreshPool()
        {
            var db = new OrderContext();
            try
            {
                gdOrderPool.ItemsSource = db.Orders.Where(x => x.MasterId == Constants.AppConstants.FREE_TASK_MASTER_ID).ToList();
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-41 => {ex.Message}");
            }
        }

        private void btnTakeOrder_Click(object sender, RoutedEventArgs e)
        {
            if (gdOrderPool.SelectedIndex >= 0)
            {
                if (gdOrderPool.SelectedIndex < gdOrderPool.Items.Count)
                {
                    OrderContext db = new OrderContext();
                    List<Order> orders = db.Orders.ToList();
                    Order orderFound = orders.Where(x => x.Id == orders[gdOrderPool.SelectedIndex].Id).FirstOrDefault();
                    //db.SetOrderMaster(gdOrderPool.SelectedIndex, user.ID);
                    orders[gdOrderPool.SelectedIndex].MasterId = user.ID;
                    MessageBox.Show(orders[gdOrderPool.SelectedIndex].MasterId.ToString());
                    db.Entry(orderFound).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    db.Dispose();
                    RefreshPool();
                }
                else MessageBox.Show("E-43 => Order above possible range is selected");
            }
            else MessageBox.Show("E-42 => Order not selected");
        }
    }
}
