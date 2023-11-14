using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
        List<Instructor> GetAll();
    }
}
