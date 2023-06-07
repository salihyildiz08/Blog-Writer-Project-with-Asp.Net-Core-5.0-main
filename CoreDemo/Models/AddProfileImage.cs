using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace CoreDemo.Models
{
    public class AddProfileImage
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WiretImage { get; set; }
        public string WriterMail { get; set; }
        public string WiretPassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}
