using Payroll.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Application
{
    public interface IAllowanceService
    {
        List<Allowance> GetAllowances();
        List<Allowance> AddAllowances(List<Allowance> allowances);
    }
}
 