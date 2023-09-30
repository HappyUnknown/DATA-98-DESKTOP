﻿using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
using DATA_98_DESKTOP_MK2.FormGUI.Admins;
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
    /// Interaction logic for ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        User user;
        public ProfileWindow(User user)
        {
            InitializeComponent();

            this.user = user;

            var db = new OrderContext();
            if (user.RightsType == AccessLevel.Customer)
                gdMasterOrders.ItemsSource = db.Orders.ToList().Where(x => x.CustomerId == user.ID);
            else
                gdMasterOrders.ItemsSource = db.Orders.ToList().Where(x => x.MasterId == user.ID);

            db.Dispose();
        }

        private void btnNewIssue_Click(object sender, RoutedEventArgs e)
        {
            NewIssueWindow issueWindow = new NewIssueWindow(user);
            Close();
            issueWindow.ShowDialog();
        }

        private void btnGoToOrders_Click(object sender, RoutedEventArgs e)
        {
            OrdersOverviewWindow overview = new OrdersOverviewWindow(user);
            Close();
            overview.ShowDialog();
        }

        private void btnGoToAddOrder_Click(object sender, RoutedEventArgs e)
        {
            NewOrderWindow orderWindow = new NewOrderWindow(user); // Preliminary to Close() in order to show further
            try
            {
                Close();
                orderWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"=> {ex.Message}");
            }
        }

        private void btnGoToRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow(user); // Preliminary to Close() in order to show further
            try
            {
                Close();
                registerWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnGoToRegister_Click=> {ex.Message}");
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow signInWindow = new LoginWindow(); // Preliminary to Close() in order to show further
            try
            {
                Close();
                signInWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnLogout_Click=> {ex.Message}");
            }
        }

        private void btnGoToAdmins_Click(object sender, RoutedEventArgs e)
        {
            UsersOverviewWindow overviewWindow = new UsersOverviewWindow(user);
            Close();
            overviewWindow.ShowDialog();
        }
    }
}
