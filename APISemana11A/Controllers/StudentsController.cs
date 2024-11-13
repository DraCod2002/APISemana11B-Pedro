using APISemana11A.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APISemana11A.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly InvoiceContext _context;

        public CoursesController(InvoiceContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }
        [HttpPost]
        //public void Insert([FromBody] Product product)
        public void Insert(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
        // Update
        [HttpPut]
        public void Update(Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
            _context.SaveChanges();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Course course)
        {
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
