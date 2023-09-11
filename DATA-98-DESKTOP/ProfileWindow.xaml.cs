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
    /// Interaction logic for ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        public Master master = new Master();
        public ProfileWindow(Master master = null)
        {
            InitializeComponent();

            this.master = master;
            SetupAccess();

            OrderContext db = new OrderContext();
            try
            {
                gdMasterOrders.ItemsSource = db.GetRespectiveOrders(master);
            }
            catch
            {
                MessageBox.Show("No orders detected for the master!");
            }
            finally
            {
                db.Dispose();
            }
            lblNick.Content = master.Nickname;
        }
        void SetupAccess()
        {
            if (master.RightsType == AccessLevel.Customer)
            {
                btnRegister.IsEnabled = false;
                btnGoToAdmins.IsEnabled = false;
            }
        }
        private void btnGoToRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow(master); // Preliminary to Close() in order to show further
            try
            {
                Close();
                registerWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow signInWindow = new LoginWindow(); // Preliminary to Close() in order to show further
            try
            {
                Close();
                signInWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGoToOrders_Click(object sender, RoutedEventArgs e)
        {
            PoolWindow poolWindow = new PoolWindow(master); // Preliminary to Close() in order to show further
            try
            {
                Close();
                poolWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGoToAdmins_Click(object sender, RoutedEventArgs e)
        {
            Management.MasterManageWindow manageWindow = new Management.MasterManageWindow(master); // Preliminary to Close() in order to show further
            Close();
            manageWindow.ShowDialog();
        }

        private void gdMasterOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ////////////////////////////////////////////
        }

        private void btnGoToAddOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddOrderWindow addWindow = new AddOrderWindow(master);
                Close();
                addWindow.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
