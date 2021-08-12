using System;
using System.ComponentModel.DataAnnotations;

namespace kursach.Models{
    public class LoginModel{
        public string Name { get; set; }
        public string Password { get; set; }
    }
}