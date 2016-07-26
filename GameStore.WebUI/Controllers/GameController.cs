namespace GameStore.WebUI.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Domain.Abstract;
    using Models;

    public class GameController : Controller
    {
        private IGameRepository repository;

        public int pageSize = 4;

        public GameController(IGameRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, int page = 1)
        {
            GameListViewModel model = new GameListViewModel
            {
                Games = repository.Games
                    .Where(x => category == null || x.Category == category)
                    .OrderBy(x => x.GameId)
                    .Skip((page - 1)*pageSize)
                    .Take(pageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Games.Count()
                },

                CurrentCategory = category
            };

            return View(model);
        }
    }
}