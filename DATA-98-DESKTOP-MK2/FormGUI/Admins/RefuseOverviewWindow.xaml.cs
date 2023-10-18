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
    /// Interaction logic for RefuseOverviewWindow.xaml
    /// </summary>
    public partial class RefuseOverviewWindow : Window
    {
        User user = null;
        public RefuseOverviewWindow(User user)
        {
            InitializeComponent();
            
            this.user = user;
            try
            {
                RefuseContext db = new RefuseContext();
                gdRefuses.ItemsSource = db.Refuses.ToList();
            }
            catch (Exception ex) { MessageBox.Show($"E-65 => {ex.Message}"); }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProfileWindow profile = new ProfileWindow(user);
                Close();
                profile.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-66 => {ex.Message}");
            }
        }
    }
}
