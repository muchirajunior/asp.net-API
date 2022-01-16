using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspapi.Controllers
{
    [ApiController]
    [Route("")]
     public class HomeController : ControllerBase
    {
        [Route("")]
        [Route("home")] //adding two routes on same service
        public String homePage() => "  hello this is the home page"; 

        [Route("about")]
        public String aboutPage()=> "hello this is about us page";

        [Route("data")]
        public Dictionary<String, dynamic> data(){ 
            var d=new Dictionary<string, dynamic>{};
            d.Add("name","muchira junior");
            d.Add("numbers",new List<int>{1,2,3,4});
            return d;
        }

        [Route("user/{username}")]
        public dynamic getUser(String username){
            var d=new Dictionary<String ,dynamic>{ };
            d.Add(" username",username);
            return d ;
        }

        [Route("search")]
        //use /search?id=&token=
        public dynamic search(int id,String token) => $"id is {id} and token is {token}";

        [Route("[controller]/[action]")]
        //this route return home/getname that is name of the controller followed by service name as action
        public dynamic GetName(){
            var name=new Dictionary<String,dynamic>{};
            name.Add("name","muchira junior");

            return name;
        }

        //route constrains user id should be an intenger and more than 20 and less than 40
        [Route("user/{id:int:min(20):max(40)}")]
        public string getUserId(int id)=> $"this user id number {id}"; 
    }

    
}