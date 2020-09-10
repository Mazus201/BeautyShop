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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public EditPage()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.FrmBody.Navigate(new ServiceList());
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGetServ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMoreInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGiveBack_Click(object sender, RoutedEventArgs e)
        {
            if (CBToDelete.IsChecked == true)
            {
                GlobalVar.IsDeleted1 = false;
                MessageBox.Show("Успешно!");
            }

            if (CBToDelete2.IsChecked == true)
            {
                GlobalVar.IsDeleted2 = false;
                MessageBox.Show("Успешно!");
            }
        }

        private void BtnChange1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnChange2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
