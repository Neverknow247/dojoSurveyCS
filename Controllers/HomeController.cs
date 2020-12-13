using Microsoft.AspNetCore.Mvc;
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
        public IActionResult SurveyResults(string name, string dojo, string language, string comment)
        {
            ViewBag.name = name;
            ViewBag.dojo = dojo;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View("Results");
        }
    }
}