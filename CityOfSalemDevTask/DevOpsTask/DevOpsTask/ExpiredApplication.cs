using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask
{
    [Keyless]
    public partial class ExpiredApplication
    {
        [StringLength(302)]
        [Unicode(false)]
        public string? FullName { get; set; }
        [Column("Board_or_Commission_Name")]
        [StringLength(200)]
        [Unicode(false)]
        public string BoardOrCommissionName { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime ApplicationDate { get; set; }
        public int? Age { get; set; }
        public int ApplicationKey { get; set; }
        public int PersonKey { get; set; }
        [Column("Expired_Notified")]
        public bool? ExpiredNotified { get; set; }
        public bool? Appointed { get; set; }
    }
}
