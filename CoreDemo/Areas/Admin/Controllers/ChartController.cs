using CoreDemo.Areas.Admin.Models;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass { categoryName= "Technology",categoryCount=10 
            });
            list.Add(new CategoryClass
            {
                categoryName = "Software",
                categoryCount = 14
            });
            list.Add(new CategoryClass
            {
                categoryName = "Sport",
                categoryCount = 5
            });
            list.Add(new CategoryClass
            {
                categoryName = "Cinema",
                categoryCount = 2
            });
            return Json(new { jsonlist=list});
        }
    }
}
