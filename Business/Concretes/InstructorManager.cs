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
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructor;

        public InstructorManager(IInstructorDal instructor)
        {
            _instructor = instructor; 
        }

        public void Add(Instructor instructor)
        {
            _instructor.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructor.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructor.GetAll();
        }

        public void Update(Instructor instructor)
        {
            _instructor.Update(instructor);
        }
    }
}
