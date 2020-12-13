using Microsoft.AspNetCore.Mvc;
using dojoSurvey.Models;
namespace dojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        //[HttpPost]
        //[Route("survey")]

        [HttpPost("survey")]
        public IActionResult SurveyResults(Survey results)
        {
            // Survey results = new Survey()
            // {
            //     name = name,
            //     dojo = dojo,
            //     language = language,
            //     comment = comment,
            // };
            // ViewBag.name = name;
            // ViewBag.dojo = dojo;
            // ViewBag.language = language;
            // ViewBag.comment = comment;
            return View("Survey",results);
        }
    }
}