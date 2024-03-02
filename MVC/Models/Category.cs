using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public enum CategoryType
    {
        Name
    }
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Rules { get; set; }
        public int NumberOfExercises { get; set; }
        public CategoryType CategoryType { get; set; }
        public ICollection<Track>? Tracks { get; set; }
        public ICollection<Exercise>? Exercises { get; set; }
    }
}