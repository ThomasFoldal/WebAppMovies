using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class DetailPageModel : PageModel
    {
        public Movie Movie{ get; set; }
        public void OnGet()
        {
        }
        public void OnSingleOrder(Movie movie)
        {
            Movie = movie;
        }
    }
}
