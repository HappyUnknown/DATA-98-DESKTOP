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

            try
            {
                //(formGrid.FindName("tbOrderDesc") as TextBox).Visibility = Visibility.Collapsed;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderContext orderDb = new OrderContext();
                MasterContext masterDb = new MasterContext();
                Grid formGrid = (fmOrderPage.Content as OrderBasePage).FindName("gdOrderBase") as Grid;
                ListBox lbMasterId = formGrid.FindName("lbMasterID") as ListBox;
                ListBox lbApprovalPhase = formGrid.FindName("lbApprovalPhase") as ListBox;
                TextBox tbConclusion = formGrid.FindName("tbConclusion") as TextBox;
                ListBox lbCustomerID = formGrid.FindName("lbCustomerID") as ListBox;
                TextBox tbDiagDesc = formGrid.FindName("tbDiagDesc") as TextBox;
                ListBox tbFaultType = formGrid.FindName("lbFaultType") as ListBox;
                TextBox tbFixPrice = formGrid.FindName("tbFixPrice") as TextBox;
                TextBox tbMediaArray = formGrid.FindName("tbMediaArray") as TextBox;
                TextBox tbOrderDesc = formGrid.FindName("tbOrderDesc") as TextBox;
                try
                {
                    int userId = masterDb.GetNicknameId(lbMasterId.SelectedValue.ToString());
                    int customerId = masterDb.GetNicknameId(lbCustomerID.SelectedValue.ToString());
                    try
                    {
                        if (userId > 0)
                        {
                            Order order = new Order()
                            {
                                ApprovalPhase = (AgreementState)lbApprovalPhase.SelectedValue,
                                Conclusion = tbConclusion.Text,
                                CustomerId = customerId,
                                DiagDesc = tbDiagDesc.Text,
                                FaultType = (Malfunction)tbFaultType.SelectedValue,
                                FixPrice = int.Parse(tbFixPrice.Text),
                                MasterId = userId,
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
                    catch (Exception ex) { MessageBox.Show($"Getting UID: {ex.Message}"); }
                }
                catch (Exception ex) { MessageBox.Show($"Frame elements' unparsing: {ex.Message}"); }
            }
            catch (Exception ex) { MessageBox.Show($"Frame unparsing: {ex.Message}"); }
        }
        private void btnCancelAddOrder_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow window = new ProfileWindow(master);
            Close();
            window.ShowDialog();
        }
    }
}
