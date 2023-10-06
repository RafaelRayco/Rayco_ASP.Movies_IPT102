using Rayco_Movies_IPT102.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;

namespace Rayco_Movies_IPT102.Controllers
{
    public class MoviesController : Controller
    {
		public ViewResult Random()
		{
			var movie = GetMovie();
			return View(movie);
		}

		public ActionResult Details(int id)
		{
			var movie = GetMovie().SingleOrDefault(m => m.Id == id);
			if (movie == null)
				return View();

			return View(movie);
		}

		private IEnumerable<Movie> GetMovie() 
		{
			return new List<Movie>
			{   new Movie { Id = 1, Name = "Hello World"},
					new Movie { Id = 2, Name = "Maquia: When the Promised Flower Blooms"},
						new Movie { Id = 3, Name = "A Silent Voice"}
			};
		}
		//[Route("Movies/Released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
		//public ActionResult ByReleaseDate(int year, int month)
		//{
		//    return Content(year + "/" + month);
		//}

		//public ActionResult Edit(int id)
		//{

		//    return Content("id=" + id);

		//}

		//public ActionResult Index(int? pageIndex, string sortBy)
		//{
		//    if (!pageIndex.HasValue)
		//        pageIndex = 1;
		//    if (String.IsNullOrEmpty(sortBy))
		//        sortBy = "Name";
		//    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
		//}
	}
}