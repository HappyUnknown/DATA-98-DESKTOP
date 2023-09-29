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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DATA_98_DESKTOP
{
    /// <summary>
    /// Interaction logic for OrderBasePage.xaml
    /// </summary>
    public partial class OrderBasePage : Page
    {
        public OrderBasePage(Order order = null)
        {
            InitializeComponent();


            //OrderContext orderDb = new OrderContext();
            //try
            //{
            //    lblId.Content = orderDb.NextId().ToString();
            //}
            //catch (Exception ex) { MessageBox.Show($"Cannot load masters: {ex.Message}"); }
            //finally { orderDb.Dispose(); }

            MasterContext masterDb = new MasterContext();
            try
            {
                lbMasterID.ItemsSource = masterDb.Masters.Select(x => x.Nickname).ToList();
                lbCustomerID.ItemsSource = masterDb.Masters.Select(x => x.Nickname).ToList();
            }
            catch (Exception ex) { MessageBox.Show($"Cannot get master nicknames: {ex.Message}"); }
            lbFaultType.ItemsSource = typeof(Malfunction).GetEnumValues();
            lbApprovalPhase.ItemsSource = typeof(AgreementState).GetEnumValues();
            try
            {
                if (order != null)
                {
                    lblId.Content = order.Id;
                    tbOrderDesc.Text = order.OrderDesc;
                    lbMediaArray.DataContext = order.MediaArray.Split(AppConstants.URL_SPLITTER);
                    tbFixPrice.Text = order.FixPrice.ToString();
                    tbDiagDesc.Text = order.DiagDesc;
                    tbConclusion.Text = order.Conclusion;
                    lbApprovalPhase.SelectedItem = order.ApprovalPhase;
                    lbMasterID.SelectedItem = masterDb.GetNicknameById(masterDb.Masters.ToList().FirstOrDefault(x => x.Id == masterDb.GetNicknameId(lbMasterID.SelectedItem.ToString())).Id);
                    lbCustomerID.SelectedItem = masterDb.GetNicknameById(masterDb.Masters.ToList().FirstOrDefault(x => x.Id == masterDb.GetNicknameId(lbCustomerID.SelectedItem.ToString())).Id); ;
                    lbFaultType.SelectedItem = order.FaultName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OrderBasePage(): {ex.Message}");
            }
            masterDb.Dispose();
        }

        private void btnAddMedia_Click(object sender, RoutedEventArgs e)
        {
            var ofd = new System.Windows.Forms.OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                lbMediaArray.Items.Add(ofd.FileName);
        }
    }
}