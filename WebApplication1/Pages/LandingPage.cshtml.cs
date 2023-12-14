using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class LandingPageModel : PageModel
    {
        [BindProperty]
        public List<Movie> Movies { get; set; }
        private readonly MyDatabaseContext _dbContext;
        public LandingPageModel(MyDatabaseContext databasecontext)
        {
            _dbContext = databasecontext;
        }

        public void OnGet()
        {
            if (_dbContext.DBMovies.Count() == 0)
            {

                Movies = new List<Movie>() {
                new Movie { Id = 1, ImageUrl = "/Images/BackToTheFuture.jpg", Title = "Back to the future", Summery = "vgnæakjfngklasjdfnblæajdnfgh"},
                new Movie { Id = 2, ImageUrl = "/Images/Barbie.jpg", Title = "Barbie", Summery = "faklsjdhglkajfghaijfsdgh"},
                new Movie { Id = 3, ImageUrl = "/Images/Oppenheimer.png", Title = "Oppenheimer", Summery = "pdnfbkiahdfkbjnadfg"},
                new Movie { Id = 4, ImageUrl = "/Images/Saw.jpg", Title = "Saw", Summery = "sdfgihadfiguhasepirog"},
                new Movie { Id = 5, ImageUrl = "/Images/avatar.jpg", Title = "Avatar the way of water", Summery = "fsdjfgasjglækasjdlgan<sgjs"}};
                foreach (Movie m in Movies)
                {
                    _dbContext.Add(m);
                }
                _dbContext.SaveChanges();
            }

            Movies = _dbContext.DBMovies.Take(5).ToList();

            //Movies = _dbContext.DBMovies.Where(x => x.Categories == );

        }

        public void RedirectPage(Movie movie)
        {
            RedirectToPage("DetailPage", "SingleOrder", movie);
        }


    }
}
