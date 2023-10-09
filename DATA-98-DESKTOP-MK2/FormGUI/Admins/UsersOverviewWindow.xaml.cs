using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
using DATA_98_DESKTOP_MK2.FormGUI.Users;
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
    /// Interaction logic for UsersOverviewWindow.xaml
    /// </summary>
    public partial class UsersOverviewWindow : Window
    {
        User user = null;
        public UsersOverviewWindow(User user)
        {
            InitializeComponent();
            try
            {

                this.user = user;
                var db = new UserContext();
                gdUsers.ItemsSource = db.Users.ToList();
                db.Dispose();
            }
            catch (Exception ex) { MessageBox.Show($"E-30 => {ex.Message}"); }
        }

        private void btnGoToProfile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProfileWindow profile = new ProfileWindow(user);
                Close();
                profile.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show($"E-31 => {ex.Message}"); }
        }
    }
}
