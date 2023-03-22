using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10__02._03._23_
{
    internal class Movie : ICloneable, IComparable<Movie>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Director? director { get; set; }
        public string? Country { get; set; }
        public Genre genre { get; set; }
        public int Year { get; set; }
        public short Rating { get; set; }

        public Movie() { }
        public Movie(string name, string description, Director director, string country, Genre genre, int year, short rating)
        {
            this.Name = name;
            this.Description = description;
            this.director = director;
            this.Country = country;
            this.genre = genre;
            this.Year = year;
            this.Rating = rating;
        }
        public object Clone() => new Movie { Name = Name, Description = Description, director = director, Country = Country, genre = genre, Year = Year, Rating = Rating };
        public int CompareTo(Movie other) => this.Rating.CompareTo(other.Rating);
   

        public enum Genre
        {
            Action,
            Comedy,
            Drama,
            Horror,
            ScienceFiction,
            Fantasy,
            Romance,
            Thriller,
            Western,
            Documentary
        }
        public override string ToString() => $"Movie: {Name} ({Year}), directed by {director?.FirstName}, rated {Rating}/10";
        
    }
}
