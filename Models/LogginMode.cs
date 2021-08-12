using System;
using System.ComponentModel.DataAnnotations;

namespace kursach.Models{
    public class Userm{
        [Key]
        public int AccountId{get; set; }

        [Required(ErrorMessage = "Укажите имя")]
        public string name { get; set; }
        
        [Required(ErrorMessage = "Укажите пароль")]
        [DataType(DataType.Password)]
        public string password { get; set; }
         
        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}