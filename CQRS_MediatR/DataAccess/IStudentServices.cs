using CQRS_MediatR.Model;
using System.Collections.Generic;

namespace CQRS_MediatR.DataAccess
{
    public interface IStudentServices
    {
        List<StudentModel> GetStudents();

        StudentModel AddStudent(string firstName, string lastName, double age);

        StudentModel GetStudentById(int id);
    }
}
