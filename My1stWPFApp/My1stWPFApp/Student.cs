using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My1stWPFApp
{
    class Student
    {
        
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string EnrollType { get; set; }

        public Student(string id,string fn,string ln,string d,string e)
        {
            StudentID = id;
            FirstName = fn;
            LastName = ln;
            Department = d;
            EnrollType = e;
        }

        /*
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int i, string n, int a)
        {
            this.Id = i;
            this.Name = n;
            this.Age = a;
        }
        */
    }
}
