using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace HealthyLife.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required, Display(Name = "CourseName")]
        public string CourseName { get; set; } = string.Empty;

        [Required, Display(Name = "CourseDescription")]
        public string CourseDescription { get; set; } = string.Empty;

        [Required, Display(Name = "CourseDescriptionShort")]
        public string CourseDescriptionShort { get; set; } = string.Empty;

        [Display(Name = "PathToPhoto")]
        public string PathToPhoto { get; set; } = string.Empty;

        [Required, Display(Name = "Price")] // -1 (ХЕКА+) , 0 (Безкоштовно)  
        public decimal Price { get; set; }

        [Required, Display(Name = "Rating")]
        public double Rating { get; set; }

        [Required, Display(Name = "LikedNumber")]
        public int LikedNumber { get; set; }

        [Required, Display(Name = "Duration")]
        public string Duration { get; set; } = string.Empty;

        [Required, Display(Name = "TimesSelected")]
        public int TimesSelected { get; set; }

        [Required, Display(Name = "SubjectId")]
        public int SubjectId { get; set; }

        [Required, Display(Name = "AuthorId")]
        public int AuthorId { get; set; }


        public virtual Subject ?Subject { get; set; }
        public virtual Author ?Aurhor { get; set; }
    }
}
