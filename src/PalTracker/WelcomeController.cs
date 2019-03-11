using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public string SayHello() => "hello";

           
    }

    [Route("/Humana")]
    public class HumWelcomeController : ControllerBase
    {
        [HttpGet]
        public string SayHello() => "Welcome to Humana!";
        
    }

    [Route("/Humana/api")]
    public class HumApiWelcomeController : ControllerBase
    {
      
        [HttpGet]
        public string HumApi(string val)
        {
            return val;
        }
        
    }
}