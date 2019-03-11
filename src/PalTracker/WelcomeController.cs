using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        private readonly WelcomeMessage _message;

        [HttpGet]
        public string SayHello() => _message.Message;

        public WelcomeController(WelcomeMessage message)
        {
            _message = message;
        }
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