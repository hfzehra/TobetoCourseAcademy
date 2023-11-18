using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _course;
        public CourseManager(ICourseDal course)
        {
            _course = course;
        }
        public void Add(Course course)
        {
            _course.Add(course);
        }

        public void Delete(Course course)
        {
            _course.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _course.GetAll();
        }

        public List<CourseDetail> GetCourseDetail()
        {
            return _course.GetCourseDetail();
        }

        public void Update(Course course)
        {
            _course.Update(course);
        }
    }
}
