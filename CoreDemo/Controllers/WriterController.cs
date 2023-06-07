using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using CoreDemo.ViewComponents.Blog;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            Context c = new Context();
            var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2 = writerName;
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavBarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            //Context c = new Context();
            //var username = User.Identity.Name;
            //var usermail=c.Users.Where(x=>x.UserName==username).Select(y=>y.Email).FirstOrDefault();
            //UserManager userManager = new UserManager(new EfUserRepository());
            ////var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            ////var writervalues = wm.TGetById(writerID);
            ////return View(writervalues);
            ////var values=await _userManager.FindByNameAsync(User.Identity.Name);
            //var id=c.Users.Where(x=>x.Email==usermail).Select(y=>y.Id).FirstOrDefault();
            //var values = userManager.TGetById(id);
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.mail = values.Email;
            model.namesurname = values.NameSurname;
            model.imageurl = values.ImageUrl;
            model.username = values.UserName;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);           
            values.Email= model.mail;
            values.NameSurname= model.namesurname;
            values.UserName= model.username;
            values.ImageUrl= model.imageurl;
            values.PasswordHash=_userManager.PasswordHasher.HashPassword(values,model.password);
            var resualt = await _userManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard");


        }
        [HttpGet]
        public IActionResult WrriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WrriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.WiretImage != null)
            {
                var extension = Path.GetExtension(p.WiretImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFile/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WiretImage.CopyTo(stream);
                w.WiretImage = newimagename;
            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WiretPassword = p.WiretPassword;
            w.WriterStatus = p.WriterStatus;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
