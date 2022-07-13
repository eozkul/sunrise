using Sunrise.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunrise.Entities.Main;

[Table("LookUpTypes", Schema = "Main")]
public class LookUpType:EntityBase
{
    [Required]
    [MaxLength(32)]
    public string Name { get; set; }
}
