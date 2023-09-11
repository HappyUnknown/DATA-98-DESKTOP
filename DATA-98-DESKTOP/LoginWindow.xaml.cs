using DATA_98_DESKTOP.Class;
using DATA_98_DESKTOP.Context;
using DATA_98_DESKTOP.Management;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            string nickname = "admin";
            string password = "moderator";
            tbNickname.Text = nickname;
            tbPassword.Text = password;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MasterContext db = new MasterContext();
                Master master = db.LogMasterIn(tbNickname.Text, tbPassword.Text);
                if (master != null)
                    try
                    {
                        ProfileWindow profileWindow = new ProfileWindow(master);
                        Close();
                        profileWindow.ShowDialog();
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
            RegisterWindow profileWindow = new RegisterWindow();
            Close();
            profileWindow.ShowDialog();
        }
    }
}
