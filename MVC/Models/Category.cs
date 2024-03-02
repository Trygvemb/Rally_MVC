using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Rules { get; set; }
        public int NumberOfExercises { get; set; }
        [ForeignKey("EnumValues")]
        public int CategoryTypeId { get; set; }
        public EnumValue? CategoryType { get; set; }
        public ICollection<Track>? Tracks { get; set; }
        public ICollection<Exercise>? Exercises { get; set; }
    }
}