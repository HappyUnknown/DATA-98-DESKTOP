using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
using DATA_98_DESKTOP_MK2.FormGUI.Admins;
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
    /// Interaction logic for ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        User user;
        public ProfileWindow(User user)
        {
            InitializeComponent();
            try
            {

                this.user = user;

                var db = new OrderContext();
                if (user.RightsType == AccessLevel.Customer)
                    gdMasterOrders.ItemsSource = db.Orders.ToList().Where(x => x.CustomerId == user.ID);
                else
                    gdMasterOrders.ItemsSource = db.Orders.ToList().Where(x => x.MasterId == user.ID);

                db.Dispose();
            }
            catch (Exception ex) { MessageBox.Show($"E-44 => {ex.Message}"); }
        }

        private void btnNewIssue_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NewIssueWindow issueWindow = new NewIssueWindow(user);
                Close();
                issueWindow.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show($"E-45 => {ex.Message}"); }
        }

        private void btnGoToOrders_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrdersOverviewWindow overview = new OrdersOverviewWindow(user);
                Close();
                overview.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show($"E-46 => {ex.Message}"); }
        }

        private void btnGoToAddOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NewOrderWindow orderWindow = new NewOrderWindow(user); // Preliminary to Close() in order to show further
                Close();
                orderWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-47 => {ex.Message}");
            }
        }

        private void btnGoToRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RegisterWindow registerWindow = new RegisterWindow(user); // Preliminary to Close() in order to show further
                Close();
                registerWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-48 => {ex.Message}");
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoginWindow signInWindow = new LoginWindow(); // Preliminary to Close() in order to show further
                Close();
                signInWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-49 => {ex.Message}");
            }
        }

        private void btnGoToAdmins_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UsersOverviewWindow overviewWindow = new UsersOverviewWindow(user);
                Close();
                overviewWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-50 => {ex.Message}");
            }
        }

        private void btnGoToPool_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PoolWindow pool = new PoolWindow(user);
                Close();
                pool.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show($"E-51 => {ex.Message}"); }
        }
        void RefreshPool()
        {
            try
            {
                var db = new OrderContext();
                if (user.RightsType == AccessLevel.Customer)
                    gdMasterOrders.ItemsSource = db.Orders.ToList().Where(x => x.CustomerId == x.CustomerId);
                else
                    gdMasterOrders.ItemsSource = db.Orders.ToList().Where(x => x.MasterId == x.MasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-52 => {ex.Message}");
            }
        }

        private void btnRejectOrder_Click(object sender, RoutedEventArgs e)
        {
            if (gdMasterOrders.SelectedIndex >= 0)
            {
                if (gdMasterOrders.SelectedIndex < gdMasterOrders.Items.Count)
                {
                    OrderContext db = new OrderContext();
                    db.QuestionOrder(gdMasterOrders.SelectedIndex);
                    db.SaveChanges();
                    db.Dispose();
                    RefreshPool();
                }
                else MessageBox.Show("E-54 => Master order is out of range");
            }
            else MessageBox.Show("E-53 => Master's order is not selected");
        }
    }
}
