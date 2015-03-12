using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting
{
    class Student
    {
        public int StudentId { get; set; }
        public string  StudentName { get; set; }

        public string  TeleNo { get; set; }

     public virtual  List<Course> Course { get; set; }



     public Student() { 
     
      this.Course = new List<Course>();
     }
    }
}
