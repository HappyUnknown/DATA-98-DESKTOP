using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
using DATA_98_DESKTOP_MK2.Enumerations;
using DATA_98_DESKTOP_MK2.Extensions;
using DATA_98_DESKTOP_MK2.PageGUI;
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
    /// Interaction logic for EditOrderWindow.xaml
    /// </summary>
    public partial class EditOrderWindow : Window
    {
        User user = null;
        public EditOrderWindow(Order order, User user)
        {
            InitializeComponent();
            try
            {
                OrderPage orderPage = new OrderPage(order);
                fmOrderPage.Navigate(orderPage);
                this.user = user;
            }
            catch (Exception ex) { MessageBox.Show($"E-1 => {ex.Message}"); }
        }
        /// <summary>
        /// SPECIFIED CAST IS NOT VALID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Grid orderForm = (fmOrderPage.Content as OrderPage).FindName("gdOrderBase") as Grid;
                Label lblId = orderForm.FindName("lblId") as Label;
                TextBox tbItemName = orderForm.FindName("tbItemName") as TextBox;
                TextBox tbOrderDesc = orderForm.FindName("tbOrderDesc") as TextBox;
                TextBox tbFaultName = orderForm.FindName("tbFaultName") as TextBox; // NULL by defuault
                TextBox tbDiagDesc = orderForm.FindName("tbDiagDesc") as TextBox;
                TextBox tbFixPrice = orderForm.FindName("tbFixPrice") as TextBox;
                TextBox tbConclusion = orderForm.FindName("tbConclusion") as TextBox;
                ListBox lbApprovalPhase = orderForm.FindName("lbApprovalPhase") as ListBox;
                ListBox lbMediaArray = orderForm.FindName("lbMediaArray") as ListBox;
                ListBox lbMasterID = orderForm.FindName("lbMasterID") as ListBox;
                ListBox lbCustomerID = orderForm.FindName("lbCustomerID") as ListBox;
                try
                {
                    OrderContext orderDB = new OrderContext();
                    UserContext userDB = new UserContext();
                    int masterID = userDB.GetNicknameId(lbMasterID.SelectedValue.ToString()), customerID = userDB.GetNicknameId(lbCustomerID.SelectedValue.ToString());
                    if (lbApprovalPhase.SelectedItem != null && lbMasterID.SelectedValue != null && lbCustomerID.SelectedValue != null)
                        if (masterID > 0 && customerID > 0)
                        {
                            List<Order> orders = orderDB.Orders.ToList();
                            Order orderFound = orders.Where(x => x.Id == int.Parse(lblId.Content.ToString())).FirstOrDefault();
                            string prevname = orderFound.ItemName;
                            orderFound.ItemName = tbItemName.Text;
                            orderFound.OrderDesc = tbOrderDesc.Text;
                            orderFound.FaultName = tbFaultName.Text.ToString();
                            orderFound.DiagDesc = tbDiagDesc.Text;
                            orderFound.FixPrice = int.Parse(tbFixPrice.Text);
                            orderFound.Conclusion = tbConclusion.Text;
                            orderFound.ApprovalPhase = (AgreementState)lbApprovalPhase.SelectedItem;
                            orderFound.MediaArray = lbMediaArray.ItemsAsArray().ToString();
                            orderFound.MasterId = masterID;
                            orderFound.CustomerId = customerID;

                            orderDB.Entry(orderFound).State = System.Data.Entity.EntityState.Modified;
                            orderDB.SaveChanges();

                            MessageBox.Show($"Done changes to ID-{orderFound.Id}:\"{prevname}\"");

                            OrdersOverviewWindow overviewWindow = new OrdersOverviewWindow(user);
                            Close();
                            overviewWindow.ShowDialog();
                        }
                        else
                            MessageBox.Show("E-5 => MasterID or CustomerID cannot be parsed");
                    else
                        MessageBox.Show("E-4 => Some of optional boxes cannot be fulfilled");
                }
                catch (Exception ex) { MessageBox.Show($"E-3 => {ex.Message}"); }
            }
            catch (Exception ex) { MessageBox.Show($"E-2 => {ex.Message}"); }
        }

        private void btnCancelAddOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrdersOverviewWindow pool = new OrdersOverviewWindow(user);
                Close();
                pool.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show($"E-6 => {ex.Message}"); }
        }
    }
}
