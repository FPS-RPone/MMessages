using Microsoft.EntityFrameworkCore;

namespace KRApi
{
    public class DbChatContext: DbContext
    {
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Message> Messages => Set<Message>();
        public DbSet<Chat> Chats => Set<Chat>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
        public DbChatContext() => Database.EnsureCreated();
    }
}
