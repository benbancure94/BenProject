using BenProject.Core.Model;
using BenProject.Infrastructure.Data.Repository;
using BenProject.WebApplication.MVC.Helper;
using BenProject.WebApplication.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenProject.WebApplication.MVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<Family> families = FamilyRepository.Instance.GetFamilies();
            List<FamilyViewModel> familyViewModels = ModelConverter.ToFamilyViewModel(families);
            return View(familyViewModels);
        }
    }
}