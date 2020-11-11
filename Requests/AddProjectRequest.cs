using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyAssignment.Requests
{
    public class AddProjectRequest
    {
        public string ProjectName { get; set; }
        public int ProjectHours { get; set; }
       // public int Id { get; internal set; }
    }
}
