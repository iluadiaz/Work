using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask.Models
{
    public partial class Role
    {
        public Role()
        {
            UsersInRoles = new HashSet<UsersInRole>();
        }

        [Key]
        public int RoleId { get; set; }
        [StringLength(256)]
        public string RoleName { get; set; } = null!;
        [StringLength(256)]
        public string? Description { get; set; }

        [InverseProperty("Role")]
        public virtual ICollection<UsersInRole> UsersInRoles { get; set; }
    }
}
