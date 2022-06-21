using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using movieguideAPI.Models;

namespace movieguideAPI.Data
{
    public class AppRepository:IAppRepository
    {
        private DataContext _context;

        public AppRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T:class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public List<Movie> GetMovies()
        {
            // Include(p=>p.Photos)
            var movies = _context.Movies.Include(p=>p.Photos).ToList();
            return movies;
        }

        public List<Photo> GetPhotosByMovie(int movieId)
        {
            var photos = _context.Photos.Where(p => p.MovieId == movieId).ToList();
            return photos;
        }

        public Movie GetMovieById(int movieId)
        {
            var city = _context.Movies.Include(c=>c.Photos).FirstOrDefault(p=>p.Id==movieId);
            return city;

        }

        public Photo GetPhoto(int id)
        {
            var photo = _context.Photos.FirstOrDefault(p => p.Id == id);
            return photo;
        }
    }
}