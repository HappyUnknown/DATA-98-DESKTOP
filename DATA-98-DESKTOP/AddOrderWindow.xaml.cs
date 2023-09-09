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
    /// Interaction logic for AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        Master master = new Master();
        public AddOrderWindow(Master master = null)
        {
            InitializeComponent();

            this.master = master;

            OrderContext db = new OrderContext();
            try
            {
                lblId.Content = db.NextId().ToString();
            }
            catch (Exception ex) { MessageBox.Show($"Cannot load masters: {ex.Message}"); }
            finally { db.Dispose(); }
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            OrderContext db = new OrderContext();
            Order order = new Order()
            {
                ApprovalPhase = (AgreementState)int.Parse(tbApprovalPhase.Text),
                Conclusion = tbConclusion.Text,
                CustomerId = int.Parse(lbCustomerID.SelectedValue.ToString()),
                DiagDesc = tbDiagDesc.Text,
                FaultType = (Malfunction)int.Parse(tbFaultType.Text),
                FixPrice = int.Parse(tbFixPrice.Text),
                MasterId = int.Parse(lbMasterID.SelectedValue.ToString()),
                MediaArray = tbMediaArray.Text,
                OrderDesc = tbOrderDesc.Text
            };
            db.Orders.Add(order);
            db.SaveChanges();
            db.Dispose();

            ProfileWindow window = new ProfileWindow(master);
            Close();
            window.ShowDialog();
        }

        private void btnCancelAddOrder_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow window = new ProfileWindow(master);
            Close();
            window.ShowDialog();
        }
    }
}
