using MediatR;
using SchoolApp.Application.Models.Groups.Queries.GetUserDetails;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Groups.Queries.GetGroup
{
    public class GetGroupQuery : IRequest<IEnumerable<GroupDetailsVm>>
    {
    }
}
