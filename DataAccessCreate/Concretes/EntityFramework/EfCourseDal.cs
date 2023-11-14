using DataAccess.Abstracts;
using Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : ICourseDal
    {
        public void Add(Course entity)
        {
            using (TobetoCourseContext context = new TobetoCourseContext()) 
            {
                var addedCourse = context.Entry(entity);
                addedCourse.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Course entity)
        {
            using(TobetoCourseContext context = new TobetoCourseContext())
            {
                var deletedCourse = context.Entry(entity);
                deletedCourse.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            using(TobetoCourseContext context = new TobetoCourseContext())
            {
                return context.Set<Course>().SingleOrDefault(filter);
            }
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            using(TobetoCourseContext context = new TobetoCourseContext())
            {
                return filter == null
                    ? context.Set<Course>().ToList() 
                    : context.Set<Course>().Where(filter).ToList();
            }
        }

        public void Update(Course entity)
        {
            using(TobetoCourseContext context = new TobetoCourseContext())
            {
                var updatedCourse = context.Entry(entity);
                updatedCourse.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
