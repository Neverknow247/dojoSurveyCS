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
            return View("Survey",results);
        }

        [HttpPost("survey/create")]
        public IActionResult Create(Survey user)
        {
            if (ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return View("Survey", user);
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }
        public IActionResult Success(Survey user)
        {
            return View("Survey", user);
        }
    }
}