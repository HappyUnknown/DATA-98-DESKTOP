using DATA_98_DESKTOP.Class;
using DATA_98_DESKTOP.Context;
using DATA_98_DESKTOP.Extensions;
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
    /// Interaction logic for EditOrderWindow.xaml
    /// </summary>
    public partial class EditOrderWindow : Window
    {
        Master master = new Master();
        public EditOrderWindow(Order order, Master master)
        {
            InitializeComponent();

            OrderBasePage orderPage = new OrderBasePage(order);
            fmOrderPage.Navigate(orderPage);
            this.master = master;
        }

        private void btnEditOrder_Click(object sender, RoutedEventArgs e)
        {
            Grid orderForm = (fmOrderPage.Content as OrderBasePage).FindName("gdOrderBase") as Grid;
            Label lblId = orderForm.FindName("lblId") as Label;
            TextBox tbOrderDesc = orderForm.FindName("tbOrderDesc") as TextBox;
            ListBox lbFaultType = orderForm.FindName("lbFaultType") as ListBox; // NULL by defuault
            TextBox tbDiagDesc = orderForm.FindName("tbDiagDesc") as TextBox;
            TextBox tbFixPrice = orderForm.FindName("tbFixPrice") as TextBox;
            TextBox tbConclusion = orderForm.FindName("tbConclusion") as TextBox;
            ListBox lbApprovalPhase = orderForm.FindName("lbApprovalPhase") as ListBox;
            ListBox lbMediaArray = orderForm.FindName("lbMediaArray") as ListBox;
            ListBox lbMasterID = orderForm.FindName("lbMasterID") as ListBox;
            ListBox lbCustomerID = orderForm.FindName("lbCustomerID") as ListBox;

            OrderContext db = new OrderContext();
            List<Order> orders = db.Orders.ToList();
            Order orderFound = orders.Where(x => x.Id == int.Parse(lblId.Content.ToString())).FirstOrDefault();

            orderFound.OrderDesc = tbOrderDesc.Text;
            orderFound.FaultName = lbFaultType.SelectedItem.ToString();
            orderFound.DiagDesc = tbDiagDesc.Text;
            orderFound.FixPrice = int.Parse(tbFixPrice.Text);
            orderFound.Conclusion = tbConclusion.Text;
            orderFound.ApprovalPhase = (AgreementState)lbApprovalPhase.SelectedItem;
            orderFound.MediaArray = string.Join(";", lbMediaArray.ItemsAsArray());
            orderFound.CustomerId = (int)lbCustomerID.SelectedItem;
            orderFound.MasterId = (int)lbMasterID.SelectedItem;

            db.Entry(orderFound).State = System.Data.Entity.EntityState.Modified;
        }

        private void btnCancelAddOrder_Click(object sender, RoutedEventArgs e)
        {
            PoolWindow pool = new PoolWindow(master);
            Close();
            pool.ShowDialog();
        }
    }
}
