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

            string nickname = "john.doe";
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
                            profileWindow.WindowState = WindowState.Maximized;
                            Close();
                            profileWindow.ShowDialog();
                        }
                        else MessageBox.Show("E-32 => User banned");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"E-33 => {ex.Message}");
                    }
                else MessageBox.Show("E-34 => Credentials invalid.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-35 => Cannot login. {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RegisterWindow profileWindow = new RegisterWindow(user: null);
                Close();
                profileWindow.ShowDialog();
            }
            catch(Exception ex) { MessageBox.Show($"E-36 => {ex.Message}"); }
        }
    }
}
