using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BIApi.DBContext;

namespace BIApi.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        // GET api/data
        [HttpGet]
        public BaseModel Get()
        {
            var resultModel = new BaseModel();
            var patients = new List<Patient>();
            var db = new DB();
            try {
                patients = db.Patients.ToList();
            }
            catch(Exception e) {
                resultModel.IsError = true;
                resultModel.Message = e.Message;
            }
            resultModel.Data = patients;

            return resultModel;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
