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
                if (value < 400 || value > 1600)
                    throw new ApplicationException("SAT is out of range;");
                _sat = value;
            }
        }
        public double Gpa { get; set; }

        public Student() { }
        public Student(int id, string name, int sat, double gpa) {
            Id = id;
            Name = name;
            Sat = sat;
            Gpa = gpa;
        }
    }
}