using System.ComponentModel.DataAnnotations;

namespace APISemana11A.Models
{
    public class Customers
    {
        [Key]
        public int IdCustomer { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }
    }
}
