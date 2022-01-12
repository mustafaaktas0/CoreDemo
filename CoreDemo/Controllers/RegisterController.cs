using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepositoy());

        [HttpGet]// Sayfa yuklenince
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]// sayfadaki kaydet tetiklenince
        public IActionResult Index(Writer writer)
        {
            writer.WirterStatus = true;
            writer.WirterAbout = "Deneme Test";
            _writerManager.WriterAdd(writer);
            return RedirectToAction("Index", "Blog");
        }
    }
}
