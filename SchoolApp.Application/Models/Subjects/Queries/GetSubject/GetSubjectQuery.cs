using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolApp.Application.Models.Subjects.Queries.GetSubjectDetails;

namespace SchoolApp.Application.Models.Subjects.Queries.GetSubject
{
    public class GetSubjectQuery : IRequest<IEnumerable<SubjectDetailsVm>>
    {
    }
}
