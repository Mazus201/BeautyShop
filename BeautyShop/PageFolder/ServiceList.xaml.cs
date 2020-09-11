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

            if (GlobalVar.IsAdmin == true) //отображение скрытых элементов, если ты админ
            {
                BtnEdit.Visibility = Visibility.Visible;
                BtnDelete.Visibility = Visibility.Visible;
                CBToDelete.Visibility = Visibility.Visible;
                CBToDelete2.Visibility = Visibility.Visible;

            }
            else //скрытие скрытых элементов, если ты клиент
            {
                BtnEdit.Visibility = Visibility.Hidden;
                BtnDelete.Visibility = Visibility.Hidden;
                CBToDelete.Visibility = Visibility.Hidden;
                CBToDelete2.Visibility = Visibility.Hidden;
            }
            if (GlobalVar.IsDeleted1 == true) //переменная, говорящая об удалении услуги
            {
                SPService1.Visibility = Visibility.Hidden;
                SPService2.Margin = new Thickness(15, -110, 15, 5);
            } 
            else
            {
                SPService1.Visibility = Visibility.Visible; //восстановление услуги
                SPService2.Margin = new Thickness(15, 0, 15, 0);
            }

            if (GlobalVar.IsDeleted2 == true)
            {
                SPService2.Visibility = Visibility.Hidden;
            }
            else
                SPService2.Visibility = Visibility.Visible;

            TT2.Content = TBReview2.Text;
            TT1.Content = TBReview1.Text;

        }
        /// <summary>
        /// кнопка получения услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGetServ_Click(object sender, RoutedEventArgs e) 
        {
            BtnBacket.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Узнать подробности об услуге
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoreInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(TBReview1.Text); 
        }
        /// <summary>
        /// выход в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.FrmBody.Navigate(new MainMenu());
            GlobalVar.IsAdmin = false;
        }
        //переход в режим бога
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.FrmBody.Navigate(new EditPage());
        }
        /// <summary>
        /// удаление (скрытие) услуги из зоны видимости клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (CBToDelete.IsChecked == true)
            {
                SPService1.Visibility = Visibility.Hidden;
                SPService2.Margin = new Thickness(15, -110, 15, 5);
                GlobalVar.IsDeleted1 = true;
            }

            if (CBToDelete2.IsChecked == true)
            {
                SPService2.Visibility = Visibility.Hidden;
                GlobalVar.IsDeleted2 = true;
            }
        }

        private void BtnBacket_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMoreInfo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(TBReview2.Text);
        }
    }
}
