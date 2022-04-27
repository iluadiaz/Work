using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask.Models
{
    [Keyless]
    public partial class BoardMember
    {
        public int? PersonKey { get; set; }
        public int? BoardCommissionKey { get; set; }
        [Column("Board_or_Commission_Name")]
        [StringLength(200)]
        [Unicode(false)]
        public string? BoardOrCommissionName { get; set; }
        [Column(TypeName = "date")]
        public DateTime AppointmentDate { get; set; }
    }
}
