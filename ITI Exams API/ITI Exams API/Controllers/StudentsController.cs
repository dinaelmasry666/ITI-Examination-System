using ITI_Exams_API.Models;
using ITI_Exams_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITI_Exams_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var result = await _studentService.GetAllStudents();
            if (result == null) return NotFound(result);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student?>> GetSingleStudent(int id)
        {
            var result = await _studentService.GetSingleStudent(id);

            if(result == null) return NotFound(result);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudent(Student Student)
        {
            var result = await _studentService.AddStudent(Student);

            if (result == null) return BadRequest(result);
            return Ok(result);
        }
    }
}
