using System.Collections.Generic;
using movieguideAPI.Models;

namespace movieguideAPI.Dtos
{
    public class MovieForDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Point { get; set; }
        public string Category { get; set; }

        public List<Photo> Photos { get; set; }
    }
}