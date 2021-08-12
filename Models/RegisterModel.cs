using System;
using System.ComponentModel.DataAnnotations;

namespace kursach.Models{
    public class RegisterModel{
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age {get; set; }
    }
}