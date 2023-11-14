using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _category;
        public CategoryManager(ICategoryDal category)
        {
            _category = category;
        }
        public void Add(Category category)
        {
            _category.Add(category);
        }

        public void Delete(Category category)
        {
            _category.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _category.GetAll();
        }

        public void Update(Category category)
        {
            _category.Update(category);
        }
    }
}
