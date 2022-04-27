using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask.Models
{
    [Keyless]
    public partial class PersonApplicationsDetail
    {
        [Column("Board_or_Commission_Name")]
        [StringLength(200)]
        [Unicode(false)]
        public string? BoardOrCommissionName { get; set; }
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
        public int ApplicationKey { get; set; }
        public int BoardCommissionKey { get; set; }
        public int PersonKey { get; set; }
        [Column("Supplemental_Answers")]
        [Unicode(false)]
        public string SupplementalAnswers { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime ApplicationDate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? EmailAddress { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Password { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? FirstName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? MiddleName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? LastName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? StreetAddress { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? City { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? ZipCode { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Occupation { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? BusinessName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? BusinessStreetAddress { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? BusinessCity { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? BusinessZipCode { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? HomeTelephone { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? BusinessTelephone { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CellPhone { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? FaxNumber { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? License { get; set; }
        [StringLength(4)]
        [Unicode(false)]
        public string? Age { get; set; }
        public bool? Resident { get; set; }
        [Column("UserID")]
        [StringLength(100)]
        [Unicode(false)]
        public string? UserId { get; set; }
        public bool? Confirmed { get; set; }
        [StringLength(302)]
        [Unicode(false)]
        public string? FullName { get; set; }
        public bool? Accepted { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Ward { get; set; }
        public bool? Appointed { get; set; }
    }
}
