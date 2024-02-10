using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Domain
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
