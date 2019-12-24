using System.Collections.Generic;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Disco"},
                new Genre { Name = "Jazz"},
                new Genre { Name = "Rock"}
            };
            return View(genres);
        }

        //
        // GET: /Store/Browse
        public ViewResult Browse(Genre genre)
        {
            var genreModel = new Genre { Name = genre.Name };
            return View(genreModel);
        }

        //
        // GET: /Store/Details
        public ViewResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}