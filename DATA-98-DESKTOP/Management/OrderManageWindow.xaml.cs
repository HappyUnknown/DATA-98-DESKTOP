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

namespace DATA_98_DESKTOP.Management
{
    /// <summary>
    /// Interaction logic for OrderManageWindow.xaml
    /// </summary>
    public partial class OrderManageWindow : Window
    {
        public OrderManageWindow()
        {
            InitializeComponent();

            var db = new OrderContext();
            try
            {
                //db.Orders.Add(new Order());
                //db.Orders.Add(new Order());
                db.SaveChanges();
                gdOrders.ItemsSource = db.Orders.ToList();

                //Order obj = new Order();
                //db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
