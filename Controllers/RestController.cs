using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using aspapi.Models;

namespace aspapi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class RestController : ControllerBase{

        [HttpGet]
        [Route("{id}")]
        public string get(int id)=> "this rest default url "+id;

        [HttpGet]
        public  dynamic getData()
        {
            return new List<UserModel>(){ 
                new UserModel(){id=1, name="james"},
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