using System.ComponentModel.DataAnnotations;

namespace GuestBookGit.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Pwd { get; set; }
    }
}
