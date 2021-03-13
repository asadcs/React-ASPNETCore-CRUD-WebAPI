using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace React_ASPNETCore_CRUD_WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public HttpResponseMessage Get()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DeptID");
            dt.Columns.Add("DeptName");


            dt.Rows.Add("1", "MIS");
            dt.Rows.Add("2", "Software");

            return Request.CreateResponse(HttpStatusCode.OK, dt);

            //return new string[] { "value1", "value2" };
        }



        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
