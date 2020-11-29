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
        string AddEmployee(AddEmployeeRequest request);
        string AddProject(AddProjectRequest request);
        string AddRelation(RelationshipRequest request);
        List<Project> GetProjects(int projectId);

       // List<Employee> GetEmployeeByProjectId(int projectId);

        List<Employee> GetEmployeeById(int employeeId);
        List<Project> GetProjectById(int projectId);
        bool UpdateEmployee(AddEmployeeRequest request);
        //bool UpdateProject(AddProjectRequest request);
        string DeleteEmployeeById(int employeeId);
        string DeleteProjectById(int projectId);
        public List<Project> GetAllProjects();
        public List<Employee> GetAllEmployees();
        public List<Relationship> GetAllRelationships();

    }
}
