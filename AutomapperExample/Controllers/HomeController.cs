using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutomapperExample.Models;
using AutoMapper;


namespace AutomapperExample.Controllers
{
    public class HomeController : Controller
    {
        SMSEntities db= new SMSEntities();
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<EmployeeSkillsDTO>>(db.tblEmployeeSkills.ToList()));
        }


        public ActionResult Test()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}