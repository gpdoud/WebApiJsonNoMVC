using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiJsonNoMVC.Models {
    public class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        int _sat;
        public int Sat {
            get {
                return _sat;
            }
            set {
                _sat = value;
            }
        }
        public double Gpa { get; set; }

        public Student() { }
        public Student(string name, int sat, double gpa) {
            Name = name;
            Sat = sat;
            Gpa = gpa;
        }
    }
}