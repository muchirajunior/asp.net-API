using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace aspapi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class RestController : ControllerBase{

        [HttpGet]
        public  dynamic getData()
        {
            return new List<UserModel>(){ 
                new UserModel(){id=1},
                new UserModel(){name="junior"}
            } ;
        }

        [HttpPost]
        public IActionResult PostData( )
        {
            //TODO: Implement Realistic Implementation
            return Created("", null);
        }
    }
}