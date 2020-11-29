using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyAssignment.Models
{
    public class Employee
    {

    
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Manager { get; set; }
       // public Project Project { get; set; }
       // public int ProjectId { get; set; }
        public virtual ICollection<Relationship>Relationships { get; set; }
      
    }
}
