using DATA_98_DESKTOP_MK2.Constants;
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
        public User user;
        public RegisterPage(User user = null)
        {
            InitializeComponent();

            this.user = user;
            UserContext db = new UserContext();
            try
            {
                if (db.Users.Count() > 0)
                    lblId.Content = db.Users.Max(x => x.ID) + 1;
                else
                    lblId.Content = "-";
            }
            catch (Exception ex) { MessageBox.Show($"E-14 => RegisterPage construction. {ex.Message}"); }
            try
            {
                tbEmail.Text = "john.doe@mail.com";
                tbFirstName.Text = "john";
                tbLastName.Text = "doe";
                tbMiddleName.Text = "johnson";
                tbNickname.Text = "john.doe";
                tbPassword.Text = "12345";
                tbPhone.Text = "+380380380380";
                try
                {
                    var rights = typeof(AccessLevel).GetEnumValues();
                    List<AccessLevel> rightList = new List<AccessLevel>();
                    for (int i = 0; i < rights.GetLength(0); i++)
                        rightList.Add((AccessLevel)rights.GetValue(i));
                    try
                    {
                        if (user == null)
                        {
                            if (db.Users.Count() > 0)
                            {
                                rightList.RemoveAt(rightList.Count - 1);
                                rightList.RemoveAt(rightList.Count - 1);
                            }
                        }
                        else if (user.RightsType == AccessLevel.Customer || user.RightsType == AccessLevel.Master)
                        {
                            rightList.RemoveAt(rightList.Count - 1);
                            rightList.RemoveAt(rightList.Count - 1);
                        }
                        lbRightsType.ItemsSource = rightList;
                        db.Dispose();
                        DisableMargin();
                    }
                    catch (Exception ex) { MessageBox.Show($"RemoveAt failing: {ex.Message}"); }
                }
                catch (Exception ex) { MessageBox.Show($"Enumeration failing: {ex.Message}"); }
            }
            catch (Exception ex) { MessageBox.Show($"E-15 => {ex.Message}"); }
        }
        void DisableMargin()
        {
            tbMarginPercent.IsEnabled = false;
            tbMarginPercent.Text = AppConstants.INIT_MARGIN.ToString();
        }
        private void lbRightsType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender == null)
                DisableMargin();
            else if ((AccessLevel)lbRightsType.SelectedValue == AccessLevel.Customer)
                DisableMargin();
            else
                tbMarginPercent.IsEnabled = true;
        }
    }
}
