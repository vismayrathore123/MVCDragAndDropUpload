using Microsoft.AspNetCore.Mvc;
using MVCDragAndDropUpload.Models;
using System.Diagnostics;

namespace MVCDragAndDropUpload.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFiles(IEnumerable<HttpPostedFileBase> files)
        {
            foreach (var file in files)
            {
                string filePath = Guid.NewGuid() + Path.GetExtension(file.FileName);
                file.SaveAs(Path.Combine(Server.MapPath("~/UploadedFiles"), filePath));
            
            }
            return Json("file uploaded succesfuuly");
        } 
        
    }
}