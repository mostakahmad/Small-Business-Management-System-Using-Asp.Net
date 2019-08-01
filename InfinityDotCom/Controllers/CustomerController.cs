using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfinityDotCom.BLL.BLL;
using InfinityDotCom.Models.Models;

namespace InfinityDotCom.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager();
        Master _master = new Master();

        // GET: Customer
        [HttpGet]
        public ActionResult Index()
        {
            return View(_customerManager.GetAll());
        }
        [HttpPost]
        public ActionResult Index(Customer customer)
        {
            _customerManager.Add(customer);
            return RedirectToAction("Index", "customer");
        }
        public ActionResult Delete(int id)
        {
            _customerManager.Delete(id);
            return RedirectToAction("Index", "Customer");
        }
        public ActionResult Edit(int id)
        {
            _master.Customer = _customerManager.GetByID(id);
            _master.Customers = _customerManager.GetAll();
            return View(_master);
        }
        public ActionResult Update(Customer customer)
        {
            _customerManager.Update(customer);
            return RedirectToAction("Index", "Customer");
        }
    }
}