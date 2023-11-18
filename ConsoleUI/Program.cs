using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entity.Concretes;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Category category = new Category { Id = 1, Name = "Programlama" };
            //Instructor instructor = new Instructor { Id = 1, First_Name = "engin", Last_Name = "Demiroğ" };

            //EntityManager entityManager = new EntityManager();


            CourseManager courseManager = new CourseManager(new EfCourseDal());
            foreach (var c in courseManager.GetCourseDetail())
            {
                Console.WriteLine(c.CourseId+"-"+c.CourseName+"/"+c.CategoryName);
            }



            //Encapsulation eklecenecek

            //entityManager.Add(instructor,instructor.First_Name);
            //entityManager.Add(category, category.Name);

        }
    }
}