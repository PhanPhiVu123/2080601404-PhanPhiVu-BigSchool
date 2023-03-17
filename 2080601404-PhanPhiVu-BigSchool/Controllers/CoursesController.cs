using _2080601404_PhanPhiVu_BigSchool.Models;
using _2080601404_PhanPhiVu_BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace _2080601404_PhanPhiVu_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        private readonly  ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();    
        }
        // GET: Courses
        public ActionResult create()
        {
            var viewModel = new CourseViewModel
            { Categories = _dbContext.Categories.ToList() };
            return View(viewModel);
        }
    }
}