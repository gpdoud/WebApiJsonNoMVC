using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiJsonNoMVC.Models;

namespace WebApiJsonNoMVC.Controllers {
    public class StudentController : ApiController {

        List<Student> students = new List<Student>() {
            new Student(1, "Greg", 400, 1.5),
            new Student(2, "Cindy", 1600, 4.5),
            new Student(3, "Nick", 1400, 3.5),
            new Student(4, "Ken", 1400, 3.5)
        };
 
        // GET api/<controller>
        public IEnumerable<Student> Get() {
            return students.ToArray();
        }

        // GET api/<controller>/5
        public Student Get(int id) {
            return students.SingleOrDefault(s => s.Id == id);
        }

        // INSERT: POST api/<controller>
        public void Post([FromBody]Student student) {
            students.Add(student);
        }

        // UPDATE: PUT api/<controller>/5
        public void Put(int id, [FromBody]Student student) {
            Student studentToUpdate = students.SingleOrDefault(s => s.Id == student.Id);
            studentToUpdate.Name = student.Name;
            studentToUpdate.Sat = student.Sat;
            studentToUpdate.Gpa = student.Gpa;
        }

        // DELETE api/<controller>/5
        public void Delete(int id) {
            students.Remove(students.SingleOrDefault(s => s.Id == id));
        }
    }
}