using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfinityDotCom.Models.Models;
using InfinityDotCom.BLL.BLL;

namespace InfinityDotCom.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager();
        Master _master = new Master();

        [HttpPost]
        public ActionResult Add(Category category)
        {
            _categoryManager.Add(category);
            return RedirectToAction("Index", "Product");
        }
        public ActionResult Delete(int id)
        {
            _categoryManager.Delete(id);
            return RedirectToAction("Index", "Product");
        }
        public ActionResult Edit(int id)
        {
            _master.Category = _categoryManager.GetByID(id);
            _master.Categories = _categoryManager.GetAll();
            return View(_master);
        }
        [HttpPost]
        public ActionResult Update(Category category)
        {
            _categoryManager.Update(category);
            return RedirectToAction("Update", "Category");
        }
        [HttpGet]
        public ActionResult Update()
        {
            _master.Categories = _categoryManager.GetAll();
            return View(_master);
        }
    }
}