namespace WebApplication1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        //public List<string>? Categories { get; set; } = null;
        public string? Summery { get; set; }
    }
}
