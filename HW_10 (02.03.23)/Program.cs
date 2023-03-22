using HW_10__02._03._23_;

Director director1 = new Director { FirstName = "Steven", LastName = "Spielberg" };
Director director2 = new Director { FirstName = "Christopher", LastName = "Nolan" };
Director director3 = new Director { FirstName = "Quentin", LastName = "Tarantino" };

Movie movie1 = new Movie("Jurassic Park", "An adventure 65 million years in the making.", director1, "USA", Movie.Genre.ScienceFiction, 1993, 9);
Movie movie2 = new Movie("Inception", "Your mind is the scene of the crime.", director2, "USA", Movie.Genre.ScienceFiction, 2010, 8);
Movie movie3 = new Movie("Pulp Fiction", "Just because you are a character doesn't mean you have character.", director3, "USA", Movie.Genre.Thriller, 1994, 9);

Cinema cinema = new Cinema(new Movie[] { movie1, movie2, movie3 }, "123 Main Street");

// Сортування за роком випуску
cinema.SortByYear();

Console.WriteLine("\nMovies sorted by year:");
foreach (Movie movie in cinema) Console.WriteLine("\t"+ movie);

Console.WriteLine();
Console.WriteLine(new string('-', 50));
// Сортування за рейтингом
cinema.SortByRating();

Console.WriteLine("\nMovies sorted by rating:");
foreach (Movie movie in cinema) Console.WriteLine("\t"+ movie);
