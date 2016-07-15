using System.Collections.Generic;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class KeysController : ApiController
    {
        public KeysController()
        {
            
        }
        public IEnumerable<Key> Get()
        {
            var keys = new List<Key>
            {
                new Key { ProductName = "QABook BugReach", SerialNumber = 1234 },
                new Key { ProductName = "QABook Desktop", SerialNumber = 9876 }
            };

            return keys;
        }
    }
}
