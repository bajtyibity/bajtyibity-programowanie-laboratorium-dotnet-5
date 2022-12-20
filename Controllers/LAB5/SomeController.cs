using Microsoft.AspNetCore.Mvc;
using WebApplication3.Services.LAB5;

namespace WebApplication3.Controllers.LAB5
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        public string CallMethod()
        {
            var someInstance = new SomeClass();
            return someInstance.Print(null);
        }
    }

}