using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspapi.Controllers
{
    [ApiController]
     public class HomeController : ControllerBase
    {
        [Route("")]
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
    }

    
}