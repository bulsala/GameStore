using System.Collections.Generic;
using System.Linq;
using GameStore.Domain.Abstract;

namespace GameStore.WebUI.Controllers
{
    using System.Web.Mvc;

    public class NavController : Controller
    {
        public IGameRepository repository;

        public NavController(IGameRepository repository)
        {
            this.repository = repository;
        }

        public PartialViewResult Menu()
        {
            IEnumerable<string> categories = repository.Games
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}