using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba başarıyla eklendi.";
        public static string CarDeleted = "Araba başarıyla silindi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string CarDailyPriceInvalid= "Lütfen günlük fiyat kısmını 0'dan büyük giriniz.";
        
        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandNameInvalid = "Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.";
        public static string BrandDeleted = "Marka başarıyla silindi.";
        public static string BrandUpdated = "Marka başarıyla güncellendi.";
        
        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorDeleted = "Renk başarıyla silindi.";
        public static string ColorUpdated = "Renk başarıyla güncellendi.";
        
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekiyor.";
        public static string RentalAdded = "Araç kiraya verildi.";
        
        public static string UserNotAdded = "Kullanıcı eklenemedi.";
        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        
        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";
        
        public static string AddedRental = "Araba Kiralama işlemi başarıyla gerçekleşti.";
        public static string FailedRentalAdd="Bu araba henüz teslim edilmediği için kiralanamaz.";
        public static string RentalDeleted= "Araba Kiralama işlemi iptal edildi.";
        public static string RentalUpdated = "Araba Kiralama işlemi güncellendi.";
        public static string RentalReturned = "Kiraladığınız araç teslim edildi.";

        public static string AddedCarImage = "Resim başarıyla eklendi.";
        public static string DeletedCarImage = "Resim başarıyla silindi.";
        public static string UpdatedCarImage = "Resim başarıyla güncellendi.";
        public static string FailedCarImageAdd= "Resim limitine erişildi!";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Sifre hatalı.";
        public static string SuccessfullLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
