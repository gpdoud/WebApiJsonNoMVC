using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiJsonNoMVC.Controllers {
    public class StudentController : ApiController {

        DbContext db = new DbContext();
 
        // GET api/<controller>
        public IEnumerable<Student> Get() {
            return db.Students.ToArray();
        }

        // GET api/<controller>/5
        public Student Get(int id) {
            return db.Students.SingleOrDefault(s => s.Id == id);
        }

        // INSERT: POST api/<controller>
        public void Post([FromBody]Student student) {
            db.Students.Add(student);
            db.SaveChanges();
        }

        // UPDATE: PUT api/<controller>/5
        public void Put(int id, [FromBody]Student student) {
            var studDb = db.Students.SingleOrDefault(s => s.Id == student.Id);
            studDb.Name = student.Name;
            studDb.Sat = student.Sat;
            studDb.Gpa = student.Gpa;
            db.SaveChanges();
        }

        // DELETE api/<controller>/5
        public void Delete(int id) {
            db.Students.Remove(db.Students.SingleOrDefault(s => s.Id == id));
            db.SaveChanges();
        }
    }
}