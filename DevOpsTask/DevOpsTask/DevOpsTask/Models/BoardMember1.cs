using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask.Models
{
    [Table("BoardMembers")]
    public partial class BoardMember1
    {
        [Key]
        public int BoardMemberkey { get; set; }
        public int PersonKey { get; set; }
        public int BoardKey { get; set; }
        [Column(TypeName = "date")]
        public DateTime AppointmentDate { get; set; }
    }
}
