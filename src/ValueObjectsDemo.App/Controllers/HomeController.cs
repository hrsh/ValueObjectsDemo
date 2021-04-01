using Microsoft.AspNetCore.Mvc;

namespace ValueObjectsDemo.App.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            var shoe = new Shoe(1, new Price(1000, 1), new Size(12.5));
            var newPrice = shoe.Price with {Amount = 1100};
            shoe.Price = newPrice;

            return Ok();
        }
    }
}