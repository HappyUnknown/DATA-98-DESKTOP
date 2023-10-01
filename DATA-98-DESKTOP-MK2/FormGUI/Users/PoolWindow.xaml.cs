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
            
            RefreshPool();
            this.user = user;
        }

        private void btnGoToProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow window = new ProfileWindow(user);
            Close();
            window.ShowDialog();
        }

        void RefreshPool()
        {
            var db = new OrderContext();
            try
            {
                gdOrderPool.ItemsSource = db.Orders.ToList();
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTakeOrder_Click(object sender, RoutedEventArgs e)
        {
            if (gdOrderPool.SelectedIndex >= 0)
            {
                if (gdOrderPool.SelectedIndex < gdOrderPool.Items.Count)
                {
                    OrderContext db = new OrderContext();
                    db.SetOrderMaster(gdOrderPool.SelectedIndex, user.ID);
                    db.SaveChanges();
                    db.Dispose();
                    RefreshPool();
                }
                else MessageBox.Show("Order above possible range is selected");
            }
            else MessageBox.Show("Order not selected");
        }
    }
}
