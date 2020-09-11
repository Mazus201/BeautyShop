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
        /// <summary>
        /// кнопка возврата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Восстановление панели по чекбоксу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGiveBack_Click(object sender, RoutedEventArgs e)
        {
            if (CBToDelete.IsChecked == true)
            {
                if (GlobalVar.IsDeleted1 == true)
                {
                    GlobalVar.IsDeleted1 = false;
                    MessageBox.Show("Успешно!", "Успех!");
                }
            }

            if (CBToDelete2.IsChecked == true)
            {
                if (GlobalVar.IsDeleted2 == true)
                {
                    GlobalVar.IsDeleted2 = false;
                    MessageBox.Show("Успешно!", "Успех!");
                }
            }
        }

        private void BtnChange1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float NewPrice1 = Convert.ToInt32(TxtPrice1.Text);
                GlobalVar.Price1 = NewPrice1;
            }
            catch
            {
                MessageBox.Show("Вы ввели недопустимое значение, нужно вводить цифры!", "Ошибка");
            }
        }

        private void BtnChange2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float NewPrice2 = Convert.ToInt32(TxtPrice2.Text);
                GlobalVar.Price2 = NewPrice2;
            }
            catch
            {
                MessageBox.Show("Вы ввели недопустимое значение, нужно вводить цифры!", "Ошибка");
            }
        }
    }
}
