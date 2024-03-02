using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{

    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Rotation { get; set; }
        public string? Location { get; set; }
        [ForeignKey("EnumValues")]
        public int EquipmentTypeId { get; set; }
        public EnumValue? EquipmentType { get; set; }
        public ICollection<Exercise>? Exercises { get; set; }
    }
}