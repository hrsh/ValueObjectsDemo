using Microsoft.AspNetCore.Mvc;

namespace ValueObjectsDemo.App.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {

            return Ok();
        }
    }
}