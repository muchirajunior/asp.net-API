using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspapi.Controllers
{
    [ApiController]
    [Route("test/[action]")]

    public class TestController : ControllerBase {

        public String Get(){
            return "hello test from the route";
        }

         public String Get2(){
            return "hello 2 test from the route";
        }
    }
}