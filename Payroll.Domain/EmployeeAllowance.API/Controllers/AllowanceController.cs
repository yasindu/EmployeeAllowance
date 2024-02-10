using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using Payroll.Application;
using Payroll.Domain;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAllowance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllowanceController : Controller
    {
        private readonly IAllowanceService _allovanceService;

        public AllowanceController(IAllowanceService allovanceService)
        {
            _allovanceService = allovanceService;
        }

        [Authorize(Roles = "AccessData")]
        [HttpGet]
        public ActionResult<List<Allowance>> Get()
        { 
            var allowance=_allovanceService.GetAllowances();
            return Ok(allowance);
        }

        [Authorize(Roles = "AccessData")]
        [HttpPost]
        public ActionResult Post(List<Allowance> allowances)
        {
            var Allowances = _allovanceService.AddAllowances(allowances);
            return Ok(allowances);
        }

    }
}
