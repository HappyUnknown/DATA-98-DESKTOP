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

            OrderContext orderDb = new OrderContext();
            try
            {
                lblId.Content = orderDb.NextId().ToString();
            }
            catch (Exception ex) { MessageBox.Show($"Cannot load masters: {ex.Message}"); }
            finally { orderDb.Dispose(); }

            MasterContext masterDb = new MasterContext();
            try
            {
                lbMasterID.ItemsSource = masterDb.Masters.Select(x => x.Nickname).ToList();
            }
            catch (Exception ex) { MessageBox.Show($"Cannot get master nicknames: {ex.Message}"); }
            finally { masterDb.Dispose(); }
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderContext orderDb = new OrderContext();
            MasterContext masterDb = new MasterContext();
            int userId = masterDb.GetNicknameId(lbMasterID.SelectedValue.ToString());
            if (userId > 0)
            {
                Order order = new Order()
                {
                    ApprovalPhase = (AgreementState)int.Parse(tbApprovalPhase.Text),
                    Conclusion = tbConclusion.Text,
                    CustomerId = int.Parse(lbCustomerID.SelectedValue.ToString()),
                    DiagDesc = tbDiagDesc.Text,
                    FaultType = (Malfunction)int.Parse(tbFaultType.Text),
                    FixPrice = int.Parse(tbFixPrice.Text),
                    MasterId =  userId,
                    MediaArray = tbMediaArray.Text,
                    OrderDesc = tbOrderDesc.Text
                };
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
                orderDb.Dispose();
            }
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
