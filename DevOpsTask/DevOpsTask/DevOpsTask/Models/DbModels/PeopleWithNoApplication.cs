using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevOpsTask.Models
{
    [Keyless]
    public partial class PeopleWithNoApplication
    {
        [StringLength(302)]
        [Unicode(false)]
        public string? FullName { get; set; }
        public int PersonKey { get; set; }
    }
}
