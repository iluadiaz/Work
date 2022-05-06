using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask.Models
{
    [Table("M_BoardsandCommissions")]
    public partial class MBoardsandCommissions
    {
        [Key]
        public int BoardCommissionKey { get; set; }
        [Column("Board_or_Commission_Name")]
        [StringLength(200)]
        [Unicode(false)]
        public string BoardOrCommissionName { get; set; } = null!;
        [Column("ApplicationXML")]
        [Unicode(false)]
        public string? ApplicationXml { get; set; }
        [Unicode(false)]
        public string? Description { get; set; }
        [Column("Default_Contact_Name")]
        [StringLength(100)]
        [Unicode(false)]
        public string? DefaultContactName { get; set; }
        [Column("Default_Email")]
        [StringLength(100)]
        [Unicode(false)]
        public string? DefaultEmail { get; set; }
        [Column("Default_Phone")]
        [StringLength(100)]
        [Unicode(false)]
        public string? DefaultPhone { get; set; }
        [Column("Default_Web")]
        [StringLength(100)]
        [Unicode(false)]
        public string? DefaultWeb { get; set; }
        [Column("Appointment_Type")]
        [StringLength(100)]
        [Unicode(false)]
        public string? AppointmentType { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Authority { get; set; }
        [Column(TypeName = "decimal(10, 3)")]
        public decimal? TermLength { get; set; }
        [Column("Special_Requirements")]
        [StringLength(200)]
        [Unicode(false)]
        public string? SpecialRequirements { get; set; }
        [Column("Staff_Contact")]
        [StringLength(100)]
        [Unicode(false)]
        public string? StaffContact { get; set; }
        public bool? Active { get; set; }
    }
}
