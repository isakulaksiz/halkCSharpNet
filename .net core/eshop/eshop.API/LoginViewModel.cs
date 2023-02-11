﻿using System.ComponentModel.DataAnnotations;

namespace eshop.API
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adını unuttunuz :(")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
