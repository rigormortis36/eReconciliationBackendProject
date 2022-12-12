using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyservice;

        public CompanyController(ICompanyService companyservice)
        {
            _companyservice = companyservice;
        }

        [HttpGet("getcompanylist")]
        public IActionResult Index()
        {
            var result = _companyservice.GetList();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }
        [HttpPost("addcompany")]
        public IActionResult AddCompany(Company company)
        {
            var result = _companyservice.Add(company);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }
    }
}
