namespace GameStore.Domain.Abstract
{
    using System.Collections.Generic;

    using Entities;

    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }
}
