using CompanyAssignment.Models;
using CompanyAssignment.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyAssignment.Repository
{
    public interface IEmployeeRepository
    {
        bool AddEmployee(AddEmployeeRequest request);
        bool AddProject(AddProjectRequest request);
        List<Project> GetProjects(int projectId);

        List<Employee> GetEmployeeByProject(int projectId);

        List<Employee> GetEmployeeById(int employeeId);
        List<Project> GetProjectById(int projectId);
        bool UpdateEmployee(AddEmployeeRequest request);
        //bool UpdateProject(AddProjectRequest request);
        bool DeleteEmployee(int employeeId);
        bool DeleteProject(int projectId);
    }
}
