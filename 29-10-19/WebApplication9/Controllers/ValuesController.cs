using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication9.Controllers
{
    public class ValuesController : ApiController
    {
        
        static List<string> strings = new List<String>()
        {
         "value0","Value1","value2"
        };
        public IEnumerable<string> Get()
        {
        return strings;
        }

       
        public string Get(int id)
        {
            return strings[id];
        }

        
        public void Post([FromBody]string value)
        {
            strings.Add(value);
        }

        
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

      
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
