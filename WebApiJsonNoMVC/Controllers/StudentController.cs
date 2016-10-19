using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiJsonNoMVC.Models;

namespace WebApiJsonNoMVC.Controllers {
    public class StudentController : ApiController {

        Student[] students = new Student[] {
            new Student("Greg", 400, 1.5),
            new Student("Cindy", 1600, 4.5),
            new Student("Nick", 1400, 3.5),
            new Student("Ken", 1400, 3.5)
        };
 
        // GET api/<controller>
        public IEnumerable<Student> Get() {
            return students;
        }

        // GET api/<controller>/5
        public string Get(int id) {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value) {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/<controller>/5
        public void Delete(int id) {
        }
    }
}