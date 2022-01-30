using Microsoft.AspNetCore.Mvc;
using ModelsForms.Models;

namespace ModelsForms.Controllers
{
    public class User : Controller
    {

        [HttpGet("")]
        public IActionResult WizardRegForm(){
            return View();
        }
        [HttpPost("register")]
        public IActionResult RegisterWizard(HogwartsStudent student) {

            return View();
        }
    }
}