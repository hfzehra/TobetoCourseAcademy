using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Abstracts;

namespace Entity.Concretes
{
    public class CourseInstructor :IEntities
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int InstructerId { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
