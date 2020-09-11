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

        public static float Price1 = 1100; //цена первой услуги
        public static float Price2 = 2000; //цена второй услуги

        public static float OldPrice1 = 1100; //Старая цена первой услуги
        public static float OldPrice2 = 2000; //Старая цена второй услуги

        public static float KOSTIL1 = 0; //Костыль дляотображения в текстбоксе
        public static float KOSTIL2 = 0; //Костыль дляотображения в текстбоксе

        public static bool IsSale1 = false;
        public static bool IsSale2 = false;

        public static bool IsChangedService1 = false;
        public static bool IsChangedService2 = false;
    }
}
