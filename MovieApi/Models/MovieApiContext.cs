using Microsoft.EntityFrameworkCore;

namespace MovieApi.Models
{
  public class MovieApiContext : DbContext
  {
    public MovieApiContext(DbContextOptions<MovieApiContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Movie>()
          .HasData(
              new Movie { MovieId = 1, Name = "Dune", Director = "Denis Villeneuve", Genre = "Sci-Fi", Synopsis = "Paul Atreides, a brilliant and gifted young man born into a great destiny beyond his understanding, must travel to the most dangerous planet in the universe to ensure the future of his family and his people. As malevolent forces explode into conflict over the planet's exclusive supply of the most precious resource in existence, only those who can conquer their own fear will survive", RottenTom = 90},
              new Movie { MovieId = 2, Name = "Nomadland", Director = "Cloe Zhao", Genre = "Drama", Synopsis = "A woman embarks on a journey through the American West after losing everything during the recession.", RottenTom = 82 },
              new Movie { MovieId = 3, Name = "Clifford The Big Red Dog", Director = "Walt Becker", Genre = "Kids & Family", Synopsis = "When middle-schooler Emily Elizabeth (Darby Camp) meets a magical animal rescuer (John Cleese) who gifts her a little, red puppy, she never anticipated waking up to find a giant ten-foot hound in her small New York City apartment. While her single mom (Sienna Guillory) is away for business, Emily and her fun but impulsive uncle Casey (Jack Whitehall) set out on an adventure that will keep you on the edge-of-your-seat as our heroes take a bite out of the Big Apple. Based on the beloved Scholastic book character, Clifford will teach the world how to love big!", RottenTom = 94 },
              new Movie { MovieId = 4, Name = "Knives Out", Director = "Rian Johnson", Genre = "Darma Mystery", Synopsis = "Knives Out sharpens old murder-mystery tropes with a keenly assembled suspense outing that makes brilliant use of writer-director Rian Johnson's stellar ensemble", RottenTom = 92 },
              new Movie { MovieId = 5, Name = "A Quiet Place Part II", Director = "John Krasinski", Genre = "Horror", Synopsis = "Following the deadly events at home, the Abbott family must now face the terrors of the outside world as they continue their fight for survival in silence. Forced to venture into the unknown, they quickly realize that the creatures that hunt by sound are not the only threats that lurk beyond the sand path", RottenTom = 92 },
              new Movie { MovieId = 6, Name = "Father of the Year", Director = "Tyler Spindel", Genre = "Comedy", Synopsis = "Worst movie ever", RottenTom = 1 }
          );
    }

    public DbSet<Movie> Movies { get; set; }
  }
}