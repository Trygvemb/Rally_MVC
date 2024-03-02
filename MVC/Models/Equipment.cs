using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public enum EquipmentType
    {
        Name
    }
    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Rotation { get; set; }
        public string? Location { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public ICollection<Exercise>? Exercises { get; set; }
    }
}