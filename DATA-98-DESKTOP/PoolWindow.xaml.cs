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
    /// Interaction logic for PoolWindow.xaml
    /// </summary>
    public partial class PoolWindow : Window
    {
        Master master = new Master();
        public PoolWindow(Master master)
        {
            InitializeComponent();

            this.master = master;
            SetupAccess();
            RefreshPool();
        }

        void SetupAccess()
        {
            if (master.RightsType == AccessLevel.Master)
            {
                btnIdleOrder.IsEnabled = false;
                btnApproveOrder.IsEnabled = false;
                btnDisapproveOrder.IsEnabled = false;
            }
        }

        void RefreshPool()
        {
            var db = new OrderContext();
            try
            {
                //    db.Orders.Add(new Order() { Id = 1, ApprovalPhase = AgreementState.Approved, Conclusion = "Allshorrific", CustomerId = 1, DiagDesc = "Allsbad", FaultType = Malfunction.CantEnable, FixPrice = 123, MasterId = 1, MediaArray = "https://localhost", OrderDesc = "Fix it tomorrow" });

                //    db.SaveChanges();
                gdOrders.ItemsSource = db.Orders.ToList();

                //    Order obj = new Order();
                //    db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGoToProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow(master);
            try
            {
                Close();
                profileWindow.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAcceptOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderContext db = new OrderContext();
            db.SetOrderMaster(gdOrders.SelectedIndex, master.Id);
            db.SaveChanges();
            db.Dispose();
            RefreshPool();
        }

        private void btnApproveOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderContext db = new OrderContext();
            db.ApproveOrder(gdOrders.SelectedIndex);
            db.SaveChanges();
            db.Dispose();
            RefreshPool();
        }

        private void btnDisapproveOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderContext db = new OrderContext();
            db.DisapproveOrder(gdOrders.SelectedIndex);
            db.SaveChanges();
            db.Dispose();
            RefreshPool();
        }

        private void btnMarkDone_Click(object sender, RoutedEventArgs e)
        {
            OrderContext db = new OrderContext();
            db.MarkDone(gdOrders.SelectedIndex);
            db.SaveChanges();
            db.Dispose();
            RefreshPool();
        }

        private void btnIdleOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderContext db = new OrderContext();
            db.IdlizeOrder(gdOrders.SelectedIndex);
            db.SaveChanges();
            db.Dispose();
            RefreshPool();
        }

        private void btnQuestionOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderContext db = new OrderContext();
            db.QuestionOrder(gdOrders.SelectedIndex);
            db.SaveChanges();
            db.Dispose();
            RefreshPool();
        }
    }
}
