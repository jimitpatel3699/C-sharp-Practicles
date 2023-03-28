using Practicle7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicle7
{

    //implementing DIP(Dependency inversion Principle) which states a highlevel module not depend on low lwvwl module,
    //both should depends on abstraction.


    //create interface to remove depency of higher level class on to lower level class.
    public interface IStudentRepository
    {
        void AddStudent(Student std);
        void EditStudent(Student std);
        void DeleteStudent(Student std);

        
    }

    //create class to create refernce at run time.
    public class RepositoryFactory
    {
        public static IStudentRepository GetStudentRepository()
        {
            return new StudentRepository();
        }


    }

    //a higher level class which is consume lower level class through interface.
    
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        private IStudentRepository _stdRepo;

        public Student(IStudentRepository stdRepo)
        {
            _stdRepo = stdRepo;
        }

        public void Save()
        {
            _stdRepo.AddStudent(this);
        }
    }

    
    //lower level class which is implemts interface in it.direct consume lower level class in higher level class we implements abstraction.
    public class StudentRepository : IStudentRepository
    {
        public void AddStudent(Student std)
        {
            Console.WriteLine("Addstudent method of StudentRepository call through interface");
        }

        public void DeleteStudent(Student std)
        {
            Console.WriteLine("DeleteStudent method of StudentRepository call through interface");
        }

        public void EditStudent(Student std)
        {
            Console.WriteLine("EditStudent method of StudentRepository call through interface");
        }

        
    }

    
}


