using ContextService;
using CoreDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnitOfWork.UnitofWorkPattern;

namespace APICarRental.Controllers
{
    public class ValuesController : ApiController
    {
        readonly IUnitOfWork UnitOfWork;
      
        public ValuesController( )
        {
            this.UnitOfWork = new UnitOfWork.UnitofWorkPattern.UnitOfWork(new DatabaseContext());
            
        }
        // GET: api/Values
        public IEnumerable<string> Get()
        {
           
            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
        }
    }
}
