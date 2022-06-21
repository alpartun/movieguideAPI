using System.Collections.Generic;

namespace movieguideAPI.Models
{
    public class Movie
    {
        public Movie()
        {
            Photos = new List<Photo>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int Point { get; set; }
        public string Category { get; set; }
        public List<Photo> Photos { get; set; }
        public User User { get; set; }
        // Filmin ekleyene tek bir userdir.
        //Filmin birden cok fotografil olabilir.
    }
}