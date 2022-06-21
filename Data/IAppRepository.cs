using System.Collections.Generic;
using movieguideAPI.Models;

namespace movieguideAPI.Data
{
    public interface IAppRepository
    {
        void Add<T> (T entity) where T:class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();

        List<Movie> GetMovies();
        List<Photo> GetPhotosByMovie(int movieId);
        Movie GetMovieById(int movieId);
        Photo GetPhoto(int id);


    }
}