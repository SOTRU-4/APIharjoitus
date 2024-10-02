using Microsoft.EntityFrameworkCore;

namespace APIharjoitus
{
    public class QuestDB : DbContext
    {
        public QuestDB(DbContextOptions options) : base(options) { }

        public DbSet<Quest> Quests => Set<Quest>();
    }
}
