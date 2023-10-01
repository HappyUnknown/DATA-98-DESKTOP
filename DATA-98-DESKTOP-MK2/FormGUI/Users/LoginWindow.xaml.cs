using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
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

namespace DATA_98_DESKTOP_MK2.FormGUI.Users
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            string nickname = "don.joe";
            string password = "12345";
            tbNickname.Text = nickname;
            tbPassword.Text = password;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserContext db = new UserContext();
                User user = db.LogMasterIn(tbNickname.Text, tbPassword.Text);
                if (user != null)
                    try
                    {
                        if (!user.Banned)
                        {
                            ProfileWindow profileWindow = new ProfileWindow(user);
                            Close();
                            profileWindow.ShowDialog();
                        }
                        else MessageBox.Show("User was banned");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                else MessageBox.Show("Credentials invalid");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot login: {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow profileWindow = new RegisterWindow(user: null);
            Close();
            profileWindow.ShowDialog();
        }
    }
}
