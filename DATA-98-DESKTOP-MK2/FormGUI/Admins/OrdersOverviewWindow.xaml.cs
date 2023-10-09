using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
using DATA_98_DESKTOP_MK2.FormGUI.Users;
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

namespace DATA_98_DESKTOP_MK2.FormGUI.Admins
{
    /// <summary>
    /// Interaction logic for OrdersOverviewWindow.xaml
    /// </summary>
    public partial class OrdersOverviewWindow : Window
    {
        User user = null;
        public OrdersOverviewWindow(User user)
        {
            InitializeComponent();
            try
            {
                RefreshPool();
                this.user = user;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-12 => {ex.Message}");
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var db = new OrderContext();
            Order order = gdOrders.SelectedItem as Order;
            if (order != null)
            {
                Order orderSelected = db.Orders.ToList().Where(x => x.Id == order.Id).FirstOrDefault();
                if (orderSelected != default)
                {
                    EditOrderWindow editOrder = new EditOrderWindow(orderSelected, user);
                    Close();
                    editOrder.ShowDialog();
                }
            }
            else MessageBox.Show("E-13 => No order selected!");
        }

        void RefreshPool()
        {
            try
            {
                var db = new OrderContext();
                gdOrders.ItemsSource = db.Orders.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-14 => {ex.Message}");
            }
        }

        private void btnQuestionOrder_Click(object sender, RoutedEventArgs e)
        {
            if (gdOrders.SelectedIndex >= 0)
            {
                if (gdOrders.SelectedIndex < gdOrders.Items.Count)
                {
                    OrderContext db = new OrderContext();
                    db.QuestionOrder(gdOrders.SelectedIndex);
                    db.SaveChanges();
                    db.Dispose();
                    RefreshPool();
                }
                else MessageBox.Show($"E-16 => Order above possible range is selected");
            }
            else MessageBox.Show("E-15 => Order not selected");
        }

        private void btnIdleOrder_Click(object sender, RoutedEventArgs e)
        {
            if (gdOrders.SelectedIndex >= 0)
            {
                if (gdOrders.SelectedIndex >= gdOrders.Items.Count)
                {
                    OrderContext db = new OrderContext();
                    db.IdlizeOrder(gdOrders.SelectedIndex);
                    db.SaveChanges();
                    db.Dispose();
                    RefreshPool();
                }
                else MessageBox.Show("E-18 => Order above possible range is selected");
            }
            else MessageBox.Show("E-17 => Order not selected");
        }

        private void btnAcceptOrder_Click(object sender, RoutedEventArgs e)
        {
            if (gdOrders.SelectedIndex >= 0)
            {
                if (gdOrders.SelectedIndex >= gdOrders.Items.Count)
                {
                    OrderContext db = new OrderContext();
                    db.SetOrderMaster(gdOrders.SelectedIndex, user.ID);
                    db.SaveChanges();
                    db.Dispose();
                    RefreshPool();
                }
                else MessageBox.Show("E-20 => Order above possible range is selected");
            }
            else MessageBox.Show("E-19 => Order not selected");
        }

        private void btnApproveOrder_Click(object sender, RoutedEventArgs e)
        {
            if (gdOrders.SelectedIndex >= 0)
            {
                if (gdOrders.SelectedIndex >= gdOrders.Items.Count)
                {
                    OrderContext db = new OrderContext();
                    db.ApproveOrder(gdOrders.SelectedIndex);
                    db.SaveChanges();
                    db.Dispose();
                    RefreshPool();
                }
                else MessageBox.Show("E-23 => Order above possible range is selected");
            }
            else MessageBox.Show("E-22 => Order not selected");
        }

        private void btnDisapproveOrder_Click(object sender, RoutedEventArgs e)
        {
            if (gdOrders.SelectedIndex >= 0)
            {
                if (gdOrders.SelectedIndex >= gdOrders.Items.Count)
                {
                    OrderContext db = new OrderContext();
                    db.DisapproveOrder(gdOrders.SelectedIndex);
                    db.SaveChanges();
                    db.Dispose();
                    RefreshPool();
                }
                else MessageBox.Show("E-25 => Order above possible range is selected");
            }
            else MessageBox.Show("E-24");
        }
        private void btnMarkDone_Click(object sender, RoutedEventArgs e)
        {
            if (gdOrders.SelectedIndex >= 0)
            {
                if (gdOrders.SelectedIndex >= gdOrders.Items.Count)
                {
                    OrderContext db = new OrderContext();
                    db.MarkDone(gdOrders.SelectedIndex);
                    db.SaveChanges();
                    db.Dispose();
                    RefreshPool();
                }
                else MessageBox.Show("E-27 => Order above possible range is selected");
            }
            else MessageBox.Show("E-26 => Order not selected");
        }
        private void btnGoToProfile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProfileWindow window = new ProfileWindow(user);
                Close();
                window.ShowDialog();
            }
            catch (Exception ex){ MessageBox.Show($"E-28 => {ex.Message}"); }
        }
    }
}