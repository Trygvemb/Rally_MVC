using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Comment { get; set; }
        public string? Location { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        // Navigation Properties
        [ForeignKey("AppUsers")]
        public int AppUserId { get; set; }       
        public AppUser? AppUser { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Exercise>? Exercises { get; set; }

    }
}