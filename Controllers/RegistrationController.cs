using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using kursach.Models;
using Microsoft.AspNetCore.Identity;

namespace kursach.Controllers{
    public class RegistrationController : Controller{
        
        public ActionResult Index(){
            return View();
        }
        
        public ActionResult Register(){
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model){
            if (ModelState.IsValid){
                using(var db = new VdbContext()){
                    var crypt_key = new CryptKey{encryptKey = "da", decryptKey = "net"};
                    var account = new Account{name = "Vovan", password = "123qwe", CryptKey = crypt_key};
                    db.Accounts.Add(account);
                    db.SaveChanges();
                }
            
            }
            return null;
        }
    }
}