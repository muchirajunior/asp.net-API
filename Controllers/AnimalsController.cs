using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using aspapi.Models;

namespace aspapi.Controllers{

    [ApiController]
    [Route("[controller]")]
   public class AnimalsController : ControllerBase{

       [BindProperty]
       public UserModel Animals {get; set;} //we will use the user model because the Animals has a constructer
        
        [Route("")]
        [HttpGet]
        public ActionResult<List<AnimalsModel>> getAnimals(){
            return new List<AnimalsModel>{
                new AnimalsModel(1,"puppy"),
                new AnimalsModel(name:"chiwawa",id:2)
            };
        }

        [Route("bad")]
        [HttpGet]
        public IActionResult badRequest()=> BadRequest();

        [HttpGet("redirect")]
        public IActionResult redirect()=> Redirect("bad");

        [HttpPost("data")]
        //this method takes form data and sets it to  bind property Animals
        public IActionResult animalData()=> Ok(Animals);

    }
}