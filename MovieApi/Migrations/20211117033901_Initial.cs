using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Director = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Genre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Synopsis = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    RottenTom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Director", "Genre", "Name", "RottenTom", "Synopsis" },
                values: new object[,]
                {
                    { 1, "Denis Villeneuve", "Sci-Fi", "Dune", 90, "Paul Atreides, a brilliant and gifted young man born into a great destiny beyond his understanding, must travel to the most dangerous planet in the universe to ensure the future of his family and his people. As malevolent forces explode into conflict over the planet's exclusive supply of the most precious resource in existence, only those who can conquer their own fear will survive" },
                    { 2, "Cloe Zhao", "Drama", "Nomadland", 82, "A woman embarks on a journey through the American West after losing everything during the recession." },
                    { 3, "Walt Becker", "Kids & Family", "Clifford The Big Red Dog", 94, "When middle-schooler Emily Elizabeth (Darby Camp) meets a magical animal rescuer (John Cleese) who gifts her a little, red puppy, she never anticipated waking up to find a giant ten-foot hound in her small New York City apartment. While her single mom (Sienna Guillory) is away for business, Emily and her fun but impulsive uncle Casey (Jack Whitehall) set out on an adventure that will keep you on the edge-of-your-seat as our heroes take a bite out of the Big Apple. Based on the beloved Scholastic book character, Clifford will teach the world how to love big!" },
                    { 4, "Rian Johnson", "Darma Mystery", "Knives Out", 92, "Knives Out sharpens old murder-mystery tropes with a keenly assembled suspense outing that makes brilliant use of writer-director Rian Johnson's stellar ensemble" },
                    { 5, "John Krasinski", "Horror", "A Quiet Place Part II", 92, "Following the deadly events at home, the Abbott family must now face the terrors of the outside world as they continue their fight for survival in silence. Forced to venture into the unknown, they quickly realize that the creatures that hunt by sound are not the only threats that lurk beyond the sand path" },
                    { 6, "Tyler Spindel", "Comedy", "Father of the Year", 1, "Worst movie ever" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
