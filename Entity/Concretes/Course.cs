using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Abstracts;

namespace Entity.Concretes
{
    public class Course : IEntities
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public Category category { get; set; }
        public CourseInstructor[] courseınstructers { get; set; }
    }
}
