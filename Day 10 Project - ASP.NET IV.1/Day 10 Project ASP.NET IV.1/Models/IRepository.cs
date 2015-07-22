using System;
using System.Collections.Generic;
namespace Day_10_Project_ASP.NET_IV._1.Models
{
    public interface IRepository
    {
        void CreateMovie(Movie movieToCreate);
        void DeleteMovie(int id);
        Movie FindMovie(int id);
        IList<Movie> ListMovies();
        void UpdateMovie(Movie movieToUpdate);
    }
}
