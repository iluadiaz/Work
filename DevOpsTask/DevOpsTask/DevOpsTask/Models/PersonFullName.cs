using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask.Models
{
    [Keyless]
    public partial class PersonFullName
    {
        [StringLength(302)]
        [Unicode(false)]
        public string? FullName { get; set; }
        public int PersonKey { get; set; }
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
        public bool Resident { get; set; }
        [Column("UserID")]
        [StringLength(100)]
        [Unicode(false)]
        public string? UserId { get; set; }
        [Column("AccessID")]
        public int? AccessId { get; set; }
        public bool? Confirmed { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Ward { get; set; }
    }
}
