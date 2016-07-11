namespace GameStore.WebUI.Models
{
    using System.Collections.Generic;

    using Domain.Entities;

    public class GameListViewModel
    {
        public IEnumerable<Game> Games { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}