using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using aspapi.Models;

namespace aspapi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class RestController : ControllerBase{

        [BindProperty]
        public string name {get; set;}

        [BindProperty]
        public int id {get; set;}
        

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
        //this method takes form data and sets it to local bind properties
        public IActionResult PostData( )
        {
            //TODO: Implement Realistic Implementation
            return Ok(new UserModel(){id=this.id, name=this.name});
        }

        [HttpPost]
        //this method takes in a json body request and maps it to the user model
        //perfect post in api using from nody binder
        public IActionResult userData([FromBody]UserModel user){
            return Ok(user);
        }


    }
}