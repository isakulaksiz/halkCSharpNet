using System.ComponentModel.DataAnnotations;

namespace introducingNetCore.Models
{
    public class Responser
    {
        [Required(ErrorMessage = "Kullanıcı adı boş olamaz")]
        [MinLength(2, ErrorMessage = "En az 2 harf olmalıdır")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Kullanıcı soyadı boş olamaz")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Eposta formatı hatalı")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Lütfen durumunuzu belirtin")]
        public bool? IsAccepted { get; set; }


    }
}
