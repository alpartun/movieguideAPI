using System.Collections.Generic;

namespace movieguideAPI.Models
{
    public class User
    {
        public User()
        {
            Movies = new List<Movie>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Movie> Movies { get; set; }
        // Userin ekledigi movieler var
    }
}