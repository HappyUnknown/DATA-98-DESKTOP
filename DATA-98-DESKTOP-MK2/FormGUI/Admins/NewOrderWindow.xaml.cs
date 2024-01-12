using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
using DATA_98_DESKTOP_MK2.Extensions;
using DATA_98_DESKTOP_MK2.FormGUI.Users;
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
    /// Interaction logic for NewOrderWindow.xaml
    /// </summary>
    public partial class NewOrderWindow : Window
    {
        User user;
        public NewOrderWindow(User user)
        {
            InitializeComponent();
            try
            {

                this.user = user;
                OrderPage page = new OrderPage();
                fmOrderPage.Navigate(page);
            }
            catch (Exception ex) { MessageBox.Show($"E-7 => {ex.Message}"); }
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderContext orderDb = new OrderContext();
                UserContext userDb = new UserContext();

                Grid formGrid = (fmOrderPage.Content as OrderPage).FindName("gdOrderBase") as Grid;
                ListBox lbMasterID = formGrid.FindName("lbMasterID") as ListBox;
                TextBox tbItemName = formGrid.FindName("tbItemName") as TextBox;
                ListBox lbApprovalPhase = formGrid.FindName("lbApprovalPhase") as ListBox;
                TextBox tbConclusion = formGrid.FindName("tbConclusion") as TextBox;
                ListBox lbCustomerID = formGrid.FindName("lbCustomerID") as ListBox;
                TextBox tbDiagDesc = formGrid.FindName("tbDiagDesc") as TextBox;
                TextBox tbFaultName = formGrid.FindName("tbFaultName") as TextBox;
                TextBox tbFixPrice = formGrid.FindName("tbFixPrice") as TextBox;
                ListBox lbMediaArray = formGrid.FindName("lbMediaArray") as ListBox;
                TextBox tbOrderDesc = formGrid.FindName("tbOrderDesc") as TextBox;
                try
                {
                    int userId = lbMasterID.SelectedItem == null ? 0 : userDb.GetNicknameId(lbMasterID.SelectedValue.ToString());
                    int customerId = lbCustomerID.SelectedItem == null ? 0 : userDb.GetNicknameId(lbCustomerID.SelectedValue.ToString());
                    int fixPrice;
                    int.TryParse(tbFixPrice.Text, out fixPrice);
                    if (userId > 0 && customerId > 0 && fixPrice > 0)
                    {
                        Order order = new Order()
                        {
                            ApprovalPhase = (Enumerations.AgreementState)lbApprovalPhase.SelectedValue,
                            Conclusion = tbConclusion.Text,
                            CustomerId = customerId,
                            DiagDesc = tbDiagDesc.Text,
                            ItemName = tbItemName.Text,
                            FaultName = tbFaultName.Text,
                            FixPrice = fixPrice,
                            MasterId = userId,
                            MediaArray = lbMediaArray.ItemsAsSequence(),
                            OrderDesc = tbOrderDesc.Text
                        };
                        orderDb.Orders.Add(order);
                        orderDb.SaveChanges();
                        orderDb.Dispose();

                        ProfileWindow window = new ProfileWindow(user);
                        Close();
                        window.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("E-10 => userId, customerId or fixPrice weren't fulfilled!");
                    }
                }
                catch (Exception ex) { MessageBox.Show($"E-9 =>{ex.Message}"); }
            }
            catch (Exception ex) { MessageBox.Show($"E-8 => {ex.Message}"); }
            //ProfileWindow window = new ProfileWindow(user);
            //Close();
            //window.ShowDialog();
        }

        private void btnCancelAddOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProfileWindow profile = new ProfileWindow(user);
                profile.WindowState = WindowState.Maximized;
                Close();
                profile.ShowDialog();
            }
            catch(Exception ex) { MessageBox.Show($"E-11 => 7{ex.Message}"); }
        }
    }
}
