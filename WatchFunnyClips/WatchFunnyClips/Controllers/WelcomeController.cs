using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class WelcomeController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }


        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}