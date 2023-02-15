
using Microsoft.EntityFrameworkCore;
using MovieShop.Core;


namespace MovieShop.Infrastructure
{
    public partial class DatabaseContext
    {
        private readonly DateTime _dateTime = new DateTime(2023, 2, 1, 0, 0, 0, DateTimeKind.Local);

        private void SeedData(ModelBuilder modelBuilder)
        {
            SeedCountries(modelBuilder);
        }

        private void SeedCountries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
            new()
            {
                Id = 1,
                Name = "Rambo",
                Genre = Genre.Action,
                CreatedAt = _dateTime,
                ModifiedAt = null,
                DatePublished = new DateTime(1980, 7, 7),
                Description = "Rambo is American solider who fought in Vietnam war. He came back to America, but he was not" +
                " welcomed there. Police officer in one small town prosecuted Rambo from there. When Rambo came back to that town" +
                " he arrested him. Then Rambo escape from prison ...",
                Price = 10.20f
            },
            new()
            {
                Id = 2,
                Name = "Terminator",
                Genre = Genre.Action,
                CreatedAt = _dateTime,
                ModifiedAt = null,
                DatePublished = new DateTime(1983, 7, 7),
                Description = "Year is 2050 and machines rules the world. Many people day after Judgement day. Those who" +
                "survived fight against machines under the rule od John Conor. Machines send robat called Terminator back int the past" +
                " to kill John's mother Sara Conor to prevent the birth of John which would end up war. People aslo send back to past Keyle Reese" +
                " to protect Sara.",
                Price = 14.50f
            });
        }
    }
}
