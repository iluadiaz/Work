using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask
{
    [Keyless]
    public partial class AppointedApp
    {
        [StringLength(100)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [Column("Board_or_Commission_Name")]
        [StringLength(200)]
        [Unicode(false)]
        public string BoardOrCommissionName { get; set; } = null!;
        public int PersonKey { get; set; }
        public int ApplicationKey { get; set; }
        public bool? Accepted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ApplicationDate { get; set; }
        public bool? Appointed { get; set; }
    }
}
