﻿using System;
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
using BeautyShop.AppData;

namespace BeautyShop.PageFolder
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// переход на авторизацию администратора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdm_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.FrmBody.Navigate(new Autorization());
        }

        /// <summary>
        /// возвращение назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.FrmBody.Navigate(new ServiceList());
        }

    }
}
