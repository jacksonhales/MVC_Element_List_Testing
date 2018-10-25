using MVC_Element_List_Testing.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Element_List_Testing.Controllers
{
    public class HomeController : Controller
    {
        private Database1Entities db = new Database1Entities();
        //List<Section> sections = db.Sections.;
        IEnumerable<Section> sections;

        public ActionResult Index()
        {
            sections = db.Sections.ToList();
            return View("Index", sections);
        }

        public ActionResult AddSection(Section section)
        {
            
            db.Sections.Add(section);
            db.SaveChanges();

            sections = db.Sections.ToList();
            return View("Index", sections);
        }

        public ActionResult AddContent(Content content)
        {

            db.Contents.Add(content);
            db.SaveChanges();

            sections = db.Sections.ToList();
            return View("Index", sections);
        }

        public ActionResult DeleteContent(Content content)
        {
            db.Contents.Remove(content);
            db.SaveChanges();

            sections = db.Sections.ToList();
            return View("Index", sections);
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