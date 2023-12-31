﻿using DATA_98_DESKTOP_MK2.Constants;
using DATA_98_DESKTOP_MK2.Contexts;
using DATA_98_DESKTOP_MK2.Entities;
using DATA_98_DESKTOP_MK2.Enumerations;
using Newtonsoft.Json;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DATA_98_DESKTOP_MK2.PageGUI
{
    /// <summary>
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage(Order order = null) // UNVERIFIED
        {
            InitializeComponent();

            UserContext userDB = new UserContext();
            lbMasterID.ItemsSource = userDB.Users.Where(x => x.RightsType != AccessLevel.Customer).Select(x => x.Nickname).ToList();
            lbCustomerID.ItemsSource = userDB.Users.Where(x => x.RightsType == AccessLevel.Customer).Select(x => x.Nickname).ToList();

            lbApprovalPhase.ItemsSource = typeof(AgreementState).GetEnumValues();

            try
            {
                if (order != null)
                {
                    lblId.Content = order.Id;
                    tbItemName.Text = order.ItemName;
                    tbOrderDesc.Text = order.OrderDesc;
                    try
                    {
                        var mediaPaths = JsonConvert.DeserializeObject<string[]>(order.MediaArray);
                        for (int i = 0; i < mediaPaths.Length; i++)
                            lbMediaArray.Items.Add(mediaPaths[i]);
                    }
                    catch (Exception ex) { MessageBox.Show($"E-75 => {ex.Message}"); }
                    tbFixPrice.Text = order.FixPrice.ToString();
                    tbDiagDesc.Text = order.DiagDesc;
                    tbConclusion.Text = order.Conclusion;
                    lbApprovalPhase.SelectedItem = order.ApprovalPhase;
                    lbMasterID.SelectedItem = userDB.GetNicknameById(order.MasterId);
                    lbCustomerID.SelectedItem = userDB.GetNicknameById(order.CustomerId);
                    tbFaultName.Text = order.FaultName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-71 => {ex.Message}");
            }
        }
        private void btnRemoveMedia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lbMediaArray.SelectedItem != null)
                    lbMediaArray.Items.RemoveAt(lbMediaArray.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-72 => {ex.Message}");
            }
        }

        private void btnAddMedia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var ofd = new System.Windows.Forms.OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    lbMediaArray.Items.Add(ofd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-73 => {ex.Message}");
            }
        }

        private void lbMediaArray_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (lbMediaArray.SelectedItem != null)
                    imMediaPreview.Source = new BitmapImage(new Uri($"{lbMediaArray.SelectedValue}", UriKind.RelativeOrAbsolute));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-74 => {ex.Message}");
            }
        }
    }
}
