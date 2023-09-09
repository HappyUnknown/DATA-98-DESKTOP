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
    /// Interaction logic for MasterRegisterWindow.xaml
    /// </summary>
    public partial class MasterRegisterWindow : Window
    {
        Master master = new Master() { Email = "mail@mail.com", FirstName = "Marco", LastName = "Polo", MiddleName = "Marco's", Nickname = "admin", PassMD5 = "moderator", Phone = "+380380380380", RightsType = AccessLevel.Admin };
        public MasterRegisterWindow()
        {
            InitializeComponent();

            lbRightsType.ItemsSource = typeof(AccessLevel).GetEnumValues();

            MasterContext db = new MasterContext();
            try
            {
                lblId.Content = db.NextId();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { db.Dispose(); }

            tbEmail.Text = master.Email;
            tbFirstName.Text = master.FirstName;
            tbLastName.Text = master.LastName;
            tbMiddleName.Text = master.MiddleName;
            tbNickname.Text = master.Nickname;
            tbPassword.Text = master.PassMD5;
            tbPhone.Text = master.Phone;
            lbRightsType.SelectedItem = master.RightsType.ToString();

        }

        string EncryptMD5(string data)
        {
            return data;
        }

        bool InputInvalid()
        {
            return lbRightsType.SelectedItem == null;
        }

        bool NicknameRegistered(string nick)
        {
            MasterContext db = new MasterContext();
            List<Master> masters = db.Masters.ToList();
            for (int i = 0; i < masters.Count; i++)
            {
                if (nick == masters[i].Nickname)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnRegAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (InputInvalid())
                MessageBox.Show("Registration input invalid");
            else if (NicknameRegistered(tbNickname.Text.Trim(' ')))
                MessageBox.Show("User already registered");
            else
                try
                {
                    MasterContext db = new MasterContext();
                    var accessLevels = typeof(AccessLevel).GetEnumValues();
                    master = new Master()
                    {
                        Id = 0,
                        Email = tbEmail.Text,
                        FirstName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        MiddleName = tbMiddleName.Text,
                        Nickname = tbNickname.Text,
                        PassMD5 = EncryptMD5(tbPassword.Text),
                        Phone = tbPhone.Text,
                        RightsType = (AccessLevel)accessLevels.GetValue(lbRightsType.SelectedIndex)
                    };
                    db.Masters.Add(master);
                    db.SaveChanges();
                    db.Dispose();
                    MasterManageWindow manageWindow = new MasterManageWindow(master);
                    Close();
                    manageWindow.ShowDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            Close();
            loginWindow.ShowDialog();
        }
    }
}
