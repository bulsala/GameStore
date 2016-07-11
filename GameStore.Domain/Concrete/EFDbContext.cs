namespace GameStore.Domain.Concrete
{
    using System.Data.Entity;

    using Entities;

    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
