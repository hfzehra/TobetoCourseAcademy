using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        List<Category> GetAll();
        
    }
}
