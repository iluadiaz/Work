using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask.Models
{
    public partial class UsersInRole
    {
        [Key]
        public int PersonKey { get; set; }
        [Key]
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("UsersInRoles")]
        public virtual Role Role { get; set; } = null!;
    }
}
