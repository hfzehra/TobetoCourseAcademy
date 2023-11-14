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
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            using (TobetoCourseContext context = new TobetoCourseContext()) { 
                var addedCategory = context.Entry(entity);
                addedCategory.State=EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using(TobetoCourseContext context = new TobetoCourseContext()){
                var deletedCategory = context.Entry(entity);
                deletedCategory.State=EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (TobetoCourseContext context = new TobetoCourseContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using(TobetoCourseContext context = new TobetoCourseContext()){
                return filter == null
                    ? context.Set<Category>().ToList()
                    : context.Set<Category>().Where(filter).ToList();
            }
        }

        public void Update(Category entity)
        {
            using(TobetoCourseContext context = new TobetoCourseContext()){
                var updateCategory = context.Entry(entity);
                updateCategory.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
