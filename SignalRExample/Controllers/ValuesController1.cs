using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SignalRExample.Repository;

namespace SignalRExample.Controllers
{
    public class ValuesController : ApiController
    {
        JobInfoRepository objRepo = new JobInfoRepository();
        // GET api/<controller>
        public IEnumerable<JobInfo> Get()
        {
            return objRepo.GetData();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}