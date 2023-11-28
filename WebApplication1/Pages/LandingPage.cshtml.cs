using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class LandingPageModel : PageModel 
    {
        [BindProperty]
        public List<Movie> movies {  get; set; }
        public void OnGet()
        {
            movies = new List<Movie>() { new Movie { Id = 0, ImageUrl = ""}, new Movie { Id = 1, ImageUrl = "Avatar-The-Way-of-Water.jpg" }, new Movie { Id = 2, ImageUrl = "" }, new Movie { Id = 3, ImageUrl = "" }, new Movie { Id = 4, ImageUrl = "" } };
        }
    }
}
