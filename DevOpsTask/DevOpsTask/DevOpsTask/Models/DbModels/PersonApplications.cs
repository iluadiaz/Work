using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask.Models
{
    [Table("Person_Applications")]
    public partial class PersonApplications
    {
        [Key]
        public int ApplicationKey { get; set; }
        public int BoardCommissionKey { get; set; }
        public int PersonKey { get; set; }
        [Column("Supplemental_Answers")]
        [Unicode(false)]
        public string SupplementalAnswers { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime ApplicationDate { get; set; }
        public bool? Accepted { get; set; }
        public bool? Appointed { get; set; }
        [Column("Expired_Notified")]
        public bool? ExpiredNotified { get; set; }
    }
}
