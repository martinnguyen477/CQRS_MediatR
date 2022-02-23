using CQRS_MediatR.DataAccess;
using CQRS_MediatR.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_MediatR.Commands
{
    /// <summary>
    /// Handler CUD.
    /// </summary>
   public class AddStudentCommand : StudentModel, IRequest<StudentModel>
    {
        public class AddStudentHandler : StudentModel, IRequestHandler<AddStudentCommand, StudentModel>
        {
            private readonly IStudentServices _data;
            public AddStudentHandler(IStudentServices data)
            {
                _data = data;
            }
            public Task<StudentModel> Handle(AddStudentCommand request, CancellationToken cancellationToken)
            {
                return Task.FromResult(_data.AddStudent(request.FirstName, request.LastName, request.Age));
            }
        }
    }
}
