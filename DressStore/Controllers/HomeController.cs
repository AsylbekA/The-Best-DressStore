using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DressStore.Models;
using DressStore.Models.ViewModels;

namespace DressStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Dress> _dresses;
        private List<Company> companies;
        public HomeController(ILogger<HomeController> logger)
        {
            Company Adidass = new Company(1, "Adidass", "USA");
            Company Nike=new Company(2,"Nike","USA");
            Company Serper=new Company(3,"Serper","Kazakhstan");

            companies=new List<Company> {Adidass,Nike,Serper };
            _dresses=new List<Dress>
            {
                new Dress(1,"Short",500,Adidass),
                new Dress(2,"Shoes",1000,Adidass),
                new Dress(3,"Jackets",2500,Nike),
                new Dress(4,"Bag",2000,Nike),
                new Dress(5,"Pants",2500,Serper)

            };

            _logger = logger;
        }

        public IActionResult Index(int?companyId)
        {
            List<CompanyModel> companyModels = companies.Select(c => new CompanyModel(c.Id, c.Name)).ToList();
            companyModels.Insert(0,new CompanyModel(0,"All"));
            IndexViewModel ivm =new IndexViewModel{Companies = companyModels, Dresses = _dresses};

            if (companyId != null && companyId > 0)
                ivm.Dresses = _dresses.Where(d => d.Company.Id == companyId);
            return View(ivm);
        }

        public IActionResult GetData(string[] items)
        {
            string result = "";
            foreach (var item in items)
          
                result += item + ";";
            return Content(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
