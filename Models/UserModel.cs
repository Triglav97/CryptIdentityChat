using System;
using System.ComponentModel.DataAnnotations;

namespace kursach.Models{
    public class User{
        public int Id{get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string Age { get; set; }
    }
}