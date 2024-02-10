using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Payroll.Domain
{
    public class Allowance
    {
        [Key]
        public int AllowanceId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public DateTime Date { get; set; }

        public double Amount { get; set; }

        [Required]
        public string Status { get; set; }

    }
}