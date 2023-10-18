using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
using DATA_98_DESKTOP_MK2.Extensions;
using DATA_98_DESKTOP_MK2.PageGUI;
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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        User user = null;
        public RegisterWindow(User user = null)
        {
            InitializeComponent();

            this.user = user;

            if (user == null)
                lblNickname.Content = "No responsive user";
            else if (user != null)
                lblNickname.Content = $"Responsive user: {user.Nickname} [{user.RightsType}]";
            try
            {
                RegisterPage page = new RegisterPage(this.user);
                fmRegisterPage.Navigate(page);
            }
            catch (Exception ex) { MessageBox.Show($"E-55 => {ex.Message}"); }
        }

        public bool InputInvalid()
        {
            try
            {
                return ((fmRegisterPage.Content as RegisterPage).FindName("lbRightsType") as ListBox).SelectedItem == null;
            }
            catch (Exception ex) { MessageBox.Show($"E-56 => {ex.Message}"); }
            return true;
        }
        private void btnRegUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TextBox tbNickname = (fmRegisterPage.Content as RegisterPage).FindName("tbNickname") as TextBox;
                TextBox tbEmail = (fmRegisterPage.Content as RegisterPage).FindName("tbEmail") as TextBox;
                TextBox tbFirstName = (fmRegisterPage.Content as RegisterPage).FindName("tbFirstName") as TextBox;
                TextBox tbLastName = (fmRegisterPage.Content as RegisterPage).FindName("tbLastName") as TextBox;
                TextBox tbMiddleName = (fmRegisterPage.Content as RegisterPage).FindName("tbMiddleName") as TextBox;
                TextBox tbPassword = (fmRegisterPage.Content as RegisterPage).FindName("tbPassword") as TextBox;
                TextBox tbPhone = (fmRegisterPage.Content as RegisterPage).FindName("tbPhone") as TextBox;
                ListBox lbRightsType = (fmRegisterPage.Content as RegisterPage).FindName("lbRightsType") as ListBox;
                UserContext db = new UserContext();
                string formNickname = tbNickname.Text.Trim(' ');
                try
                {

                    if (db.NicknameRegistered(formNickname))
                        MessageBox.Show("E-59 => User already registered");
                    else if (InputInvalid())
                        MessageBox.Show("E-60 => Fill the whole form");
                    else
                        try
                        {
                            User user = new User()
                            {
                                //Id = 0,
                                Email = tbEmail.Text,
                                FirstName = tbFirstName.Text,
                                LastName = tbLastName.Text,
                                MiddleName = tbMiddleName.Text,
                                Nickname = tbNickname.Text,
                                PassMD5 = tbPassword.Text.HashMD5(),
                                Phone = tbPhone.Text,
                                RightsType = (AccessLevel)lbRightsType.SelectedValue
                            };
                            db.Users.Add(user);
                            db.SaveChanges();
                            MessageBox.Show("Success");
                            db.Dispose();

                        }
                        catch (Exception ex) { MessageBox.Show($"E-61 => {ex.Message}"); }
                }
                catch (Exception ex) { MessageBox.Show($"E-58 => {ex.Message}"); }
            }
            catch (Exception ex) { MessageBox.Show($"E-57 => {ex.Message}"); }

        }
        private void btnCancelReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoginWindow loginWindow = new LoginWindow();
                Close();
                loginWindow.ShowDialog();
            }
            catch(Exception ex) { MessageBox.Show($"E-62 => {ex.Message}"); }
        }
    }
}
