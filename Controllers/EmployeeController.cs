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
        [HttpGet("GetEmployeeByProjectId")]
        public IActionResult GetEmployeeByProject(int projectid)
        {
            if (projectid < 0)
            {
                return BadRequest();
            }
            return Ok(repository.GetEmployeeByProject(projectid));

        }
        [HttpGet("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            return Ok(repository.GetEmployeeById(id));

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


        [HttpDelete("DeleteEmployeeById")]
        public IActionResult DeleteEmployeeById(int employeeId)
        {
            if (employeeId < 0)
            {
                return BadRequest();
            }
            return Ok(repository.DeleteEmployee(employeeId));

        }
        [HttpDelete("DeleteProjectById/{id}")]
        public IActionResult DeleteProjectById(int projectId)
        {
            if (projectId < 0)
            {
                return BadRequest();
            }
            return Ok(repository.DeleteProject(projectId));

        }


        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee(AddEmployeeRequest data)
        {
            return Ok(repository.UpdateEmployee(data));


        }


    }
}
