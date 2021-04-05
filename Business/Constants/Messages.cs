using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Ürün Eklendi...";
        public static string CarDeleted = "Ürün Silindi...";
        public static string CarUpdated = "Ürün Güncellendi...";
        public static string CarNameInValid = "Araba ismi geçersiz...";
        public static string CarListed = "Arabalar Listelendi...";

        public static string ColorAdded = "Renk Eklendi...";
        public static string ColorDeleted = "Renk Silindi...";
        public static string ColorUpdated = "Renk Güncellendi...";
        public static string ColorNameInValid = "Renk ismi geçersiz...";
        public static string ColorListed = "Renkler Listelendi...";

        public static string BrandAdded = "Marka Eklendi...";
        public static string BrandDeleted = "Marka Silindi...";
        public static string BrandUpdated = "Marka Güncellendi...";
        public static string BrandNameInValid = "Marka ismi geçersiz...";
        public static string BrandListed = "Markalar Listelendi...";

        public static string UserAdded = "Kullanıcı Eklendi...";
        public static string UserDeleted = "Kullanıcı Silindi...";
        public static string UserUpdated = "Kullanıcı Güncellendi...";
        public static string UserNameInValid = "Kullanıcı ismi geçersiz...";
        public static string UserListed = "Kullanıcılar Listelendi...";

        public static string RentAdded = "Kiralama Eklendi...";
        public static string RentDeleted = "Kiralama Silindi...";
        public static string RentUpdated = "KKiralamaullanıcı Güncellendi...";
        public static string RentNameInValid = "Kiralama ismi geçersiz...";
        public static string RentListed = "Kiralamalar Listelendi...";
        public static string RentInValid = "Kiralama Başarısız...";



        public static string MaintenanceTime = "Sistem Bakımda...";

        public static string CarCheckImageLimited { get; internal set; }
        public static string CarImageDeleted { get; internal set; }
        public static string CarImageAdded { get; internal set; }
        public static string GetUser { get; internal set; }
        public static string CarImagesListed { get; internal set; }
        public static string AuthorizationDenied { get; internal set; }
    }
}
