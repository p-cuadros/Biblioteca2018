using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Biblioteca.Distribucion.API.Controllers
{
    public class EjemploController : ApiController
    {
        // GET: api/Ejemplo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Ejemplo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ejemplo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Ejemplo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ejemplo/5
        public void Delete(int id)
        {
        }
    }
}
