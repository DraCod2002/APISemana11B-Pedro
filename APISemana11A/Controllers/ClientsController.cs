using APISemana11A.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APISemana11A.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly InvoiceContext _context;

        public CustomersController(InvoiceContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }
        [HttpPost]
        //public void Insert([FromBody] Product product)
        public void Insert(Customers customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        // Update
        [HttpPut]
        public void Update(Customers customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Customers customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return NoContent(); 
        }
    }
}

