using ITBoostUp.BussinessLayer.IRepository;
using ITBoostUp.BussinessLayer.Model;
using Microsoft.AspNetCore.Mvc;

namespace ITBoostUP.Presentation.Controllers
{
    public class CompanyController : Controller
    {
        ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public IActionResult Company()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Company company)
        {
            _companyRepository.Create(company);
            return View();
        }
    }
}
