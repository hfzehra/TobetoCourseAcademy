using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoCourseContext>, ICourseDal
    {
        public List<CourseDetail> GetCourseDetail()
        {
            using (TobetoCourseContext context = new TobetoCourseContext())
            {
                var result = from co in context.Courses
                             join c in context.Categories
                             on co.Id equals c.Id
                             select new CourseDetail
                             {
                                 CourseId = co.Id,
                                 CourseName = co.Name,
                                 CategoryName = c.Name,
                                 Description = co.Description
                             };
                return result.ToList();
            }
        }
    }
}
