using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);

        List<Course> GetAll();
        List<CourseDetail> GetCourseDetail();
    }
}
