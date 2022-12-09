using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HealthyLife.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required, Display(Name = "SubjectName")]
        public string SubjectName { get; set; } = string.Empty;
    }
}
