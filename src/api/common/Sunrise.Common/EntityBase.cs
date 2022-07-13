﻿using System.ComponentModel.DataAnnotations.Schema;
namespace Sunrise.Common;
public class EntityBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// Id'nin kendiliğinden atanmasını sağlar
    public Guid Id { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? ModifiedBy { get; set; }
}

