using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public class Messages
    {
        public static string AddedCompany = "Şirket Kaydı Başarıyla Tamamlandı";
        public static string CompanyAlreadyExists = "Bu şirket daha önce kaydedilmiştir.";


        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre yanlış.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserRegistired = "Kullanıcı kaydı başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten sistemde kayıtlıdır.";
        public static string UserMailConfirmSuccessful = "Mailiniz başarıyla onaylandı.";
        public static string MailConfirmSendSuccessful = "Doğrulama maili başarıyla gönderildi.";
        public static string MailAlreadyConfirm = " mail daha önce doğrulanmış.";
        public static string MailConfirmTimeHasNotExpired = "bekelyiniz";

        public static string MailParameterUpdate = "E-Mail parametreleri başarıyla güncellendi.";
        public static string MailSendSucessful = "E-Mail başarıyla gönderildi.";

        public static string MailTemplateAdded = "Mail şablonu başarıyla kaydedildi";
        public static string MailTemplateUpdated = "Mail şablonu başarıyla kaydedildi";
        public static string MailTemplateDeleted = "Mail şablonu başarıyla kaydedildi";
    }
}
