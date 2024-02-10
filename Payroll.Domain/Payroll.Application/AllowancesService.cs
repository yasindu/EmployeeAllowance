using Payroll.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Application
{
    public class AllowancesService : IAllowanceService
    {
        private readonly IAllovanceRepository _allovanceRepository;

        public AllowancesService(IAllovanceRepository allovanceRepository)
        {
            _allovanceRepository = allovanceRepository;
        }


        public List<Allowance> AddAllowances(List<Allowance> allowances)
        {
            _allovanceRepository.AddAllowances(allowances);
            return allowances;
        }

        public List<Allowance> GetAllowances()
        {
            var allowances=_allovanceRepository.GetAllowances();
            return allowances;
        }
    }
}
