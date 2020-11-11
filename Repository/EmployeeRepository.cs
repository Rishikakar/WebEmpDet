using CompanyAssignment.Models;
using CompanyAssignment.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyAssignment.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _db;
        public EmployeeRepository(EmployeeDbContext db)
        {
            this._db = db;
        }

        public bool AddEmployee(AddEmployeeRequest request)
        {
            if (request != null)
            {

                Employee employee = new Employee();
               
                employee.EmployeeName = request.EmployeeName;
                employee.ProjectId = request.ProjectId;
                employee.Manager = request.Manager;

                _db.Employees.Add(employee);
                _db.SaveChanges();

                return true;


            }
            return false;
        }

        public bool AddProject(AddProjectRequest request)
        {
            if (request != null)
            {
                Project project = new Project();
           
                project.ProjectName = request.ProjectName;
                project.ProjectHours = request.ProjectHours;
              

                _db.Projects.Add(project);
                _db.SaveChanges();

                return true;


            }
            return false;

        }

        public List<Employee> GetEmployeeById(int employeeId)
        {
            List<Employee> employees = new List<Employee>();
            employees = _db.Employees.Where(a => a.EmployeeId == employeeId).ToList();
            return employees;
        }
        public List<Project> GetProjectById(int projectId)
        {
            List<Project> projects = new List<Project>();
            projects = _db.Projects.Where(a => a.ProjectId == projectId).ToList();
            return projects;
        }

        public bool DeleteEmployee(int employeeId)
          {
              Employee employee = _db.Employees.Find(employeeId);
        _db.Employees.Remove(employee);
              _db.SaveChanges();
            return true;
          }

    public bool DeleteProject(int projectId)
    {
        Project project = _db.Projects.Find(projectId);
        _db.Projects.Remove(project);
        _db.SaveChanges();
            return true;
          }

    public List<Employee> GetEmployeeByProject(int projectId)
        {
            List<Employee> employees = new List<Employee>();
            employees = _db.Employees.Where(a => a.ProjectId == projectId).ToList();
            return employees;

        }

        public List<Project> GetProjects(int projectId)
        {
            List<Project> projects = new List<Project>();
            projects = _db.Projects.ToList();
            return projects;


        }

        public bool UpdateEmployee(AddEmployeeRequest request)
        {
            if (request != null)
            {


                Employee employees = new Employee();
                Employee emp = _db.Employees.SingleOrDefault(a => a.EmployeeId == request.Id);
                 emp.EmployeeName = request.EmployeeName;
                emp.Manager = request.Manager;
               
                _db.SaveChanges();

                return true;

            }

            return false;
        }

        //public bool UpdateProject(AddProjectRequest request)
        //{
        //    if (request != null)
        //    {
        //        Project projects = new Project();
        //        projects.ProjectId = request.Id;
        //        projects.ProjectName = request.ProjectName;
        //        projects.ProjectHours = request.ProjectHours;
        //        _db.Projects.Update(projects);
        //        _db.SaveChanges();

        //        return true;

        //    }

        //    return false;
        //}
    }


}
