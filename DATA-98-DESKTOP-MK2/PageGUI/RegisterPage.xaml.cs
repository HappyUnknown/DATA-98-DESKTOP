using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
using DATA_98_DESKTOP_MK2.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DATA_98_DESKTOP_MK2.PageGUI
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();

            UserContext db = new UserContext();
            try
            {
                if (db.Users.Count() > 0)
                    lblId.Content = db.Users.Max(x => x.ID) + 1;
                else lblId.Content = "-";
            }
            catch (Exception ex) { MessageBox.Show($"RegisterPage construction => {ex.Message}"); }
            finally { db.Dispose(); }

            tbEmail.Text = "john.doe@mail.com";
            tbFirstName.Text = "john";
            tbLastName.Text = "doe";
            tbMiddleName.Text = "johnson";
            tbNickname.Text = "john.doe";
            tbPassword.Text = "12345";
            tbPhone.Text = "+380380380380";
            lbRightsType.ItemsSource = typeof(AccessLevel).GetEnumValues();
        }
    }
}
