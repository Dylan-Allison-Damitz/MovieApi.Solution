namespace MovieApi.Models
{
  public class Movie
  {
    public int MovieId { get; set; }
    public string Name { get; set; }
    public string Director { get; set; }
    public string Genre { get; set; }
    public string Synopsis { get; set; }
    public int RottenTom { get; set; }
  }
}