using System;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers{
    public class HomeController : Controller{
        [HttpGet]
        [Route("")]
        public IActionResult Index(){
            return View();
        }

        [HttpGet("result")]
        public IActionResult Result(){
            return View();
        }

        [HttpPost("user")]
        public IActionResult MakeUser(User user){
            if(ModelState.IsValid){
                Console.WriteLine("Here is a thing");
                return RedirectToAction("Result");
            }else{
                return Index();
            }
        }
    }
}