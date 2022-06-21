using System;

namespace movieguideAPI.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int MovieId { get; set; }
        public bool IsMain { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }
        public Movie Movie { get; set; }
    }
}