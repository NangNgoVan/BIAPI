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
        /// <summary>
        /// Lấy danh sách dịch vụ y tế.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        /// <returns>Kết quả trả về</returns>
        [Produces("application/json")]
        [HttpPost("MedicalServices")]
        public ResultModel MedicalServices([FromBody]List<MedicalServiceModel> data)
        {
            var resultModel = new ResultModel();
            // var patients = new List<Patient>();
            // var db = new DB();
            // try {
            //     patients = db.Patients.ToList();
            // }
            // catch(Exception e) {
            //     resultModel.IsError = true;
            //     resultModel.Message = e.Message;
            // }
            // resultModel.Data = patients;
            resultModel.Data = data;

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
