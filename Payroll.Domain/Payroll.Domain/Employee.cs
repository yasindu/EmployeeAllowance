using System.ComponentModel.DataAnnotations;

namespace Payroll.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}