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

            TT1.Content = TBReview1.Text;
            TT2.Content = TBReview2.Text;
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
        /// <summary>
        /// переход в режим бога
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Загрузка страницы и подгрузка скидки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {

                //выполняем проверку для превой услуги
                if (GlobalVar.IsChangedService1 == true) //проверка на то, была ли изменена цена
                {
                    GlobalVar.KOSTIL1 = GlobalVar.OldPrice1;

                    if (GlobalVar.IsSale1 == true) //проверка на то, стала ли новая цена ниже предыдущей
                    {
                        TxtSale1.Text = Convert.ToString(GlobalVar.Price1); //если да, то перечеркиваем старую цену и пишем новую ниже
                        TxtPrice1.Text = Convert.ToString(GlobalVar.KOSTIL1);
                        TxtPrice1.TextDecorations = TextDecorations.Strikethrough;
                        TxtSale1.Visibility = Visibility.Visible;
                        GlobalVar.OldPrice1 = Convert.ToDouble(TxtSale1.Text);
                        TTPrice1.Content = TxtSale1.Text;
                    }
                    else
                    {
                        TxtSale1.Visibility = Visibility.Hidden;//если нет, то просто меняем старую цену на новую
                        GlobalVar.OldPrice1 = GlobalVar.Price1;
                        TxtPrice1.Text = Convert.ToString(GlobalVar.Price1);
                        TTPrice1.Content = TxtPrice1.Text;
                    }
                    GlobalVar.IsChangedService1 = false; //обнуляем измененность цены

                }
                else //если цена не менялась
                {
                    if (GlobalVar.IsSale1 == true) //проверяем на наличие скидки
                    {
                        TxtPrice1.Text = Convert.ToString(GlobalVar.KOSTIL1);
                        TxtSale1.Text = Convert.ToString(GlobalVar.Price1); //перечеркиваем старую цену и ниже пишем новую
                        TxtPrice1.TextDecorations = TextDecorations.Strikethrough;
                        TxtSale1.Visibility = Visibility.Visible;
                        TTPrice1.Content = TxtSale1.Text;
                    }
                    else
                    {
                        TxtSale1.Visibility = Visibility.Hidden; //просто отображаем новую (или старую, если изменений не было вовсе) цену
                        TxtPrice1.Text = Convert.ToString(GlobalVar.Price1);
                        TTPrice1.Content = TxtPrice1.Text;
                    }
                }
            }
                catch
            {
                MessageBox.Show("Неизвестная ошибка. Перезапустите программу.", "Ошибка!");
            }


            //есть баг, связан с неправильным отображением цены по скидке для второй услуги при первой загрузке страницы. Дальше все нормально.

            try
                {
                    //выполняем проверку для второй услуги
                    if (GlobalVar.IsChangedService2 == true) //проверка на то, была ли изменена цена
                    {
                        GlobalVar.KOSTIL2 = GlobalVar.OldPrice2; //костыль для хранения цены и корректного отображения скидки

                        if (GlobalVar.IsSale2 == true) //проверка на то, стала ли новая цена ниже предыдущей
                        {
                            TxtSale2.Text = Convert.ToString(GlobalVar.Price2); //если да, то перечеркиваем старую цену и пишем новую ниже
                            TxtPrice2.Text = Convert.ToString(GlobalVar.KOSTIL2);
                            TxtPrice2.TextDecorations = TextDecorations.Strikethrough;
                            TxtSale2.Visibility = Visibility.Visible;
                            GlobalVar.OldPrice2 = Convert.ToDouble(TxtSale2.Text);
                            TTPrice2.Content = TxtSale2.Text;
                        }
                        else
                        {
                            TxtSale2.Visibility = Visibility.Hidden;//если нет, то просто меняем старую цену на новую
                            GlobalVar.OldPrice2 = GlobalVar.Price2;
                            TxtPrice2.Text = Convert.ToString(GlobalVar.Price2);
                            TTPrice2.Content = TxtPrice2.Text;
                        }
                        GlobalVar.IsChangedService2 = false; //обнуляем измененность цены
                    }
                    else //если цена не менялась
                    {
                        if (GlobalVar.IsSale2 == true) //проверяем на наличие скидки
                        {
                            TxtPrice2.Text = Convert.ToString(GlobalVar.KOSTIL2);
                            TxtSale2.Text = Convert.ToString(GlobalVar.Price2); //перечеркиваем старую цену и ниже пишем новую
                            TxtPrice2.TextDecorations = TextDecorations.Strikethrough;
                            TxtSale2.Visibility = Visibility.Visible;
                            TTPrice2.Content = TxtSale2.Text;
                        }
                        else
                        {
                            TxtSale2.Visibility = Visibility.Hidden; //просто отображаем новую (или старую, если изменений не было вовсе) цену
                            TxtPrice2.Text = Convert.ToString(GlobalVar.Price2);
                            TTPrice2.Content = TxtPrice2.Text;
                        }
                    }
                }

                catch
                {
                    MessageBox.Show("Неизвестная ошибка. Перезапустите программу.", "Ошибка!");
                }
            }
        }

}
