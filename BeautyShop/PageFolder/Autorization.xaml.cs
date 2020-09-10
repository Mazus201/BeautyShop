﻿using BeautyShop.AppData;
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
using BeautyShop.Resources;

namespace BeautyShop.PageFolder
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
        }
            public int i;

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            PasswordBox.Text = null;
            i = 0;
            BrdInCorrect.Visibility = Visibility.Hidden;
            GlobalVar.IsAdmin = false;
            ClsFrame.FrmBody.GoBack();

        }
        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                BrdInCorrect.Visibility = Visibility.Visible;
                i++;
                if (i == 3)
                {
                    MessageBox.Show("I think you are not a admin");
                    ClsFrame.FrmBody.Navigate(new MainMenu());
                    GlobalVar.IsAdmin = false;
                    i = 0;
                    BrdInCorrect.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                AdminService adminService = ClsEnt.Ent.AdminService.FirstOrDefault(x => x.Password == PasswordBox.Text);
                if (adminService == null)
                {
                    BrdInCorrect.Visibility = Visibility.Visible;
                    i++;
                    if (i == 3)
                    {
                        MessageBox.Show("I think you are not a admin");
                        ClsFrame.FrmBody.Navigate(new MainMenu());
                        BrdInCorrect.Visibility = Visibility.Hidden;
                        GlobalVar.IsAdmin = false;
                        PasswordBox.Text = null;
                        i = 0;
                    }
                }
                else
                {
                    GlobalVar.IsAdmin = true;
                    ClsFrame.FrmBody.Navigate(new ServiceList());
                    BrdInCorrect.Visibility = Visibility.Hidden;
                    PasswordBox.Text = null;
                }
            }
        }
    }
}