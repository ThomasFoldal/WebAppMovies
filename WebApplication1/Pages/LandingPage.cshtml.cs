using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class LandingPageModel : PageModel 
    {
        [BindProperty]
        public List<Movie> Movies {  get; set; }
        public void OnGet()
        {
            Movies = new List<Movie>() { new Movie { Id = 0, ImageUrl = "/Images/avatar.jpg" }, new Movie { Id = 1, ImageUrl = "/Images/avatar.jpg" }, new Movie { Id = 2, ImageUrl = "" }, new Movie { Id = 3, ImageUrl = "" }, new Movie { Id = 4, ImageUrl = "" } };
        }

        public void RedirectPage(Movie movie)
        {
            RedirectToPage("DetailPage", "SingleOrder", movie);
        }


    }
}
