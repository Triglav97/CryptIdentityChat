using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace kursach{
    public class Program{
        public static void Main(string[] args){
            CreateHostBuilder(args).Build().Run();

            using(var db = new VdbContext()){
                var crypt_key = new CryptKey{encryptKey = "da", decryptKey = "net"};
                var account = new Account{name = "Vovan", password = "123qwe", CryptKey = crypt_key};
                db.Accounts.Add(account);
                Delete_row(db);
                db.SaveChanges();
            }
            
        }

        //public void DeleteOnSubmit (TEntity entity);

        public static void Delete_row (VdbContext db){
            var delete_row = 
                from Accounts in db.Accounts
                where Accounts.AccountId == 1
                select Accounts;
            foreach (var account in delete_row){
                db.Accounts.Remove(account);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
