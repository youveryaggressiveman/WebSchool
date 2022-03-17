using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolApp.Application.Models.TimeSubjects.Queries.GetTimeSubjectDetails;

namespace SchoolApp.Application.Models.TimeSubjects.Queries.GetTimeSubject
{
    public class GetTimeSubjectQuery : IRequest<IEnumerable<TimeSubjectDetailsVm>>
    {
    }
}
