using KRApi.Classes;
using Microsoft.EntityFrameworkCore;

namespace KRApi
{
    public class DbChatContext: DbContext
    {
        public DbSet<Account> accounts => Set<Account>();
        public DbSet<Message> messages => Set<Message>();
        public DbSet<Chat> chats => Set<Chat>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }

        public DbChatContext() => Database.EnsureCreated();
    }
}
