using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFTesting
{
    class Course
    {
        public int CourseId { get; set; }

        public string  CourseName { get; set; }

        public string  Description { get; set; }

        public virtual Student Student { get; set; }

    }
}
