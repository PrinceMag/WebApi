using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApi.Models;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<student> GetStudents() {
            return CollegeRepository.Student;
        }

        [HttpGet("{id:int}")]
        public student GetStudentById(int id)
        {
            return CollegeRepository.Student.Where(n => n.Id == id).FirstOrDefault();
        }


    }
}
