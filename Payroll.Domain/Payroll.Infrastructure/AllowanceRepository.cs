using Payroll.Application;
using Payroll.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Infrastructure
{
    public class AllowanceRepository : IAllovanceRepository
    {
        private readonly AllowanceDbContext _allowanceDbContext;

        public AllowanceRepository(AllowanceDbContext allowanceDbContext)
        {
            _allowanceDbContext = allowanceDbContext;
        }

        public List<Allowance> AddAllowances(List<Allowance> allowances)
        {
            _allowanceDbContext.Allowances.AddRange(allowances);
            _allowanceDbContext.SaveChanges();
            return allowances;
        }

        public List<Allowance> GetAllowances()
        {
            return _allowanceDbContext.Allowances.ToList();
        }
    }
}
