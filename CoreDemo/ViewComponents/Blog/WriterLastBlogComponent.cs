using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlogComponent :ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepositoy());
        
        public IViewComponentResult Invoke()
        {
        var values = blogManager.GetBlogListByWriter(3);
            return View(values);
        }
    }
}
