using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kursach.Controllers{
    public class HelloWorldController : Controller{
        // 
        // GET: /HelloWorld/

        public IActionResult Index(){
            
            return View();
            //return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        //[HttpPost]

        
        public IActionResult Welcome(string name, int numTimes = 1){
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            
            // SearchPageModel Model = new SearchPageModel();
            // Model.ImageURL = "gif";

            return View();
        }
        
    }
}