using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public enum ExerciseType
    {
        Name
    }
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        public int SignNumber { get; set; }
        public string? Description { get; set; }
        public string? Rotation { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Track>? Tracks { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public Equipment? Equipment { get; set; }
    }
}