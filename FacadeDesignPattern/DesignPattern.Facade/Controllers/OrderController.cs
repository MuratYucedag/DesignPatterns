using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {

        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderDetailStart(int customerID, int productId, int orderID, int productCount, decimal productPrice)
        {
            OrderFacade order = new OrderFacade();
            order.CompleteOrderDetail(customerID, productId, orderID, productCount, productPrice);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderStart(int customerID)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrder(customerID);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
