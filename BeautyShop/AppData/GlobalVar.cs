using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.AppData
{
    class GlobalVar
    {
        public static bool IsAdmin = false; //проверка на администратора

        public static bool IsDeleted1 = false; //для чекбокса для удаления первой услуги
        public static bool IsDeleted2 = false; //второй услуги

        public static double Price1 = 1100; //цена первой услуги
        public static double Price2 = 2000; //цена второй услуги

        public static double OldPrice1 = 1100; //Старая цена первой услуги
        public static double OldPrice2 = 2000; //Старая цена второй услуги

        public static double KOSTIL1 = 0; //Костыль дляотображения в текстбоксе
        public static double KOSTIL2 = 0; //Костыль дляотображения в текстбоксе

        public static bool IsSale1 = false;
        public static bool IsSale2 = false;

        public static bool IsChangedService1 = false;
        public static bool IsChangedService2 = false;
    }
}
