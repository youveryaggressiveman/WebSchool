using MediatR;
using SchoolApp.Application.Models.Groups.Queries.GetUserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Groups.Queries.GetGroupDetails
{
    public class GetGroupDetailsQuery : IRequest<GroupDetailsVm>
    {
        public int ID { get; set; }
    }
}
