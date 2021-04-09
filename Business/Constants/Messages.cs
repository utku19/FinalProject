﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = " Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExcedded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string SuccessfulLogin = "Giriş yapıldı.";
        public static string UserNotFound = "Kullanıcı bulanamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string UserAlreadyExists = "Çıkış yapıldı.";
        public static string AccessTokenCreated = "Erişim sağlandı";
        public static string UserRegistered;
    }
}
