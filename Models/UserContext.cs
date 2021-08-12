using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace kursach{
    public class UserContext : DbContext{
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=V.db");
    }

    // public class Account{
    //     public int AccountId { get; set; }
    //     public string name { get; set; }
    //     public string password { get; set; }

    //     public CryptKey CryptKey { get; set; }
    //     public List<CryptMessage> CryptMessages {get; set; }
    // }
}