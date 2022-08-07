using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using OrderProcessingSample.Models;
using OrderProcessingSample.Models.ViewModels;

namespace OrderProcessingSample.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OrderProcessing()
        {
            //OrderProcessingViewModel orderViewModel = new OrderProcessingViewModel();
            //orderViewModel.Items = new List<Items>();
            //orderViewModel.Items = _context.Items.ToList();
            ViewData["items"] = _context.Items.ToList().Select(c => new SelectListItem() { Text = c.Description, Value = c.Id.ToString()});
            return View();
        }

        public JsonResult GetItem (int id)
        {
            Items item = new Items();
            item = _context.Items.Find(id);
            return Json(item);
        }

        [HttpPost]
        public IActionResult CreateOrder(List<OrderViewModel> model)
        {
            return View();
        }
    }
}
