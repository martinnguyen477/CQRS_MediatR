using CQRS_MediatR.Model;
using System.Collections.Generic;
using System.Linq;

namespace CQRS_MediatR.DataAccess
{
    /// <summary>
    /// Handle Data Access.
    /// </summary>
    public class StudentServices : IStudentServices
    {
        private List<StudentModel> student = new List<StudentModel>();

        public StudentServices()
        {
            student.Add(new StudentModel { Id = 1, FirstName = "Jhon", LastName = "Doe", Age = 18 });
            student.Add(new StudentModel { Id = 2, FirstName = "Amelia", LastName = "Amy", Age = 16 });
        }

        public StudentModel AddStudent(string firstName, string lastName, double age)
        {
            StudentModel s = new StudentModel();
            s.FirstName = firstName;
            s.LastName = lastName;
            s.Age = age;
            s.Id = student.Count() + 1;
            student.Add(s);
            return s;
        }

        public StudentModel GetStudentById(int id)
        {
            var stu = student.Where(t => t.Id == id).FirstOrDefault();
            return stu;
        }

        public List<StudentModel> GetStudents()
        {
            return student;
        }
    }
}
