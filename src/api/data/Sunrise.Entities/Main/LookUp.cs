using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunrise.Entities.Main
{
    [Table("LookUps",Schema ="Main")]
    public class LookUp
    {
        [Required]
        [MaxLength(32)]
        public string Name { get; set; }
        [Required]
        public Guid TypeId { get; set; }
        public Guid? ParentId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public LookUpType Type { get; set; }

        [ForeignKey(nameof(ParentId))]
        public LookUp Parent { get; set; }
    }
}
