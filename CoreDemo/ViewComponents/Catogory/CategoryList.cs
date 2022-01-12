using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Catogory
{
    public class CategoryList : ViewComponent
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepositoy());
        public IViewComponentResult Invoke()
        {
            var values = _categoryManager.GetAllList();
            return View(values);
        }
    }
}
