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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        Master reliableMaster = new Master();
        public RegisterWindow(Master master = null)
        {
            InitializeComponent();

            reliableMaster = master;

            MasterContext db = new MasterContext();
            try
            {
                lblId.Content = db.NextId();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { db.Dispose(); }
            tbEmail.Text = "john.doe@mail.com";
            tbFirstName.Text = "john";
            tbLastName.Text = "doe";
            tbMiddleName.Text = "johnson";
            tbNickname.Text = "john.doe";
            tbPassword.Text = "----------";
            tbPhone.Text = "+380380380380";
            lbRightsType.ItemsSource = typeof(AccessLevel).GetEnumValues();
        }

        string EncryptMD5(string data)
        {
            return data;
        }
        bool InputInvalid()
        {
            return lbRightsType.SelectedItem == null;
        }

        private void btnRegAdmin_Click(object sender, RoutedEventArgs e)
        {
            MasterContext db = new MasterContext();
            if (db.NicknameRegistered(tbNickname.Text.Trim(' ')))
                MessageBox.Show("User already registered");
            else if (InputInvalid())
                MessageBox.Show("Fill the whole form");
            else
                try
                {
                    Master master = new Master()
                    {
                        //Id = 0,
                        Email = tbEmail.Text,
                        FirstName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        MiddleName = tbMiddleName.Text,
                        Nickname = tbNickname.Text,
                        PassMD5 = EncryptMD5(tbPassword.Text),
                        Phone = tbPhone.Text,
                        RightsType = (AccessLevel)lbRightsType.SelectedValue
                    };
                    db.Masters.Add(master);
                    db.SaveChanges();
                    db.Dispose();
                    MasterManageWindow manageWindow = new MasterManageWindow(reliableMaster);
                    Close();
                    manageWindow.ShowDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCancelReg_Click(object sender, RoutedEventArgs e)
        {
            if (reliableMaster == null)
            {
                LoginWindow profile = new LoginWindow();
                Close();
                profile.ShowDialog();
            }
            else
            {
                ProfileWindow profile = new ProfileWindow(reliableMaster);
                Close();
                profile.ShowDialog();
            }

        }
    }
}
