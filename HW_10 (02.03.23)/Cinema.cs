using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10__02._03._23_
{
    internal class Cinema : IEnumerable<Movie>
    {
        public Movie[] movies;
        public string address { get; set; }

        public Cinema(Movie[] movies, string address)
        {
            this.movies = movies;
            this.address = address;
        }

        public void Sort() => Array.Sort(movies);
        public void Sort(IComparer<Movie> comparer) => Array.Sort(movies, comparer);      
        public void SortByRating() => Array.Sort(movies, new CompareByRating());
        public void SortByYear() => Array.Sort(movies, new CompareByYear());

        public IEnumerator<Movie> GetEnumerator()
        {
            foreach (Movie movie in movies)
            {
                yield return movie;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
    class CompareByRating : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y) => y.Rating.CompareTo(x.Rating); 
    }

    class CompareByYear : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y) => x.Year.CompareTo(y.Year);
    }
    
}
