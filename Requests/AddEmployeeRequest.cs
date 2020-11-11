using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyAssignment.Requests
{
    public class AddEmployeeRequest
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Manager { get; set; }

        public int ProjectId { get; set; }
    }
}
