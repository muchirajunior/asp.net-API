using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using aspapi.Models;
using aspapi.Binders;
using aspapi.Services;

namespace aspapi.Controllers{

    [ApiController]
    [Route("[controller]")]
   public class AnimalsController : ControllerBase{

       private readonly IAnimalServices _ianimalServices;

       public AnimalsController(IAnimalServices animalServices){
           this._ianimalServices=animalServices;
       }

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

        [HttpGet("search")]
        //using a custom model binder to separate search?animals=dog|cow|puppy and return an array of the query string
        public IActionResult search([ModelBinder(typeof(AnimalsBinder))] string[] animals ) => Ok(animals);

        [HttpGet("add")]
        public IActionResult AddAnimal([FromQuery]string name){
            AnimalsModel animalsModel=new AnimalsModel(id:1,name:name);
            _ianimalServices.addAnimal(animalsModel);

            return Ok(_ianimalServices.GetAllAnimals());
        }

    }
}