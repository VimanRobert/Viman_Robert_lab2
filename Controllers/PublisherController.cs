using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Viman_Robert_lab2.Data;

namespace Viman_Robert_lab2.Controllers
{
    [Authorize(Policy = "OnlySales")]
    public class PublisherController : Controller
    {
        private readonly LibraryContext _context;
        public PublisherController(LibraryContext context)
        {
            _context = context;
        }
    }
}
