using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_1.Controllers
{
    public class DemoController : ApiController
    {
        static List<string> continents = new List<string> { "Asia","Africa","Anatartica",
        "Europe","America"};

        //Get : api/Demo

        public IEnumerable<string> Get()
        {
            return continents;
        }

        //Get : api/Demo/Id
        public string Get(int Id)
        {
            return continents[Id];
        }

        //Post using a Model Object

        //Put : api/Demo/Id
        [HttpPut]
       public IEnumerable<string>Put(int Id, [FromUri] string c)
        {
            continents[Id - 1] = c;
            return continents;
        }

        //Delete : api/Demo/Id
        //1. After Delete show the changes
        public IEnumerable<string>Delete(int Id)
        {
            continents.RemoveAt(Id - 1);
            return continents;
        }

    }
}
