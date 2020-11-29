using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyAssignment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CompanyAssignment.Requests;

namespace CompanyAssignment.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository repository;
        public EmployeeController(IEmployeeRepository repository)
        {
            this.repository = repository;

        }
        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(AddEmployeeRequest data)
        {
            return Ok(repository.AddEmployee(data));
        }
        [HttpPost("AddProject")]
        public IActionResult AddProject(AddProjectRequest data)
        {
            return Ok(repository.AddProject(data));
        }
        [HttpPost("AddRelationship")]
        public IActionResult AddRelation(RelationshipRequest data)
        {
            return Ok(repository.AddRelation(data));
        }
        //[HttpGet("GetEmployeeByProjectId")]
        //public IActionResult GetEmployeeByProject(int projectid)
        //{
        //    if (projectid < 0)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(repository.GetEmployeeByProjectId(projectid));

        //}
        [HttpGet("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var result = repository.GetEmployeeById(id);
            if (result== null)
            {
                return BadRequest();
            }
            return Ok(result);

        }
        [HttpGet("GetProjectById/{id}")]
        public IActionResult GetProjectById(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            return Ok(repository.GetProjectById(id));

        }
        [HttpGet("GetAllProject")]
        public IActionResult GetAllProjects()
        {
           
            return Ok(repository.GetAllProjects());

        }
        [HttpGet("GetAllEmployee")]
        public IActionResult GetAllEmployees()
        {

            return Ok(repository.GetAllEmployees());

        }
        [HttpGet("GetAllRelationships")]
        public IActionResult GetAllRelationships()
        {

            return Ok(repository.GetAllRelationships());

        }


        [HttpDelete("DeleteEmployeeById")]
        public IActionResult DeleteEmployeeById(int employeeId)
        {
            if (employeeId < 0)
            {
                return BadRequest();
            }
            return Ok(repository.DeleteEmployeeById(employeeId));

        }
        [HttpDelete("DeleteProjectById")]
        public IActionResult DeleteProjectById(int projectId)
        {
            if (projectId < 0)
            {
                return BadRequest();
            }
            return Ok(repository.DeleteProjectById(projectId));

        }


        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee(AddEmployeeRequest data)
        {
            return Ok(repository.UpdateEmployee(data));


        }


    }
}
