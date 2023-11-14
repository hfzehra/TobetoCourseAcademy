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
    public class EfInstructorDal : IInstructorDal
    {
        public void Add(Instructor entity)
        {
            using (TobetoCourseContext context = new TobetoCourseContext())
            {
                var addedInstructor = context.Entry(entity);
                addedInstructor.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Instructor entity)
        {
            using(TobetoCourseContext context = new TobetoCourseContext())
            {
                var deletedInstructor = context.Entry(entity);
                deletedInstructor.State = EntityState.Deleted; 
                context.SaveChanges();
            }
        }

        public Instructor Get(Expression<Func<Instructor, bool>> filter)
        {
            using(TobetoCourseContext context = new TobetoCourseContext())
            {
                return context.Set<Instructor>().SingleOrDefault(filter);
            }
        }

        public List<Instructor> GetAll(Expression<Func<Instructor, bool>> filter = null)
        {
            using(TobetoCourseContext context = new TobetoCourseContext())
            {
                return filter == null
                    ? context.Set<Instructor>().ToList() 
                    : context.Set<Instructor>().Where(filter).ToList();
            }
        }

        public void Update(Instructor entity)
        {
            using(TobetoCourseContext context = new TobetoCourseContext())
            {
                var updatedInstructor = context.Entry(entity);
                updatedInstructor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
