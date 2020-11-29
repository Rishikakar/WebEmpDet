using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyAssignment.Models
{
    public class Relationship
    {
        [Key]
        public int RelationId { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        [ForeignKey("EmployeeId")]
         public virtual Employee Employee { get; set; }
        [ForeignKey("ProjectId")]
         public virtual Project Project { get; set; }

    }
}
