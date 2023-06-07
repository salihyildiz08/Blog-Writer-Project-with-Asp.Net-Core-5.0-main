using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           // BlogManager bm = new BlogManager(new EfBlogRepository());
            Context c = new Context();
            
                //ViewBag.v1 = bm.GetList().Count();
                ViewBag.v1 = c.Blogs.OrderByDescending(x=>x.BlogID).Select(x=>x.BlogTitle).Take(1).FirstOrDefault();
                ViewBag.v3 = c.Comments.Count();
                return View();
        }
    }
}
