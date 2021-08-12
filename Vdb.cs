using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace kursach2{
    public class VdbContext : DbContext{
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CryptKey> CryptKeys { get; set; }
        public DbSet<CryptMessage> CryptMessages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=V.db");
    }

    public class Account{
        public int AccountId { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public CryptKey CryptKey { get; set; }
        public List<CryptMessage> CryptMessages {get; set; }
    }

    public class CryptKey{
        public int CryptkeyId { get; set; }
        public string encryptKey { get; set; }
        public string decryptKey { get; set; }
        
        public int AccountId {get; set; }
        public Account Account {get; set; }
    }

    public class CryptMessage{
        public int CryptMessageId {get; set; }
        public string cryptmessage {get; set; }

        public int AccountId {get; set; }
        public Account Account {get; set; }
    }
}