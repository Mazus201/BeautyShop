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
            if (CBToDelete.IsChecked == true) //проверка на выделение удаляемого объекта
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

        /// <summary>
        /// изменеие цены первой услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChange1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GlobalVar.Price1 = Convert.ToInt32(TxtPrice1.Text); //забиваем в глобальную переменную новую цену из комбобокса

                if (GlobalVar.OldPrice1 > GlobalVar.Price1) //сравниваем старую и новую цены
                    GlobalVar.IsSale1 = true; //если новая ниже, то включаем скидку
                else
                    GlobalVar.IsSale1 = false; //если выше, то не включаем скидку

                GlobalVar.IsChangedService1 = true; //отмечаем, что внесли изменения в стоимость
            }
            catch
            {
                MessageBox.Show("Вы ввели недопустимое значение, нужно вводить цифры!", "Ошибка");
            }
        }

        /// <summary>
        /// изменение цены второй услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChange2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GlobalVar.Price2 = Convert.ToInt32(TxtPrice2.Text); //забиваем в глобальную переменную новую цену из комбобокса

                if (GlobalVar.OldPrice2 > GlobalVar.Price2) //сравниваем старую и новую цены
                    GlobalVar.IsSale2 = true; //если новая ниже, то включаем скидку
                else
                    GlobalVar.IsSale2 = false; //если выше, то не включаем скидку

                GlobalVar.IsChangedService2 = true; //отмечаем, что внесли изменения в стоимость
            }
            catch
            {
                MessageBox.Show("Вы ввели недопустимое значение, нужно вводить цифры!", "Ошибка");
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TxtPrice1.Text = Convert.ToString(GlobalVar.OldPrice1);
            TxtPrice2.Text = Convert.ToString(GlobalVar.OldPrice2);
        }
    }
}
