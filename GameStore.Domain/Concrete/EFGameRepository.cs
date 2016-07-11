namespace GameStore.Domain.Concrete
{
    using System.Collections.Generic;

    using Entities;
    using Abstract;

    public class EFGameRepository : IGameRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }
    }
}
