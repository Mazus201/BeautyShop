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
using BeautyShop.AppData;
using BeautyShop.Resources;

namespace BeautyShop.PageFolder
{
    /// <summary>
    /// Логика взаимодействия для ServiceList.xaml
    /// </summary>
    public partial class ServiceList : Page
    {
        public ServiceList()
        {
            InitializeComponent();

            if (GlobalVar.IsAdmin == true)
            {
                BtnEdit.Visibility = Visibility.Visible;
                BtnDelete.Visibility = Visibility.Visible;
                CBToDelete.Visibility = Visibility.Visible;
            }
            else
            {
                BtnEdit.Visibility = Visibility.Hidden;
                BtnDelete.Visibility = Visibility.Hidden;
                CBToDelete.Visibility = Visibility.Hidden;
            }
        }

        private void BtnGetServ_Click(object sender, RoutedEventArgs e)
        {
            BtnBacket.Visibility = Visibility.Visible;
        }

        private void BtnMoreInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.FrmBody.GoBack();
            GlobalVar.IsAdmin = false;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBacket_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
