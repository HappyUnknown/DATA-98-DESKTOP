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
    /// Interaction logic for SneakRegisterWindow.xaml
    /// </summary>
    public partial class SneakRegisterWindow : Window
    {
        public SneakRegisterWindow()
        {
            InitializeComponent();
        }

        private void btnSneakRegister_Click(object sender, RoutedEventArgs e)
        {
            User admin = new User() { RightsType = AccessLevel.Admin };
            RegisterWindow window = new RegisterWindow(admin);
            Close();
            window.ShowDialog();
        }
    }
}
