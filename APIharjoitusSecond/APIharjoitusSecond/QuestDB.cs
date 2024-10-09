using Microsoft.EntityFrameworkCore;

namespace APIharjoitusSecond
{
    public class QuestDB : DbContext
    {
        public QuestDB(DbContextOptions options) : base(options) { }

        public DbSet<Quest> Quests => Set<Quest>();
    }
}
