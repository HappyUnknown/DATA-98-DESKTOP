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
    /// Interaction logic for EditMarginWindow.xaml
    /// </summary>
    public partial class EditMarginWindow : Window
    {
        User user = null;
        public EditMarginWindow(User user)
        {
            InitializeComponent();

            try
            {
                this.user = user;

                UserContext userDB = new UserContext();
                lbUsername.ItemsSource = userDB.Users.Where(x => x.RightsType != AccessLevel.Customer).Select(x => x.Nickname).ToList();
            }
            catch (Exception ex) { MessageBox.Show($"E-67 => {ex.Message}"); }
        }
        void RefreshData()
        {
            try
            {
                UserContext db = new UserContext();
                List<User> globalUsers = db.Users.ToList();
                int uid = db.GetNicknameId(lbUsername.SelectedValue.ToString());
                User userById = globalUsers.Where(x => x.ID == uid).FirstOrDefault();
                if (userById != default)
                {
                    int globalIndex = globalUsers.IndexOf(userById);
                    lblCurrentMargin.Content = $"{globalUsers[globalIndex].MarginPercent}%";
                }
                tbMarginValue.Text = string.Empty;
            }
            catch (Exception ex) { MessageBox.Show($"E-68 => {ex.Message}"); }
        }
        private void lbUsername_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshData();
        }

        private void btnRedeemMargin_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                UserContext db = new UserContext();
                List<User> globalUsers = db.Users.ToList();
                int uid = db.GetNicknameId(lbUsername.SelectedValue.ToString());
                User userById = globalUsers.Where(x => x.ID == uid).FirstOrDefault();
                if (userById != default)
                {
                    int globalIndex = globalUsers.IndexOf(userById);
                    double margin;
                    double.TryParse(tbMarginValue.Text, out margin);
                    globalUsers[globalIndex].MarginPercent = margin;
                    db.SaveChanges();
                    db.Dispose();
                    RefreshData();
                }
            }
            catch (Exception ex) { MessageBox.Show($"E-69 => {ex.Message}"); }
        }

        private void btnGoToProfile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProfileWindow profile = new ProfileWindow(user);
                profile.WindowState = WindowState.Maximized;
                Close();
                profile.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show($"E-70 => {ex.Message}"); }
        }
    }
}
