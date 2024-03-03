using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        public int SignNumber { get; set; }
        public string? Description { get; set; }
        public string? Rotation { get; set; }

        // Navigation Properties
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [ForeignKey("EnumValues")]
        public int ExerciseTypeId { get; set; }
        public EnumValue? ExerciseType { get; set; }
        public Equipment? Equipment { get; set; }
        public ICollection<Track>? Tracks { get; set; }
    }
}