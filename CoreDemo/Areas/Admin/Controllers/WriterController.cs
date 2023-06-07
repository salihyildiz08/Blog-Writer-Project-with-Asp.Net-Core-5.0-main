using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters=JsonConvert.SerializeObject(writerss);
            return Json(jsonWriters);
        }
        public IActionResult GetWriterByID(int writerid)
        {
            var findwriter=writerss.FirstOrDefault(x=>x.Id == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findwriter);
            return Json(jsonWriters);
        }
        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writerss.Add(w);
            var  jsonWriters=JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }
        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writerss.FirstOrDefault(x => x.Id == w.Id);
            writer.Name = w.Name;
            var jsonWriter=JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
        }
        public IActionResult DeleteWriter(int id)
        {
            var writer = writerss.FirstOrDefault(x => x.Id == id);
            writerss.Remove(writer);
            return Json(writer);

        }

        public static List<WriterClass> writerss = new List<WriterClass>
        {
            new WriterClass()
            {
                Id = 1,
                Name="zeliha"
            },
            new WriterClass()
            {
                Id = 2,
                Name="humeyra"
            },
            new WriterClass()
            {
                Id = 3,
                Name="mustafa"
            }
        };

    }
}
