using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieProject.Models;
using MovieProject.DAL;

namespace MovieProject.Controllers
{
    public class HomeController : Controller
    {
        private MovieDBContext _DbContext = new MovieDBContext();

        public ActionResult Index()
        {
            // TODO - Use Linq for the following:
            //1. get top one genere
             //  var topGenre = (from n in _DbContext.Genre select new { n.Name} ).First();
            //2. get last genere
             //  var lastGenre = (from n in _DbContext.Genre select new { n.Name }).Last();
            //3. get all genere order by name descending
               var allGenre = (from n in _DbContext.Genre select new { n });
            //4. get list of genere names into list<string>
               var query = (from n in _DbContext.Genre select n);
               List<Genre> genreList = query.ToList<Genre>();             
            //5. get list of movies for genere id=1 and id=3 only

               List<Movie> genreListById = (from n in _DbContext.Movie where n.GenreID == 1 || n.GenreID == 3 select n).ToList<Movie>();

                     
            var two = "";
            List<Genre> Glist = new List<Genre>();
            // serviceplan => vehilce => services => parts
            // sp = _dbcotext.serviceplan.Include("vehicle.services.parts")- eg. of eager loading related table(model)- good for performance but 
            // need to setLazyLoadingEnabled to false. 
           // Glist = _DbContext.Genre.Include("Movie").ToList();     
       
           // Glist = _DbContext.Genre.ToList(); // eg of lazy loading -it loads movie object by default (due to d foreign key relationship)- not good fo performance
            //Glist = _DbContext.Genre.ToList();
            //List<Movie> MovieList = new List<Movie>();
            //MovieList = _DbContext.Movie.ToList();

            return View(genreListById);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}