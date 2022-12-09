using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HealthyLife.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required, Display(Name = "AuthorName")]
        public string AuthorName { get; set; } = string.Empty;
    }
}
