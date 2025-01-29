using System.ComponentModel.DataAnnotations;

namespace Talentia.Dto
{
    public class AppUserRegisterDto
    {
        [Display(Name = "Adınız")]
        [Required(ErrorMessage = "Adınız Boş Geçilmez")]
        public string FirstName { get; set; }
        [Display(Name = "Soyadınız")]
        [Required(ErrorMessage = "Soyadınız Boş Geçilmez")]
        public string LastName { get; set; }
        [Display(Name = "Kullanıcı Adınız")]
        [Required(ErrorMessage = "Kullanıcıadınız Boş Geçilmez")]
        public string UserName { get; set; }
        [Display(Name = "Şehriniz")]
        [Required(ErrorMessage = "Şehriniz Boş Geçilmez")]
        public string City { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Boş Geçilmez")]
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "Telefon Boş Geçilmez")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreniz Boş Geçilmez")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


    }
}
