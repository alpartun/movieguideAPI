namespace movieguideAPI.Dtos
{
    public class MovieForListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public int Point { get; set; }
        public string Category { get; set; }
    }
}