using CQRS_MediatR.DataAccess;
using CQRS_MediatR.Model;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_MediatR.Queries
{
    /// <summary>
    /// Handler Read.
    /// </summary>
    public class GetStudentListQuery : IRequest<List<StudentModel>>
    {
        public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentModel>>
        {
            /// <summary>
            /// Dependecy Injection.
            /// </summary>
            private readonly IStudentServices _data;
            public GetStudentListHandler(IStudentServices data)
            {
                _data = data;
            }

            /// <summary>
            /// Handle.
            /// </summary>
            /// <param name="request">Parameter request.</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public Task<List<StudentModel>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
            {
                //Data Access - Store Procedure.
                return Task.FromResult(_data.GetStudents());
            }
        }
    }
}
