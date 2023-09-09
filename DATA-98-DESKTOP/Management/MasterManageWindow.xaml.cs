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

namespace DATA_98_DESKTOP.Management
{
    /// <summary>
    /// Interaction logic for MasterManageWindow.xaml
    /// </summary>
    public partial class MasterManageWindow : Window
    {
        Master master = new Master();
        public MasterManageWindow(Master master)
        {
            InitializeComponent();
            this.master = master;
            MasterContext db = new MasterContext();
            gdAdmins.ItemsSource = db.Masters.ToList();
            db.Dispose();
        }

        private void btnGoToProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profile = new ProfileWindow(master);
            Close();
            profile.ShowDialog();
        }
    }
}
