using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask
{
    [Keyless]
    public partial class BoardMembersFulldatum
    {
        [Column("Board_or_Commission_Name")]
        [StringLength(200)]
        [Unicode(false)]
        public string BoardOrCommissionName { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string EmailAddress { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? MiddleName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string StreetAddress { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string City { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string ZipCode { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Occupation { get; set; } = null!;
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
        public bool Resident { get; set; }
        [Column("UserID")]
        [StringLength(100)]
        [Unicode(false)]
        public string? UserId { get; set; }
        public bool? Confirmed { get; set; }
        [StringLength(302)]
        [Unicode(false)]
        public string? FullName { get; set; }
        public int BoardKey { get; set; }
        public int PersonKey { get; set; }
        [Column(TypeName = "date")]
        public DateTime AppointmentDate { get; set; }
    }
}
