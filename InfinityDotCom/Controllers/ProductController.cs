using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfinityDotCom.Models.Models;
using InfinityDotCom.BLL.BLL;

namespace InfinityDotCom.Controllers
{
    public class ProductController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager();
        ProductManager _productManager = new ProductManager();
        Master _master = new Master();

        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            _master.Products = _productManager.GetAll();
            _master.Categories = _categoryManager.GetAll();
            return View(_master);
        }
        [HttpPost]
        public ActionResult Index(Product product)
        {
            _productManager.Add(product);
            _master.Products = _productManager.GetAll();
            _master.Categories = _categoryManager.GetAll();
            return View(_master);
        }
        public ActionResult Delete(int id)
        {
            _productManager.Delete(id);
            return RedirectToAction("Index", "Product");
        }
        public ActionResult Edit(int id)
        {
            _master.Product = _productManager.GetByID(id);
            _master.Products = _productManager.GetAll();
            _master.Categories = _categoryManager.GetAll();
            return View(_master);
        }
        public ActionResult Update(Product product)
        {
            _productManager.Update(product);
            return RedirectToAction("Index", "Product");
        }
    }
}