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
        PortfolioCreationViewModel viewModel = new PortfolioCreationViewModel();
        

        public ActionResult Index()
        {
            viewModel.Sections = db.Sections.ToList();
            return View("Index", viewModel);
        }

        public ActionResult AddSection(Section section)
        {
            // get current sections
            viewModel.Sections = db.Sections.ToList();

            // find next Id for section (largest)
            int nextId = 0;
            foreach (Section s in viewModel.Sections)
            {
                if (s.Id > nextId)
                {
                    nextId = s.Id;
                }

            }

            section.Id = nextId + 1;

            db.Sections.Add(section);
            db.SaveChanges();

            viewModel.Sections = db.Sections.ToList();

            return View("Index", viewModel);
        }

        public ActionResult AddContent(Content content)
        {
            // get current sections
            viewModel.Sections = db.Sections.ToList();

            Section currentSection = db.Sections.SingleOrDefault(s => s.Id == content.SectionId);
            content.SectionId = currentSection.Id;

            // find next Id for section (largest)
            int nextId = 0;
            foreach (Content c in currentSection.Contents)
            {
                if (c.Id > nextId)
                {
                    nextId = c.Id;
                }

            }

            content.Id = nextId + 1;

            db.Contents.Add(content);
            db.SaveChanges();

            viewModel.Sections = db.Sections.ToList();
            return View("Index", viewModel);
        }

        public ActionResult DeleteContent(Content content)
        {
            
            db.Contents.Remove(content);
            db.SaveChanges();

            viewModel.Sections = db.Sections.ToList();
            return View("Index", viewModel);
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