using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask
{
    [Table("Voluntary_Survey")]
    public partial class VoluntarySurvey
    {
        [Key]
        public int Voluntarykey { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Source { get; set; }
        [Column("Source_Details")]
        [StringLength(200)]
        [Unicode(false)]
        public string? SourceDetails { get; set; }
        public bool? Disability { get; set; }
        [Column("Ethnic_Category")]
        [StringLength(25)]
        [Unicode(false)]
        public string? EthnicCategory { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string? Sex { get; set; }
        [Column("Age_Category")]
        [StringLength(50)]
        [Unicode(false)]
        public string? AgeCategory { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? BoardAppliedFor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateApplied { get; set; }
    }
}
