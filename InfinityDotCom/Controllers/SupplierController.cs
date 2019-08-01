using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfinityDotCom.BLL.BLL;
using InfinityDotCom.Models.Models;

namespace InfinityDotCom.Controllers
{
    public class SupplierController : Controller
    {
        SupplierManager _supplierManager = new SupplierManager();
        Master _master = new Master();

        [HttpGet]
        public ActionResult Index()
        {
            return View(_supplierManager.GetAll());
        }
        [HttpPost]
        public ActionResult Index(Supplier supplier)
        {
            _supplierManager.Add(supplier);
            return RedirectToAction("Index", "Supplier");
        }
        public ActionResult Delete(int id)
        {
            _supplierManager.Delete(id);
            return RedirectToAction("Index", "Supplier");
        }
        public ActionResult Edit(int id)
        {
            _master.Supplier = _supplierManager.GetByID(id);
            _master.Suppliers = _supplierManager.GetAll();
            return View(_master);
        }
        public ActionResult Update(Supplier supplier)
        {
            _supplierManager.Update(supplier);
            return RedirectToAction("Index", "Supplier");
        }
    }
}