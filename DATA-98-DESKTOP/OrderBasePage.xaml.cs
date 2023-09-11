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
        public OrderBasePage()
        {
            InitializeComponent();

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
                lbCustomerID.ItemsSource = masterDb.Masters.Select(x => x.Nickname).ToList();
            }
            catch (Exception ex) { MessageBox.Show($"Cannot get master nicknames: {ex.Message}"); }
            finally { masterDb.Dispose(); }

            lbFaultType.ItemsSource = typeof(Malfunction).GetEnumValues();
            lbApprovalPhase.ItemsSource = typeof(AgreementState).GetEnumValues();
        }
    }
}
