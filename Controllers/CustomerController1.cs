using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Viman_Robert_lab2.Data;

namespace Viman_Robert_lab2.Controllers
{
    [Authorize(Policy = "SalesManager")]
    public class CustomerController : Controller
    {
        private readonly LibraryContext _context;
        private string _baseUrl = "http://localhost:58730/api/Customers";

        public CustomerController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
